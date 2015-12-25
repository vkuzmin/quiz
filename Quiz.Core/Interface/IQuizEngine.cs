using System;
using Quiz.Core.Model;

namespace Quiz.Core.Interface
{
    public interface IQuizEngine
    {
        /// <summary>
        /// Starts the quiz according to configuration.
        /// </summary>
        QuizGame StartQuiz(QuizConfiguration configuration);

        /// <summary>
        /// Finishes the quiz.
        /// </summary>
        void EndQuiz(Guid quizId);

        /// <summary>
        /// Gets question by id.
        /// </summary>
        QuestionInQuiz GetQuestion(Guid questionId);

        /// <summary>
        /// Plays question by id.
        /// </summary>
        void PlayQuestion(Guid questionId, Guid? playedById, bool? isAnswered);

        /// <summary>
        /// Gets current state of quiz.
        /// </summary>
        QuizGame GetCurrentQuizGameState(Guid quizGameId);
    }
}
