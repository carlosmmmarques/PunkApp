using UIKit;

namespace Punk.iOS.Resources
{
    public static class Constants
	{
		public static class Margins
		{
            public static readonly int EXTRA_SMALL = 8;
            public static readonly int SMALL = 16;
            public static readonly int MEDIUM = 20;
            public static readonly int BIG = 24;
            public static readonly int EXTRA_BIG = 40;
        }

        public static class Radius
		{
			public static readonly int CARD_CORNER = 12;
		}

		public static class Colors
		{
			public static readonly UIColor BEER = new UIColor(0.96f, 0.76f, 0f, 1.00f);
            public static readonly UIColor DARK_BEER = new UIColor(0.93f, 0.62f, 0.00f, 1.00f);
        }

        public static class Fonts
        {
            public static readonly UIFont APP_TITLE_FONT = UIFont.BoldSystemFontOfSize(34);
            public static readonly UIFont TITLE = UIFont.BoldSystemFontOfSize(26);
            public static readonly UIFont ITALIC = UIFont.ItalicSystemFontOfSize(14);
            public static readonly UIFont SMALL_ITALIC = UIFont.ItalicSystemFontOfSize(12);
            public static readonly UIFont CONTENT = UIFont.SystemFontOfSize(14);
            public static readonly UIFont SMALL = UIFont.SystemFontOfSize(10);
        }

        public static class Text
        {
            public static readonly string ALCOHOL = "Alcohol";
            public static readonly string BITTERNESS = "Bitterness";
            public static readonly string ACIDITY = "Acidity";
            public static readonly string COLOR = "Color";
            public static readonly string FOOD_PAIRINGS = "Food Pairings";

            public static readonly string SEARCH_PLACEHOLDER = "Search for a beer...";
            public static readonly string SEARCH_BUTTON = "Search";
            public static readonly string APP_TITLE = "Beer App";

        }
    }
}

