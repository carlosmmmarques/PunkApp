using UIKit;
using Cirrious.FluentLayouts.Touch;
using Punk.iOS.Resources;

namespace Punk.iOS.Views
{
    public partial class BeerCard
	{
		protected UIView TaglineContainer { get; private set; }
		protected UILabel TaglineLabel { get; private set; }
		protected UILabel NameLabel { get; private set; }
		protected UILabel DescriptionLabel { get; private set; }
		protected UILabel ContributorLabel { get; private set; }


		private void Initialize()
		{
			CreateViews();
			AddConstraints();
		}

		private void CreateViews()
		{
            ClipsToBounds = true;
            BackgroundColor = Constants.Colors.BEER;
            Layer.CornerRadius = Constants.Radius.CARD_CORNER;
            Layer.BorderColor = UIColor.Black.CGColor;
            Layer.BorderWidth = .5f;

			TaglineContainer = new UIView
			{
				BackgroundColor = UIColor.White
			};
			Add(TaglineContainer);

			TaglineLabel = new UILabel
			{
				TextAlignment = UITextAlignment.Center,
				Font = Constants.Fonts.ItalicFont
			};
			TaglineContainer.Add(TaglineLabel);

			NameLabel = new UILabel
			{
                TextAlignment = UITextAlignment.Center,
                Font = Constants.Fonts.TitleFont,
				Lines = 0,
				LineBreakMode = UILineBreakMode.WordWrap
            };
			Add(NameLabel);

			DescriptionLabel = new UILabel
			{
                TextAlignment = UITextAlignment.Center,
                Font = Constants.Fonts.ContentFont,
				Lines = 4,
				LineBreakMode = UILineBreakMode.TailTruncation
            };
			Add(DescriptionLabel);

			ContributorLabel = new UILabel
			{
				TextAlignment = UITextAlignment.Right,
                Font = Constants.Fonts.SmallTextFont
            };
			Add(ContributorLabel);
        }

		private void AddConstraints()
		{
			TaglineContainer.SubviewsDoNotTranslateAutoresizingMaskIntoConstraints();
			TaglineContainer.AddConstraints(
				TaglineLabel.AtTopOf(TaglineContainer, Constants.Margins.SMALL),
				TaglineLabel.AtBottomOf(TaglineContainer, Constants.Margins.SMALL),
				TaglineLabel.AtLeadingOf(TaglineContainer, Constants.Margins.SMALL),
				TaglineLabel.AtTrailingOf(TaglineContainer, Constants.Margins.SMALL)
            );

			this.SubviewsDoNotTranslateAutoresizingMaskIntoConstraints();
			this.AddConstraints(
                TaglineContainer.AtTopOf(this),
				TaglineContainer.AtLeadingOf(this),
				TaglineContainer.AtTrailingOf(this),

				NameLabel.Below(TaglineContainer, Constants.Margins.BIG),
				NameLabel.AtLeadingOf(this, Constants.Margins.SMALL),
				NameLabel.AtTrailingOf(this, Constants.Margins.SMALL),

				DescriptionLabel.Below(NameLabel, Constants.Margins.SMALL),
				DescriptionLabel.WithSameLeading(NameLabel),
				DescriptionLabel.WithSameTrailing(NameLabel),

                ContributorLabel.Below(DescriptionLabel, Constants.Margins.MEDIUM),
                ContributorLabel.WithSameLeading(NameLabel),
				ContributorLabel.WithSameTrailing(NameLabel),
                ContributorLabel.AtBottomOf(this, Constants.Margins.MEDIUM)
            );
		}
    }
}

