using System.Collections.Generic;
using Newtonsoft.Json;

namespace Punk.iOS.Models
{
	public class Method
	{
        [JsonProperty("mash_temp")]
        public List<MashTemp> MashTemp { get; set; }
        public Fermentation Fermentation { get; set; }
    }
}

