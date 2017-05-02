using System;
using System.ComponentModel.Composition;
using Interfaces;

namespace Importers
{
    public class ViewModel
    {
        [Import] private IModel _model; 

        public ViewModel()
        {
            Console.WriteLine("ViewModel Constructed");
            _model.Act();
        } 
    }
}