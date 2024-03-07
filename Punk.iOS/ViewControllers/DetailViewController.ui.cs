using Cirrious.FluentLayouts.Touch;
using Punk.iOS.Resources;
using Punk.iOS.Views;
using UIKit;

namespace Punk.iOS.ViewControllers
{
    public partial class DetailViewController
	{
        protected UIScrollView ScrollView { get; private set; }
        protected UIView ScrollContainer { get; private set; }
        protected UILabel NameLabel { get; private set; }
        protected UILabel TaglineLabel { get; private set; }
        protected UILabel DescriptionLabel { get; private set; }

        protected FoodPairingsView FoodPairingsView { get; private set; }

        protected UILabel TipLabel { get; private set; }

        protected UIView ImagegeContainer { get; private set; }
        protected UIImageView BeerImageView { get; private set; }

        protected UIStackView ProgessStackView { get; private set; }
        protected BeerProgressView AbvProgressView { get; private set; }
        protected BeerProgressView IbuProgressView { get; private set; }
        protected BeerProgressView PhProgressView { get; private set; }
        protected BeerProgressView ColorProgressView { get; private set; }


        protected override void CreateViews()
        {
            NavigationController.NavigationBar.TintColor = Constants.Colors.DARK_BEER;
            View.BackgroundColor = UIColor.SystemBackground;

            ScrollView = new UIScrollView();
            Add(ScrollView);

            ScrollContainer = new UIView();
            ScrollView.Add(ScrollContainer);

            NameLabel = new UILabel
            {
                Font = Constants.Fonts.TitleFont,
                TextAlignment = UITextAlignment.Center,
                LineBreakMode = UILineBreakMode.WordWrap,
                Lines = 0
            };
            ScrollContainer.Add(NameLabel);

            TaglineLabel = new UILabel
            {
                Font = Constants.Fonts.ItalicFont,
                TextAlignment = UITextAlignment.Center,
                LineBreakMode = UILineBreakMode.WordWrap,
                Lines = 0
            };
            ScrollContainer.Add(TaglineLabel);

            DescriptionLabel = new UILabel
            {
                Font = Constants.Fonts.ContentFont,
                TextAlignment = UITextAlignment.Center,
                LineBreakMode = UILineBreakMode.WordWrap,
                Lines = 0
            };
            ScrollContainer.Add(DescriptionLabel);

            FoodPairingsView = new FoodPairingsView();
            ScrollContainer.Add(FoodPairingsView);

            TipLabel = new UILabel
            {
                Font = Constants.Fonts.ItalicFont,
                TextAlignment = UITextAlignment.Center,
                Lines = 0,
                LineBreakMode = UILineBreakMode.WordWrap
            };
            ScrollContainer.Add(TipLabel);

            ImagegeContainer = new UIView
            {
                BackgroundColor = UIColor.SystemGray6,
                ClipsToBounds = true
            };
            ImagegeContainer.Layer.BorderWidth = 1;
            ImagegeContainer.Layer.BorderColor = UIColor.Gray.CGColor;
            ScrollContainer.Add(ImagegeContainer);

            BeerImageView = new UIImageView
            {
                ContentMode = UIViewContentMode.ScaleAspectFit
            };
            ImagegeContainer.Add(BeerImageView);

            ProgessStackView = new UIStackView
            {
                Distribution = UIStackViewDistribution.FillEqually,
                Axis = UILayoutConstraintAxis.Vertical,
                Spacing = Constants.Margins.MEDIUM
            };
            ImagegeContainer.Add(ProgessStackView);

            AbvProgressView = new BeerProgressView(Constants.Text.ALCOHOL);
            ProgessStackView.AddArrangedSubview(AbvProgressView);

            IbuProgressView = new BeerProgressView(Constants.Text.BITTERNESS);
            ProgessStackView.AddArrangedSubview(IbuProgressView);

            PhProgressView = new BeerProgressView(Constants.Text.ACIDITY);
            ProgessStackView.AddArrangedSubview(PhProgressView);

            ColorProgressView = new BeerProgressView(Constants.Text.COLOR);
            ProgessStackView.AddArrangedSubview(ColorProgressView);
        }

