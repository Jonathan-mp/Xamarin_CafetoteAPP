using System;
using CafetoteAPP.Models;
namespace CafetoteAPP.ViewModels
{


public Models.SplashScreenModel _model { get; set;}
 
    public class SplashScreenViewModel
    {
        public SplashScreenViewModel()
        {
			_model ?? new SplashScreenModel();
           
        }
    }
}
