using UIKit;

namespace Punk.iOS.Views
{
    public partial class FoodPairingItem : UIView
	{
		public FoodPairingItem(string foodPairingtext)
		{
			InitializeViews();
            Label.Text = foodPairingtext;
        }
	}
}

