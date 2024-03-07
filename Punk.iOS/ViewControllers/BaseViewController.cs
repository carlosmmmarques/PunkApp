using UIKit;

namespace Punk.iOS.ViewControllers
{
    public abstract class BaseViewController : UIViewController
	{
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            SetupViews();
        }

        private void SetupViews()
        {
            CreateViews();
            AddConstraints();
        }

        protected abstract void CreateViews();

        protected abstract void AddConstraints();
    }
}

