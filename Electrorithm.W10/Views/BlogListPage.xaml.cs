using Windows.UI.Xaml.Navigation;
using AppStudio.Common;
using AppStudio.DataProviders.Rss;
using Electrorithm;
using Electrorithm.Sections;
using Electrorithm.ViewModels;

namespace Electrorithm.Views
{
    public sealed partial class BlogListPage : PageBase
    {
        public BlogListPage()
        {
            this.ViewModel = new ListViewModel<RssSchema>(new BlogConfig());
            this.InitializeComponent();
        }

        public ListViewModel<RssSchema> ViewModel { get; set; }

        protected async override void LoadState(object navParameter)
        {
            await this.ViewModel.LoadDataAsync();
        }

    }
}
