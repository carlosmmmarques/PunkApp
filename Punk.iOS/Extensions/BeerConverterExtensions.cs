namespace PunkApp.Extensions
{
    public static class BeerConverterExtensions
	{
		public static float ConvertFromAbv(this double? abv)
		{
            if (abv.HasValue)
            {
                if (abv <= 0)
                    return 0;

                if (abv >= 10)
                    return 1;

                return (float)abv.Value / 10f;
            }
            else
            {
                return 0;
            }
        }

        public static float ConvertFromIbu(this double? ibu)
        {
            if (ibu.HasValue)
            {
                if (ibu <= 0)
                    return 0;

                if (ibu >= 100)
                    return 1;

                return (float)ibu.Value / 100f;
            }
            else
            {
                return 0;
            }
        }

        public static float ConvertFromPh(this double? ph)
        {
            if (ph.HasValue)
            {
                var maxPh = 14;

                if (ph <= 0)
                    return 1;

                if (ph >= maxPh)
                    return 0;

                return 1 - ((float)ph.Value / maxPh);
            }
            else
            {
                return 0;
            }
        }

        public static float ConvertFromSrm(this double? srm)
        {
            if (srm.HasValue)
            {
                var maxSrm = 40;

                if (srm <= 0)
                    return 0;

                if (srm >= maxSrm)
                    return 1;

                return (float)srm.Value / maxSrm;
            }
            else
            {
                return 0;
            }
        }
    }
}

