using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiveToSeven.Services.MinichTwo
{
    public class AskingQuestionsService : IAskingQuestionsService
    {
        public string AskinQs(string yourName, string timeYouWokeUp)
        {
                    
        return $"hi {yourName}, you woke up at {timeYouWokeUp}";

        }

    }
}