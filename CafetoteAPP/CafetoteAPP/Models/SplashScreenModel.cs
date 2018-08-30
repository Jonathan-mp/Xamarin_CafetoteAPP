
using Foundation;

namespace CafetoteAPP.Models
{
    public class SplashScreenModel : Observable
    {
       
        string _version;
        public string Version
        {
            get
            {

                return NSBundle.MainBundle.InfoDictionary["CFBundleVersion"].ToString();
            }
            set
            {
                _version = value;
                NotifyPropertyChanged();
            }
        }

    }
}
