using Electrorithm.ViewModels;

namespace Electrorithm.Views
{
    public sealed partial class AboutPage : PageBase
    {
        public AboutPage()
        {
            AboutThisAppModel = new AboutThisAppViewModel();
            this.InitializeComponent();
        }

        public AboutThisAppViewModel AboutThisAppModel { get; private set; }

        protected async override void LoadState(object navParameter)
        {
        }
    }
}
