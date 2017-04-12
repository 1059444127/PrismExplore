using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace DynamicToolBoxExplore.ViewModel
{
    public class ToolFactory
    {
        public static IEnumerable<ToolViewModel> CreateToolsAccordingTo(string configFilePath)
        {
            var xDoc = XDocument.Load(configFilePath);
            foreach (var e in xDoc.Descendants())
            {
                // if e.Availabel == false , continue;
                var availableAttribute = e.GetAttribute("Available");
                bool available = true;
                bool.TryParse(availableAttribute, out available);
                if(!available) continue;

                // Create ToolViewModel use reflection
                var toolViewModelType = Type.GetType(typeof(ToolFactory).Namespace + "." + e.Name + "ViewModel");
                if(toolViewModelType == null) continue;
                yield return (ToolViewModel)Activator.CreateInstance(toolViewModelType);
            }
        }
    }

    public static class XElementExtension
    {
        public static string GetAttribute(this XElement element, string attributeName)
        {
            var attributes = element.Attributes();
            var attribute = attributes.FirstOrDefault(a => a.Name.LocalName == attributeName);
            return attribute == null ? string.Empty : attribute.Value;
        }
    }
}