using Punk.iOS.Models;
using UIKit;

namespace Punk.iOS.Views
{
    public partial class BeerCard : UIView
	{
		public BeerCard()
		{
			Initialize();
		}

        public void Setup(Beer beer)
		{
			if (beer == null)
				return;

			TaglineLabel.Text = beer.Tagline;
			NameLabel.Text = beer.Name;
			DescriptionLabel.Text = beer.Description;
			ContributorLabel.Text = beer.ContributedBy;
        }
	}
}