        protected override void AddConstraints()
        {
            View.SubviewsDoNotTranslateAutoresizingMaskIntoConstraints();
            View.AddConstraints(
                ScrollView.AtTopOfSafeArea(View),
                ScrollView.AtLeadingOf(View),
                ScrollView.AtTrailingOf(View),
                ScrollView.AtBottomOf(View, Constants.Margins.BIG)
            );

            ScrollView.SubviewsDoNotTranslateAutoresizingMaskIntoConstraints();
            ScrollView.AddConstraints(
                ScrollContainer.AtTopOf(ScrollView),
                ScrollContainer.AtBottomOf(ScrollView),
                ScrollContainer.AtLeadingOf(ScrollView),
                ScrollContainer.AtTrailingOf(ScrollView),
                ScrollContainer.WithSameWidth(ScrollView)
            );

            ScrollContainer.SubviewsDoNotTranslateAutoresizingMaskIntoConstraints();
            ScrollContainer.AddConstraints(
                NameLabel.AtTopOfSafeArea(ScrollContainer, Constants.Margins.EXTRA_BIG),
                NameLabel.AtLeadingOf(ScrollContainer, Constants.Margins.MEDIUM),
                NameLabel.AtTrailingOf(ScrollContainer, Constants.Margins.MEDIUM),

                TaglineLabel.Below(NameLabel, Constants.Margins.EXTRA_BIG),
                TaglineLabel.WithSameLeading(NameLabel),
                TaglineLabel.WithSameTrailing(NameLabel),

                DescriptionLabel.Below(TaglineLabel, Constants.Margins.BIG),
                DescriptionLabel.WithSameLeading(NameLabel),
                DescriptionLabel.WithSameTrailing(NameLabel),

                FoodPairingsView.Below(DescriptionLabel, Constants.Margins.BIG),
                FoodPairingsView.AtLeadingOf(ScrollContainer),
                FoodPairingsView.AtTrailingOf(ScrollContainer),

                TipLabel.Below(FoodPairingsView, Constants.Margins.BIG),
                TipLabel.WithSameLeading(NameLabel),
                TipLabel.WithSameTrailing(NameLabel),

                ImagegeContainer.Below(TipLabel, Constants.Margins.BIG),
                ImagegeContainer.WithSameLeading(ScrollContainer),
                ImagegeContainer.WithSameTrailing(ScrollContainer),
                ImagegeContainer.AtBottomOf(ScrollContainer)
            );

            ImagegeContainer.SubviewsDoNotTranslateAutoresizingMaskIntoConstraints();
            ImagegeContainer.AddConstraints(
                ProgessStackView.Top().GreaterThanOrEqualTo().TopOf(ImagegeContainer).Plus(Constants.Margins.MEDIUM),
                ProgessStackView.Bottom().LessThanOrEqualTo().BottomOf(ImagegeContainer).Minus(Constants.Margins.MEDIUM),
                ProgessStackView.WithSameCenterY(ImagegeContainer),
                ProgessStackView.AtLeadingOf(ImagegeContainer, Constants.Margins.MEDIUM),
                ProgessStackView.Width().EqualTo().WidthOf(ImagegeContainer).WithMultiplier(.4f),

                BeerImageView.AtTopOf(ImagegeContainer, Constants.Margins.MEDIUM),
                BeerImageView.AtBottomOf(ImagegeContainer, Constants.Margins.MEDIUM),
                BeerImageView.AtTrailingOf(ImagegeContainer, Constants.Margins.MEDIUM),
                BeerImageView.WithSameWidth(ProgessStackView)
            );
        }
    }
}

