using UIKit;
using Cirrious.FluentLayouts.Touch;
using Punk.iOS.Resources;

namespace Punk.iOS.Views
{
	public partial class FoodPairingItem
	{
		protected UILabel Label { get; private set; }
		protected UIView UnderLine { get; private set; }

		private void InitializeViews()
		{
			CreateViews();
			AddConstraints();
		}

		private void CreateViews()
		{
			Label = new UILabel
			{
				Font = Constants.Fonts.CONTENT
			};
			Add(Label);

			UnderLine = new UIView
			{
				BackgroundColor = UIColor.SystemGray4
			};
			Add(UnderLine);
        }

		private void AddConstraints()
		{
			this.SubviewsDoNotTranslateAutoresizingMaskIntoConstraints();
			this.AddConstraints(
				Label.AtTopOf(this),
				Label.AtLeadingOf(this),
				Label.AtTrailingOf(this),

				UnderLine.Below(Label),
                UnderLine.AtLeadingOf(this),
				UnderLine.AtTrailingOf(this),
				UnderLine.AtBottomOf(this),
                UnderLine.Height().EqualTo(1)
            );
		}
	}
}

