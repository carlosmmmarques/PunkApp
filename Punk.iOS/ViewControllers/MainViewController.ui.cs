using UIKit;
using Cirrious.FluentLayouts.Touch;
using Punk.iOS.TableView.Sources;
using Punk.iOS.TableView.Delegates;

namespace Punk.iOS.ViewControllers
{
    partial class MainViewController
    {
        protected UITableView BeerTableView { get; private set; }

        protected override void CreateViews()
        {
            View.BackgroundColor = UIColor.SystemBackground;

            _dataSource = new BeerTableViewSource(_viewModel.BeerList, NavigateToBeerDetail);
            _delegate = new BeerTableViewDelegate();

            BeerTableView = new UITableView
            {
                DataSource = _dataSource,
                Delegate = _delegate,
                EstimatedRowHeight = 300,
                AllowsSelection = false,
                BackgroundColor = UIColor.Clear,
                SeparatorStyle = UITableViewCellSeparatorStyle.None
            };
            Add(BeerTableView);
        }

        protected override void AddConstraints()
        {
            View.SubviewsDoNotTranslateAutoresizingMaskIntoConstraints();
            View.AddConstraints(
                BeerTableView.AtTopOfSafeArea(View),
                BeerTableView.AtLeadingOf(View),
                BeerTableView.AtTrailingOf(View),
                BeerTableView.AtBottomOf(View)
            );
        }
    }
}
