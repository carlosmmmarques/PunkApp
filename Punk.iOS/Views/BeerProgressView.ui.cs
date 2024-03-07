using Cirrious.FluentLayouts.Touch;
using Punk.iOS.Resources;
using UIKit;

namespace Punk.iOS.Views
{
    public partial class BeerProgressView
	{
		protected UILabel NameLabel { get; private set; }
		protected UIProgressView ProgressView { get; private set; }

		private void InitiliazeView(string name)
		{
			CreateViews(name);
			AddConstraints();
        }

		private void CreateViews(string name)
        {
			NameLabel = new UILabel
			{
                Text = name,
                Font = Constants.Fonts.SMALL_ITALIC
            };
			Add(NameLabel);

			ProgressView = new UIProgressView
			{
                ProgressTintColor = Constants.Colors.BEER,
                BackgroundColor = UIColor.SystemGray6
            };
			Add(ProgressView);
		}

		private void AddConstraints()
		{
			this.SubviewsDoNotTranslateAutoresizingMaskIntoConstraints();
			this.AddConstraints(
				NameLabel.AtTopOf(this),
				NameLabel.WithSameLeading(this),
				NameLabel.WithSameTrailing(this),

				ProgressView.Below(NameLabel, Constants.Margins.EXTRA_SMALL),
				ProgressView.WithSameLeading(this),
				ProgressView.WithSameTrailing(this),
				ProgressView.AtBottomOf(this)
			);
		}
	}
}

