using System;
using CafetoteAPP.Models;
namespace CafetoteAPP.ViewModels
{



 
    public class SplashScreenViewModel
    {
        public Models.SplashScreenModel _model { get; set;}

        public SplashScreenViewModel()
        {
			_model = _model ?? new SplashScreenModel();
           
        }
    }
}
