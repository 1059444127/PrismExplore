using System;
using System.Collections.Generic;

namespace DynamicToolBoxExplore.ViewModel
{
    public class ToolFactory
    {
        public static IEnumerable<ToolViewModel> CreateToolsAccordingTo(string configFilePath)
        {
            //TODO: parse configFilePath, create ToolViewModels  using reflection
            throw new NotImplementedException();
        }
    }
}