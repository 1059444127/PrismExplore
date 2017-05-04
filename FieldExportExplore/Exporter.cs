using System.ComponentModel.Composition;

namespace FieldExportExplore
{
    public class Exporter
    {
        [Export("SelfInitialized")] private string _s1 = "SelfInitialized";
        [Export("ConstructorInitialized")] private string _s2;

        public Exporter()
        {
            _s2 = "ConstructorInitialized";
        }
    }
}