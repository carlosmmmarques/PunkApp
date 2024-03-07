using UIKit;
using Punk.iOS.Resources;

namespace Punk.iOS.Views
{
    public partial class LoadingView
	{
		protected UIView BarView { get; private set; }

		private void InitializeViews()
		{
			Alpha = 0;

			BarView = new UIView(new CoreGraphics.CGRect(0, 0, 200, 3))
			{
				BackgroundColor = Constants.Colors.DARK_BEER
			};
			Add(BarView);
        }
	}
}

