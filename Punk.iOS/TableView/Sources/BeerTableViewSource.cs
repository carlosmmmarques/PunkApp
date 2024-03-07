using System;
using System.Collections.Generic;
using Foundation;
using Punk.iOS.Models;
using Punk.iOS.TableView.Cells;
using UIKit;

namespace Punk.iOS.TableView.Sources
{
	public class BeerTableViewSource : UITableViewDataSource
	{
        private readonly List<Beer> _beerList;
        private readonly Action<Beer> _beerCardTappedAction;

        public BeerTableViewSource(List<Beer> beerList, Action<Beer> beerCardTappedAction)
        {
            _beerList = beerList;
            _beerCardTappedAction = beerCardTappedAction;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = (BeerTableViewCell) tableView.DequeueReusableCell(nameof(BeerTableViewCell));

            if (cell == null)
                cell = new BeerTableViewCell();

            var beer = _beerList[indexPath.Row];

            cell.Setup(beer, () => _beerCardTappedAction(beer));

            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return _beerList == null ? 0 : _beerList.Count;
        }
    }
}

