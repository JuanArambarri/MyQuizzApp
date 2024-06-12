namespace MyQuizzApp;

public class Quizz
{
    private Question[] questions;

    public Quizz(Question[] questions) //the array will be run in another class
    {
        this.questions = questions;
    }

    public void DisplayQuestion(Question question) //should be private. (Made public for testing)
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║                                 Question                                ║");
        Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════╝");
        Console.ResetColor();
        Console.WriteLine(question.QuestionText); //taking advantage of the property
        for (int i = 0; i < question.Answers.Length; i++)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("   "); //create fake indentation
            Console.Write(i+1); //Question number with different colour
            Console.ResetColor(); //makes text normal again
            Console.WriteLine($". {question.Answers[i]}");
        }
    }
}