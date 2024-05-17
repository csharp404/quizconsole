using ConsoleApp6;
internal class Program
{
    private static void Main(string[] args)
    {
        again: {
            #region declareNewApplicant
            int age = 0;
            string name = "";
            Console.Write("Enter your name please :");
           
            name = Console.ReadLine();
            Console.Write("Enter your age please :");
            if (int.TryParse(Console.ReadLine(), out int a))
                 age = a;

            Applicants applicant = new Applicants(name, age);
            #endregion
            #region startTime
            DateTime time = DateTime.Now;
            Console.WriteLine($"The quiz starts now at {time.ToShortTimeString()}");
            #endregion
            #region questionsWithAnswers
            string[] questions = {
            "1. What is the capital city of Japan?\n   a) Kyoto\n   b) Osaka\n   c) Hiroshima\n   d) Tokyo",
            "2. Which planet is known as the 'Red Planet'?\n   a) Earth\n   b) Jupiter\n   c) Mars\n   d) Venus",
            "3. What is the largest mammal in the world?\n   a) African Elephant\n   b) Blue Whale\n   c) Great White Shark\n   d) Giraffe",
            "4. What is the hardest natural substance on Earth?\n   a) Gold\n   b) Iron\n   c) Diamond\n   d) Silver",
            "5. What is the chemical symbol for water?\n   a) H2O\n   b) O2\n   c) H2\n   d) HO",
        };
            char[] correctAnswers = { 'd', 'c', 'b', 'c', 'a' };


            List<Tuple<int, char, string>> question = new List<Tuple<int, char, string>>();

            for (int i = 0; i < questions.Length; i++)
            {
                question.Add(new Tuple<int, char, string>(i+1, correctAnswers[i], questions[i]));
            }
            #endregion
            #region enterAnswerAndCheck
            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine(questions[i]);
                Console.WriteLine("Answer :");

                if (char.Parse(Console.ReadLine()) == question.ElementAt(i).Item2)
                {
                    applicant.AddPoint();
                    Console.WriteLine("Correct Answer :)");
                }
                else
                {
                    Console.WriteLine("Wrong Answer :(");
                }
            }
            #endregion
            #region theFinalResult
            DateTime time1 = DateTime.Now;
            Console.WriteLine($"The quiz ends now at {time1.ToShortTimeString()}");
            Console.WriteLine($"The total time spent on the Quiz is {time1 - time} Seconds...");
            Console.WriteLine("Now the result is:");
            Console.WriteLine($"NAME --> {applicant.name}\nAGE --> {applicant.age}\nYOUR SCORE IS : {applicant.getScore()} of {questions.Length} ");
            #endregion
        }
        Console.WriteLine("if you want play again press number 1 or 0 to exit :");
        if (int.Parse(Console.ReadLine()) == 1)
        {
            goto again;
        }
         else
        {
            Console.WriteLine("Good Bye :)");
            return;
        }

    }
}
