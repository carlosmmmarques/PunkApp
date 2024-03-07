using Cirrious.FluentLayouts.Touch;
using Punk.iOS.Resources;
using Punk.iOS.Views;
using UIKit;

namespace Punk.iOS.TableView.Cells
{
    public partial class BeerTableViewCell
	{
		protected BeerCard beerCard;

        private void InitializeViews()
		{
			CreateViews();
			AddConstraints();
		}

		private void CreateViews()
		{
			BackgroundColor = UIColor.Clear;

			beerCard = new BeerCard();
			ContentView.Add(beerCard);
        }

		private void AddConstraints()
		{
			ContentView.SubviewsDoNotTranslateAutoresizingMaskIntoConstraints();
			ContentView.AddConstraints(
                beerCard.AtTopOf(ContentView, Constants.Margins.EXTRA_SMALL),
                beerCard.AtLeadingOf(ContentView, Constants.Margins.SMALL),
                beerCard.AtTrailingOf(ContentView, Constants.Margins.SMALL),
                beerCard.AtBottomOf(ContentView, Constants.Margins.EXTRA_SMALL)
            );
		}
	}
}

