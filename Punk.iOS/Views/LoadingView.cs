using CoreGraphics;
using UIKit;

namespace Punk.iOS.Views
{
    public partial class LoadingView : UIView
	{
		public LoadingView()
		{
			InitializeViews();
		}

		public void SetLoading(bool loading)
		{
			if (loading)
				StartLoading();
			else
				StopLoading();
		}

		private void StartLoading()
		{
			InvokeOnMainThread(() => {
				Alpha = 1;

				Animate(.4f, 0, UIViewAnimationOptions.Repeat | UIViewAnimationOptions.Autoreverse,
					() => {
						BarView.Frame = new CGRect(Frame.Width - BarView.Frame.Width, BarView.Frame.Y, BarView.Frame.Width, BarView.Frame.Height);
                    },
					null);
			});
		}

		private void StopLoading()
		{
            InvokeOnMainThread(() => {
				Layer.RemoveAllAnimations();
				Alpha = 0;
            });
        }
	}
}

