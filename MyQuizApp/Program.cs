namespace MyQuizApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Question[] questions = new Question[]
            {
                new Question("What is the capital of Germany?",
                new string[] {"Paris","Berlin","London","Madrid"},
                1),
                new Question("What is the square root of 144?",
                new string[] {"14","8","12","6"},
                2),
                new Question("What is Eight(8) in Spanish?",
                new string[] {"ocho","tres","diez","cinco"},
                0)
            };

            Quiz myQuiz = new Quiz(questions);
            myQuiz.StartQuiz();
            Console.ReadLine();
        }
    }
}
