using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Core.Model
{
    public class QuizGame : QuizEntity
    {
        public Guid ConfigurationId { get; set; }

        public IList<Player> Players { get; set; }

        public IList<QuestionInQuiz> Questions { get; set; }

        public QuestionInQuiz FinalQuestion { get; set; }

        public bool GamePlayed { get; set; }

        public int CurrentRound { get; set; }
    }
}
