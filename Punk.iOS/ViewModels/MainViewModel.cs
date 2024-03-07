﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Punk.iOS.Managers;
using Punk.iOS.Models;

namespace Punk.iOS.ViewModels
{
	public class MainViewModel
	{
		public List<Beer> BeerList { get; private set; }

		public Action ReloadBeerList;

		private int currentPage = 1;
		private bool canReload = true;


		public MainViewModel()
		{
			BeerList = new List<Beer>();
		}

		public async Task LoadDataAsync()
		{
			if (canReload)
			{
                canReload = false;
                List<Beer> newBeers = await DataManager.Instance.GetBeerListAsync(currentPage++);
                BeerList.AddRange(newBeers);
                ReloadBeerList?.Invoke();
                canReload = true;
            }
        }
	}
}
