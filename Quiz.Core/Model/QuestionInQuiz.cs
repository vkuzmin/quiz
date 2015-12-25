using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Core.Model
{
    public class QuestionInQuiz : QuizEntity
    {
        public Guid QuizId { get; set; }

        public Guid QuestionId { get; set; }

        public Question Question { get; set; }

        public int RoundNumber { get; set; }

        public double Cost { get; set; }

        public bool QuestionPlayed { get; set; }

        public Guid? AnsweredById { get; set; }

        public bool? AnsweredCorrectly { get; set; }
    }
}
