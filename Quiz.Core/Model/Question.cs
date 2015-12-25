using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Core.Model
{
    public class Question : QuizEntity
    {
        public string Body { get; set; }

        public string Description { get; set; }

        public string Answer { get; set; }

        public int ComplexityLevel { get; set; }

        public Guid TopicId { get; set; }
    }
}
