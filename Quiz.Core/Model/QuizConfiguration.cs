namespace Quiz.Core.Model
{
    public class QuizConfiguration
    {
        public int NumberOfRounds { get; set; }

        public int NumberOfTopicsInRound { get; set; }

        public int NumberOfQuestionsInTopic { get; set; }

        public double MinCost { get; set; }

        public double RoundCostFactor { get; set; }

        public int ComplexityLevel { get; set; }
    }
}
