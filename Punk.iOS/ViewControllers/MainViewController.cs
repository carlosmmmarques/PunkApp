using System;
using FFImageLoading;
using Punk.iOS.Models;
using Punk.iOS.TableView.Cells;
using Punk.iOS.TableView.Delegates;
using Punk.iOS.TableView.Sources;
using Punk.iOS.ViewModels;
using UIKit;

namespace Punk.iOS.ViewControllers
{
    public partial class MainViewController : BaseViewController, IUIScrollViewDelegate
    {
        private readonly MainViewModel _viewModel = new MainViewModel();

        private BeerTableViewSource _dataSource;
        private BeerTableViewDelegate _delegate;

        public override void ViewDidLoad()
        {
            //TODO add loading
            base.ViewDidLoad();

            BeerTableView.RegisterClassForCellReuse(typeof(BeerTableViewCell), nameof(BeerTableViewCell));

            _viewModel.ReloadBeerList = () => InvokeOnMainThread(BeerTableView.ReloadData);
            _delegate.LoadMoreBeersAction = async () => await _viewModel.LoadDataAsync();
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            SearchButton.TouchUpInside += SearchButton_TouchUpInside;
        }

        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);

            SearchButton.TouchUpInside -= SearchButton_TouchUpInside;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            ImageService.Instance.InvalidateMemoryCache();
        }

        private void NavigateToBeerDetail(Beer beer)
        {
            NavigationController.PushViewController(new DetailViewController(beer), true);
        }

        private async void SearchButton_TouchUpInside(object sender, EventArgs e)
        {
            await _viewModel.SearchBeer(SearchTextField.Text);
        }
    }
}
