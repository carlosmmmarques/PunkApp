using UIKit;
using Cirrious.FluentLayouts.Touch;
using Punk.iOS.TableView.Sources;
using Punk.iOS.TableView.Delegates;
using Punk.iOS.Resources;
using Punk.iOS.Views;

namespace Punk.iOS.ViewControllers
{
    partial class MainViewController
    {
        protected UIView SearchContainer { get; private set; }
        protected UILabel TitleLabel { get; private set; }
        protected UITextField SearchTextField { get; private set; }
        protected UIButton SearchButton { get; private set; }

        protected LoadingView LoadingView { get; private set; }

        protected UITableView BeerTableView { get; private set; }

        protected override void CreateViews()
        {
            View.BackgroundColor = UIColor.SystemBackground;

            SearchContainer = new UIView
            {
                BackgroundColor = Constants.Colors.BEER
            };
            SearchContainer.Layer.BorderColor = UIColor.Black.CGColor;
            SearchContainer.Layer.BorderWidth = 1;
            Add(SearchContainer);

            TitleLabel = new UILabel
            {
                Font = Constants.Fonts.APP_TITLE_FONT,
                Text = Constants.Text.APP_TITLE,
                TextColor = Constants.Colors.TEXT_BROWN
            };
            SearchContainer.Add(TitleLabel);

            SearchTextField = new UITextField
            {
                Placeholder = Constants.Text.SEARCH_PLACEHOLDER,
                TintColor = UIColor.Black
            };
            SearchContainer.Add(SearchTextField);

            SearchButton = new UIButton();
            SearchButton.SetTitle(Constants.Text.SEARCH_BUTTON, UIControlState.Normal);
            SearchButton.SetTitleColor(Constants.Colors.TEXT_BROWN, UIControlState.Normal);
            SearchButton.SetTitleColor(UIColor.DarkGray, UIControlState.Highlighted);
            SearchContainer.Layer.ShadowOpacity = .5f;
            SearchContainer.Add(SearchButton);

            LoadingView = new LoadingView();
            SearchContainer.Add(LoadingView);

            _dataSource = new BeerTableViewSource(_viewModel.BeerList, NavigateToBeerDetail);
            _delegate = new BeerTableViewDelegate();

            BeerTableView = new UITableView
            {
                DataSource = _dataSource,
                Delegate = _delegate,
                EstimatedRowHeight = 300,
                AllowsSelection = false,
                BackgroundColor = UIColor.Clear,
                SeparatorStyle = UITableViewCellSeparatorStyle.None,
                ContentInset = new UIEdgeInsets(20, 0, 0, 0)
            };
            Add(BeerTableView);
        }

        protected override void AddConstraints()
        {
            View.SubviewsDoNotTranslateAutoresizingMaskIntoConstraints();
            View.AddConstraints(
                SearchContainer.AtTopOf(View),
                SearchContainer.AtLeadingOf(View),
                SearchContainer.AtTrailingOf(View),

                BeerTableView.Below(SearchContainer),
                BeerTableView.AtLeadingOf(View),
                BeerTableView.AtTrailingOf(View),
                BeerTableView.AtBottomOf(View)
            );

            SearchContainer.SubviewsDoNotTranslateAutoresizingMaskIntoConstraints();
            SearchContainer.AddConstraints(
                TitleLabel.AtTopOf(SearchContainer, 100),
                TitleLabel.AtLeadingOf(SearchContainer, Constants.Margins.MEDIUM),
                TitleLabel.AtTrailingOf(SearchContainer, Constants.Margins.MEDIUM),

                SearchTextField.Below(TitleLabel, Constants.Margins.MEDIUM),
                SearchTextField.AtLeadingOf(SearchContainer, Constants.Margins.MEDIUM),
                SearchTextField.AtBottomOf(SearchContainer, Constants.Margins.MEDIUM),
                SearchTextField.Trailing().EqualTo().LeadingOf(SearchButton).Minus(Constants.Margins.SMALL),

                SearchButton.WithSameCenterY(SearchTextField),
                SearchButton.AtTrailingOf(SearchContainer, Constants.Margins.MEDIUM),

                LoadingView.AtLeadingOf(SearchContainer),
                LoadingView.AtTrailingOf(SearchContainer),
                LoadingView.AtBottomOf(SearchContainer)
            );
        }
    }
}
