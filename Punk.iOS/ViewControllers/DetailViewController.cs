using FFImageLoading;
using PunkApp.Extensions;
using Punk.iOS.Models;
using Punk.iOS.Views;

namespace Punk.iOS.ViewControllers
{
    public partial class DetailViewController : BaseViewController
    {
        private readonly Beer _beer;

		public DetailViewController(Beer beer)
		{
            _beer = beer;
		}

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            Setup();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            ImageService.Instance.InvalidateMemoryCache();
        }

        private void Setup()
        {
            if (_beer != null)
            {
                NameLabel.Text = _beer.Name;
                DescriptionLabel.Text = _beer.Description;
                TaglineLabel.Text = _beer.Tagline;
                FoodPairingsView.Setup(_beer.FoodPairing);
                TipLabel.Text = _beer.BrewersTips;
                ImageService.Instance.LoadUrl(_beer.ImageUrl).Into(BeerImageView);
                AbvProgressView.SetProgress(_beer.Abv.ConvertFromAbv());
                IbuProgressView.SetProgress(_beer.Ibu.ConvertFromIbu());
                PhProgressView.SetProgress(_beer.Ph.ConvertFromPh());
                ColorProgressView.SetProgress(_beer.Srm.ConvertFromSrm());
            }
        }
    }
}

