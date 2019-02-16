using System;
using AppStudio.Common;
using Windows.ApplicationModel;

namespace Electrorithm.ViewModels
{
    public class AboutThisAppViewModel : ObservableBase
    {
        public string Publisher
        {
            get
            {
                return "AppStudio";
            }
        }

        public string AppVersion
        {
            get
            {
                return string.Format("{0}.{1}.{2}.{3}", Package.Current.Id.Version.Major, Package.Current.Id.Version.Minor, Package.Current.Id.Version.Build, Package.Current.Id.Version.Revision);
            }
        }

        public string AboutText
        {
            get
            {
                return "Have you ever wanted an app that would show people all the great products in your" +
    " store or the art you’ve created? Use this template to provide a list of your pr" +
    "oducts, pictures of your art, and a feed to your blog.";
            }
        }
    }
}

