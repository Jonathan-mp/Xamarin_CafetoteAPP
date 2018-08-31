using CafetoteAPP.Models;
using System.Timers;
using Xamarin.Forms;
using CafetoteAPP.Views;

namespace CafetoteAPP.ViewModels
{
    
    public class SplashScreenViewModel
    {
        public SplashScreenModel _model { get; set;}
        public Timer _timer { get; set; }
    
        public SplashScreenViewModel()
        {
            
			_model = _model ?? new SplashScreenModel();

         
            _model.OpacityLogo = 0f;

            _timer = _timer ?? new Timer();
            _timer.Interval = 2f;
            _timer.Start();

            _timer.Elapsed += (s, e) => {

                if (_model.OpacityLogo <= 1)
                    _model.OpacityLogo += 0.0010f;
                else
                {
                    _timer.Stop();
                    _timer.Dispose();
                    Device.BeginInvokeOnMainThread(() =>
                    {
                        Application.Current.MainPage = new NavigationPage(new HomePage());
                    });


                }
            
            };

           



        }
    }
}
