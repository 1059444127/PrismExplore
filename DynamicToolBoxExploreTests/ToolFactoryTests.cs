using System.Linq;
using DynamicToolBoxExplore.ViewModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynamicToolBoxExploreTests
{
    [TestClass]
    public class ToolFactoryTests
    {
        [TestMethod]
        public void Tools_Count_is_Not_0_Create_by_ToolFactory_According_to_Correct_Config_File()
        {
            // Act & Arrange
            var expectedToolCount = ToolFactory.CreateToolsAccordingTo(@"c:\config\DynamicToolBox.xml").Count();

            // Assert
            Assert.AreNotEqual(0, expectedToolCount);
        }
    }
}
