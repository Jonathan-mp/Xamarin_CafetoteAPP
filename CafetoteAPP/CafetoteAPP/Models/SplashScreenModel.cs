
using Foundation;
using Xamarin.Forms;

namespace CafetoteAPP.Models
{
    public class SplashScreenModel : Observable
    {
       

        public SplashScreenModel()
        {

        }


        string _version;
        public string Version
        {
            get
            {
   
				return string.Format("Version {0}", NSBundle.MainBundle.InfoDictionary["CFBundleVersion"].ToString());
            }
            set
            {
                _version = value;
                NotifyPropertyChanged();
            }
        }


        private float _opacityLogo;
        public float OpacityLogo
        {
          get
          {
            return _opacityLogo;
          }
          set
          {
            _opacityLogo = value;
			NotifyPropertyChanged();
          }
        }
    }
}
