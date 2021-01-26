using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TriviaFrontend.Models
{
    public class AllCategories
    {
        [JsonProperty("trivia_categories")]
        public List<TriviaCategories> triviaCategory { get; set; }
    }
}
