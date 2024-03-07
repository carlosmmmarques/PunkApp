using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Punk.iOS.Models
{
    public class Beer
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public string Tagline { get; set; }
        [JsonProperty("first_brewed")]
        public DateTime? FirstBrewed { get; set; }
        public string Description { get; set; }
        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }
        public double? Abv { get; set; }
        public double? Ibu { get; set; }
        [JsonProperty("target_fg")]
        public double? TargetFg { get; set; }
        [JsonProperty("target_og")]
        public double? TargetOg { get; set; }
        public double? Ebc { get; set; }
        public double? Srm { get; set; }
        public double? Ph { get; set; }
        [JsonProperty("attenuation_level")]
        public double? AttenuationLevel { get; set; }
        public Amount Volume { get; set; }
        [JsonProperty("boil_volume")]
        public Amount BoilVolume { get; set; }
        public Method Method { get; set; }
        public Ingredients Ingredients { get; set; }
        [JsonProperty("food_pairing")]
        public List<string> FoodPairing { get; set; }
        [JsonProperty("brewers_tips")]
        public string BrewersTips { get; set; }
        [JsonProperty("contributed_by")]
        public string ContributedBy { get; set; }
	}
}