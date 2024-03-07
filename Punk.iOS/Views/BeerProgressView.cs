using UIKit;

namespace Punk.iOS.Views
{
    public partial class BeerProgressView : UIView
	{
		public BeerProgressView(string name)
		{
			InitiliazeView(name);
		}

		public void SetProgress(float progress)
		{
			ProgressView.SetProgress(progress, false);
		}
	}
}

