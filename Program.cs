namespace MyQuizzApp;

class Program
{
    static void Main(string[] args)
    {
        Question[] questions = new Question[]
        {
            new Question(
                "What is the capital of Germany?",
                new String[] { "Paris", "Berlin", "London", "Madrid" },
                1)
        };
        Quizz myQuizz = new Quizz(questions);
        myQuizz.DisplayQuestion(questions[0]);
        /* Preliminary try to check for answer.
        int choice = int.Parse(Console.ReadLine());
        if(questions[0].isCorrectAnswer(choice)){
        cw "You have guessed right";
        }else{"You have guess wrong";}
        */
    }
}