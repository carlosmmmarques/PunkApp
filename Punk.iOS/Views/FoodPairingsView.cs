using System.Collections.Generic;
using UIKit;

namespace Punk.iOS.Views
{
    public partial class FoodPairingsView : UIView
	{
		public FoodPairingsView()
		{
			InitializeViews();
		}

		public void Setup(List<string> foodPairings)
		{
			foreach (var pairing in foodPairings)
                FooPairingsStack.AddArrangedSubview(new FoodPairingItem(pairing));
		}
	}
}

