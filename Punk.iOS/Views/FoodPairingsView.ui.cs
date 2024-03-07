using UIKit;
using Cirrious.FluentLayouts.Touch;
using Punk.iOS.Resources;

namespace Punk.iOS.Views
{
	public partial class FoodPairingsView
	{
		protected UILabel TitleLabel { get; private set; }
		protected UIStackView FooPairingsStack { get; private set; }

		private void InitializeViews()
		{
			CreateViews();
			AddConstraints();
		}

		private void CreateViews()
		{
			TitleLabel = new UILabel
			{
				Text = Constants.Text.FOOD_PAIRINGS,
				TextAlignment = UITextAlignment.Left,
				Font = Constants.Fonts.ItalicFont
			};
			Add(TitleLabel);

			FooPairingsStack = new UIStackView
			{
				Axis = UILayoutConstraintAxis.Vertical,
				Distribution = UIStackViewDistribution.FillEqually,
                Spacing = Constants.Margins.MEDIUM
            };
			Add(FooPairingsStack);
        }

		private void AddConstraints()
		{
			this.SubviewsDoNotTranslateAutoresizingMaskIntoConstraints();
			this.AddConstraints(
				TitleLabel.AtTopOf(this),
				TitleLabel.AtLeadingOf(this, Constants.Margins.MEDIUM),
				TitleLabel.AtTrailingOf(this, Constants.Margins.MEDIUM),

                FooPairingsStack.Below(TitleLabel, Constants.Margins.SMALL),
                FooPairingsStack.WithSameLeading(TitleLabel),
                FooPairingsStack.WithSameTrailing(TitleLabel),
                FooPairingsStack.AtBottomOf(this)
            );
		}
	}
}

