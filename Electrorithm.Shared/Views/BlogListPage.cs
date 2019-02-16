using Windows.UI.Xaml.Navigation;
using AppStudio.Common;
using AppStudio.DataProviders.Rss;
using Electrorithm;
using Electrorithm.Sections;
using Electrorithm.ViewModels;

namespace Electrorithm.Views
{
    public sealed partial class BlogListPage : Electrorithm.PageBase
    {
        public ListViewModel<RssSchema> ViewModel { get; set; }

        public BlogListPage()
        {
            this.ViewModel = new ListViewModel<RssSchema>(new BlogConfig());
            this.InitializeComponent();
        }

        protected async override void LoadState(object navParameter)
        {
            await this.ViewModel.LoadDataAsync();
        }

    }
}
