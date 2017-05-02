using System;
using System.ComponentModel.Composition;
using Interfaces;

namespace Exporters
{
    [Export(typeof(IModel))]
    public class Model : IModel
    {
        public Model()
        {
            Console.WriteLine("Model Constructed");
        }

        #region Implementation of IModel

        public void Act()
        {
            Console.WriteLine("Model Acted");
        }

        #endregion
    }
}