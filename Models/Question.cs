using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TriviaFrontend.Models
{
    public class Question
    {
        [JsonProperty("category")]
        public string Category { get; set; }
        [JsonProperty("difficulty")]
        public string Difficulty { get; set; }
        [JsonProperty("question")]
        public string QuestionTxt { get; set; }
        [JsonProperty("correctanswer")]
        public string CorrectAnswer { get; set; }
        [JsonProperty("alternatives")]
        public List<string> Alternatives { get; set; }
        [JsonProperty("questionNo")]
        public int QuestionNo { get; set; }
        public string Answer { get; set; }
    }
}
