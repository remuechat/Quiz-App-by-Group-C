using System;

namespace PT1_CANTERO_CARREON_DACERA_CELDA_CHAVEZ
{
    class Program
    {
        static void Main(string[] args)
        {
            // INTRODUCTION TEXT 
            Console.WriteLine("     --------------------------------------------------");
            Console.WriteLine("     |                      </QUIZ APP>                 |");
            Console.WriteLine("     --------------------------------------------------");
            // PUBLIC VARIABLES
            // security variables
            int tries = 0;
            int MaxTries = 3;
            bool AllowQuiz = false;
            // quiz counters
            int TotalScore = 0;
            int CorrectTally = 0;
            // LOG-IN PROMPT
            while (true)
            {
                while (true)
                {
                    Console.WriteLine();
                    Console.WriteLine("LOG-IN");

                    // User Prompt : INPUTS
                    // username
                    Console.WriteLine("Enter username:");
                    string username = Console.ReadLine();

                    Console.WriteLine();
                    // password
                    Console.WriteLine("Enter password:");
                    string password = Console.ReadLine();

                    Console.WriteLine();
                    // User Prompt : CONFIRMATION 
                    Console.WriteLine("------------------");
                    Console.WriteLine("Is this correct?");
                    Console.WriteLine("USERNAME : " + username);
                    Console.WriteLine("PASSWORD : " + password);
                    Console.WriteLine("------------------");
                    Console.WriteLine("YES or NO");
                    string confirm = Console.ReadLine();

                    Console.WriteLine();
                    while (true)
                    {
                        // CONFIRMATION PATHS
                        // yes path of verification
                        if (confirm == "YES")
                        {
                            // LOG-IN VERIFICATION
                            // if > 3 times
                            if (tries >= MaxTries)
                            {
                                Console.WriteLine("You are having suspecious activity and is not allowed to take the test.");
                                Console.WriteLine("Press any key to escape.");
                                Console.ReadLine();
                                return;
                            }
                            // if try is right
                            if (username == "Group C" && password == "12345")
                            {
                                AllowQuiz = true;
                                break;
                            }
                            tries++;
                            // if try was < 3
                            Console.WriteLine();
                            if (tries == 1)
                            {
                                // 1st wrong try
                                AllowQuiz = false;
                                Console.WriteLine("You have entered the wrong credetials.");
                                Console.WriteLine("You only have two (2) more tries to enter credentials");
                                Console.WriteLine(" --------------------------------------------------");
                                Console.WriteLine();

                            }
                            else if (tries == 2)
                            {
                                // 2nd wrong try
                                AllowQuiz = false;
                                Console.WriteLine("You have entered the wrong credetials.");
                                Console.WriteLine("You only have one (1) more tries to enter credentials");
                                Console.WriteLine(" --------------------------------------------------");
                                Console.WriteLine();
                            }
                            else if (tries == 3)
                            {
                                // 3rd wrong try
                                AllowQuiz = false;
                                Console.WriteLine("You have entered the wrong credetials.");
                                Console.WriteLine("This is your last try for entering your credentials.");
                                Console.WriteLine(" --------------------------------------------------");
                                Console.WriteLine();
                            }
                            break;
                        }
                        // no path of verification
                        else if (confirm == "NO")
                        {
                            Console.WriteLine("Do you want to enter credentials again?");
                            Console.WriteLine("YES OR NO");
                            string EnterCredentials = (Console.ReadLine());
                            if (EnterCredentials == "YES")
                            {
                                break;
                            }
                            else if (EnterCredentials == "NO")
                            {
                                return;
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Try again. Enter any key to exit");
                                Console.ReadLine();
                                return;
                            }
                            // will make the while loop true and return to log-in prompt
                        }
                        // invalid key was pressed
                        else
                        {
                            Console.WriteLine("Invalid input. Try again. Enter any key to exit");
                            Console.WriteLine();
                            Console.ReadLine();
                            return;
                        }
                    }
                    while (AllowQuiz == true)
                    {
                        // START QUIZ
                        // INSTRUCTIONS
                        Console.WriteLine("POP QUIZ! There are 5 questions on this biology quiz. This is a");
                        Console.WriteLine("multiple choice quiz, and answer shoule be a CAPITAL LETTER.");
                        Console.WriteLine("Answers that are not capitalized will not be counted. Bonne chance!");

                        // QUESTION #1
                        Console.WriteLine();
                        Console.WriteLine("Question #1");
                        Console.WriteLine("Which blood cells in our body help to fight infection?");
                        Console.WriteLine();
                        Console.WriteLine("A. White Blood Cells");
                        Console.WriteLine("B. Fat Cells");
                        Console.WriteLine("C. Red Blood Cells");
                        Console.WriteLine("D. Platelets");
                        Console.WriteLine("Press ENTER to submit your answer.");
                        Console.Write("Enter your answer : ");
                        string q1 = Console.ReadLine();
                        switch (q1)
                        {
                            // Right Answers
                            case "A":
                                CorrectTally = CorrectTally + 1;
                                TotalScore = TotalScore + 1;
                                break;
                            //Wrong Answers
                            default:
                                TotalScore = TotalScore + 1;
                                break;
                        }
                        Console.WriteLine();

                        // QUESTION #2
                        Console.WriteLine();
                        Console.WriteLine("Question #2");
                        Console.WriteLine("A cell membrane is ______________?");
                        Console.WriteLine();
                        Console.WriteLine("A. Permeable");
                        Console.WriteLine("B. Semipermeable");
                        Console.WriteLine("C. Nonpermeable");
                        Console.WriteLine("D. None of the above");
                        Console.WriteLine("Press ENTER to submit your answer.");
                        Console.Write("Enter your answer : ");
                        string q2 = Console.ReadLine();
                        switch (q2)
                        {
                            // Right Answers
                            case "B":
                                CorrectTally = CorrectTally + 1;
                                TotalScore = TotalScore + 1;
                                break;
                            //Wrong Answers
                            default:
                                TotalScore = TotalScore + 1;
                                break;
                        }
                        Console.WriteLine();

                        // QUESTION #3
                        Console.WriteLine();
                        Console.WriteLine("Question #3");
                        Console.WriteLine("A cell uses which of the following to accelerate chemical reactions enabling its metabolic machinery to operate?");
                        Console.WriteLine();
                        Console.WriteLine("A. Centranosome");
                        Console.WriteLine("B. Lysosome");
                        Console.WriteLine("C. Golgi Apparatus");
                        Console.WriteLine("D. Enzymes");
                        Console.WriteLine("Press ENTER to submit your answer.");
                        Console.Write("Enter your answer : ");
                        string q3 = Console.ReadLine();
                        switch (q3)
                        {
                            // Right Answers
                            case "D":
                                CorrectTally = CorrectTally + 1;
                                TotalScore = TotalScore + 1;
                                break;
                            //Wrong Answers
                            default:
                                TotalScore = TotalScore + 1;
                                break;
                        }
                        Console.WriteLine();

                        // QUESTION #4
                        Console.WriteLine();
                        Console.WriteLine("Question #4");
                        Console.WriteLine("Which of the following is not part of the metabolic sequence");
                        Console.WriteLine();
                        Console.WriteLine("A. Photosynthesis");
                        Console.WriteLine("B. Respiration");
                        Console.WriteLine("C. Hydroplasm");
                        Console.WriteLine("D. Digestion");
                        Console.WriteLine("Press ENTER to submit your answer.");
                        Console.Write("Enter your answer : ");
                        string q4 = Console.ReadLine();
                        switch (q4)
                        {
                            // Right Answers
                            case "C":
                                CorrectTally = CorrectTally + 1;
                                TotalScore = TotalScore + 1;
                                break;
                            //Wrong Answers
                            default:
                                TotalScore = TotalScore + 1;
                                break;
                        }
                        Console.WriteLine();

                        // QUESTION #5
                        Console.WriteLine();
                        Console.WriteLine("Question #5");
                        Console.WriteLine("Which of the following are NOT organelles found in animal cells");
                        Console.WriteLine();
                        Console.WriteLine("A. Nucleus and Golgi Apparatus");
                        Console.WriteLine("B. Cellular Membrane and Cytoplasm");
                        Console.WriteLine("C. Mitochondria and Ribosomes");
                        Console.WriteLine("D. Chloroplast and Central Vacuole");
                        Console.WriteLine("Press ENTER to submit your answer.");
                        Console.Write("Enter your answer : ");
                        string q5 = Console.ReadLine();
                        switch (q5)
                        {
                            // Right Answers
                            case "D":
                                CorrectTally = CorrectTally + 1;
                                TotalScore = TotalScore + 1;
                                break;
                            //Wrong Answers
                            default:
                                TotalScore = TotalScore + 1;
                                break;
                        }
                        Console.WriteLine();

                        // QUESTION #6
                        Console.WriteLine();
                        Console.WriteLine("Question #6");
                        Console.WriteLine("The functional unit of heredity is the _____________.");
                        Console.WriteLine();
                        Console.WriteLine("A. Gene");
                        Console.WriteLine("B. Chromosome");
                        Console.WriteLine("C. Protein");
                        Console.WriteLine("D. Nucleus");
                        Console.WriteLine("Press ENTER to submit your answer.");
                        Console.Write("Enter your answer : ");
                        string q6 = Console.ReadLine();
                        switch (q6)
                        {
                            // Right Answers
                            case "A":
                                CorrectTally = CorrectTally + 1;
                                TotalScore = TotalScore + 1;
                                break;
                            //Wrong Answers
                            default:
                                TotalScore = TotalScore + 1;
                                break;
                        }
                        Console.WriteLine();

                        // QUESTION #7
                        Console.WriteLine();
                        Console.WriteLine("Question #7");
                        Console.WriteLine("Which of the following represents the largest group of biological classification?");
                        Console.WriteLine();
                        Console.WriteLine("A. Kingdom");
                        Console.WriteLine("B. Species");
                        Console.WriteLine("C. Class");
                        Console.WriteLine("D. Genus");
                        Console.WriteLine("Press ENTER to submit your answer.");
                        Console.Write("Enter your answer : ");
                        string q7 = Console.ReadLine();
                        switch (q7)
                        {
                            // Right Answers
                            case "A":
                                CorrectTally = CorrectTally + 1;
                                TotalScore = TotalScore + 1;
                                break;
                            //Wrong Answers
                            default:
                                TotalScore = TotalScore + 1;
                                break;
                        }
                        Console.WriteLine();

                        // QUESTION #8
                        Console.WriteLine();
                        Console.WriteLine("Question #8");
                        Console.WriteLine("How many chromosomes does an individual human person have?");
                        Console.WriteLine();
                        Console.WriteLine("A. 23");
                        Console.WriteLine("B. 46");
                        Console.WriteLine("C. 64");
                        Console.WriteLine("D. 82");
                        Console.WriteLine("Press ENTER to submit your answer.");
                        Console.Write("Enter your answer : ");
                        string q8 = Console.ReadLine();
                        switch (q8)
                        {
                            // Right Answers
                            case "B":
                                CorrectTally = CorrectTally + 1;
                                TotalScore = TotalScore + 1;
                                break;
                            //Wrong Answers
                            default:
                                TotalScore = TotalScore + 1;
                                break;
                        }
                        Console.WriteLine();

                        // QUESTION #9
                        Console.WriteLine();
                        Console.WriteLine("Question #9");
                        Console.WriteLine("The bodies of all insects have _______ major divisions.");
                        Console.WriteLine();
                        Console.WriteLine("A. 2");
                        Console.WriteLine("B. 3");
                        Console.WriteLine("C. 4");
                        Console.WriteLine("D. 5");
                        Console.WriteLine("Press ENTER to submit your answer.");
                        Console.Write("Enter your answer : ");
                        string q9 = Console.ReadLine();
                        switch (q9)
                        {
                            // Right Answers
                            case "B":
                                CorrectTally = CorrectTally + 1;
                                TotalScore = TotalScore + 1;
                                break;
                            //Wrong Answers
                            default:
                                TotalScore = TotalScore + 1;
                                break;
                        }
                        Console.WriteLine();

                        // QUESTION #10
                        Console.WriteLine();
                        Console.WriteLine("Question #10");
                        Console.WriteLine("Sterile female honey bees are called _________________.");
                        Console.WriteLine();
                        Console.WriteLine("A. Drones");
                        Console.WriteLine("B. Queen");
                        Console.WriteLine("C. Guards");
                        Console.WriteLine("D. Workers");
                        Console.WriteLine("Press ENTER to submit your answer.");
                        Console.Write("Enter your answer : ");
                        string q10 = Console.ReadLine();
                        switch (q10)
                        {
                            // Right Answers
                            case "D":
                                CorrectTally = CorrectTally + 1;
                                TotalScore = TotalScore + 1;
                                break;
                            //Wrong Answers
                            default:
                                TotalScore = TotalScore + 1;
                                break;
                        }
                        Console.WriteLine();

                        Console.WriteLine();
                        // SCORE PROMPT
                        Console.WriteLine("Would you like to see your score?");
                        Console.WriteLine("YES OR NO");
                        string PromptScore = Console.ReadLine();

                        Console.WriteLine();
                        Console.WriteLine();
                        // score prompt is enabled
                        if (PromptScore == "YES")
                        {
                            Console.WriteLine("     ||     You got {0} out of {1} questions!     ||     ", CorrectTally, TotalScore);
                            Console.WriteLine("---------------------------------------------------------");
                            // comments on how you did
                            if (CorrectTally == 10)
                            {
                                Console.WriteLine("     You got a perfect score! Good job!");
                            }
                            else if (CorrectTally > 7)
                            {
                                Console.WriteLine("     You got a great score! Good job!");
                            }
                            else if (CorrectTally > 5)
                            {
                                Console.WriteLine("  Good job! But a little practice will also great :0");
                            }
                            else
                            {
                                Console.WriteLine("Well, practice takes time and success goes to those who persevere ;)");
                            }
                        }
                        else if (PromptScore == "x1%2KA2#s!xc1ASFDqw1*3")
                        {
                            Console.WriteLine(" QUESTION #1 : A");
                            Console.WriteLine(" QUESTION #2 : B");
                            Console.WriteLine(" QUESTION #3 : D");
                            Console.WriteLine(" QUESTION #4 : C");
                            Console.WriteLine(" QUESTION #5 : D");
                            Console.WriteLine(" QUESTION #6 : A");
                            Console.WriteLine(" QUESTION #7 : A");
                            Console.WriteLine(" QUESTION #8 : B");
                            Console.WriteLine(" QUESTION #9 : B");
                            Console.WriteLine("QUESTION #10 : D");
                        }

                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        // EXIT QUIZ                    
                        Console.WriteLine("Would you like to take the quiz again?");
                        Console.WriteLine("YES OR NO");
                        string Exit = (Console.ReadLine());
                        if (Exit == "YES")
                        {
                            Console.WriteLine();
                            Console.WriteLine("You need to log-in again.");
                            Console.WriteLine("---------------------------");
                            // RESET COUNTERS
                            tries = 0;
                            MaxTries = 3;
                            AllowQuiz = false;
                            TotalScore = 0;
                            CorrectTally = 0;
                            break;
                        }
                        else
                        {
                            return;
                        }
                    }
                }
            }
        }

    }
}
