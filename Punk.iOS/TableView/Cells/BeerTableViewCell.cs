using System;
using Punk.iOS.Models;
using UIKit;

namespace Punk.iOS.TableView.Cells
{
	public partial class BeerTableViewCell : UITableViewCell
	{
		//TODO inherit from base view cell
		private UITapGestureRecognizer _tapGestureRecognizer;

		public BeerTableViewCell(IntPtr handle) : base(handle)
		{
			InitializeViews();
		}

		public BeerTableViewCell()
		{
            InitializeViews();
        }

        public void Setup(Beer beer, Action cardTapped)
		{
			beerCard.Setup(beer);

			_tapGestureRecognizer = new UITapGestureRecognizer(cardTapped);
			beerCard.AddGestureRecognizer(_tapGestureRecognizer); //TODO remove gesture rg
        }
	}
}

