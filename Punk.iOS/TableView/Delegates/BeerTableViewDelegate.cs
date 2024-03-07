using System;
using UIKit;

namespace Punk.iOS.TableView.Delegates
{
    public class BeerTableViewDelegate : UITableViewDelegate
	{
        public Action LoadMoreBeersAction;

        public override void Scrolled(UIScrollView scrollView)
        {
            var scrollViewHeight = scrollView.Frame.Size.Height;
            var scrollContentSizeHeight = scrollView.ContentSize.Height;
            var scrollOffset = scrollView.ContentOffset.Y;
            var loadOffset = 500;

            if (scrollOffset + scrollViewHeight >= scrollContentSizeHeight - loadOffset) {
                LoadMoreBeersAction?.Invoke();
            }
        }
    }
}

