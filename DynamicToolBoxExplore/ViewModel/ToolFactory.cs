using System;
using System.Collections.Generic;
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
                //TODO-Later: ToolFactory.CreateToolsAccordingTo  Remove hard code.
                var toolViewModelType = Type.GetType("DynamicToolBoxExplore.ViewModel." + e.Name + "ViewModel");
                if(toolViewModelType == null) continue;
                yield return (ToolViewModel)Activator.CreateInstance(toolViewModelType);
            }
        }
    }
}