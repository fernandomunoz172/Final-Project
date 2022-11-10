using System;
using static System.Console;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
             while (true)
            {
                int choice = PrincipalMenu();
                switch (choice)
                {
                    case 1:
                        while (true)
                        {
                            Clear();
                            int menu=FirstMenu();
                            switch (menu)
                            {
                                case 2:
                                    Clear();
                                int question=1;
                                int score=0;
                                Status(ref question, ref score);
                                ForegroundColor = ConsoleColor.White;
                                char question1=Question1();
                                Clear();
                                if (question1=='a')
                                {
                                    CorrectAnswer(ref score);
                                      question++;
                                }
                            else{
                                WrongAnswer(ref score);
                                  question++;
                            }
                            Status(ref question, ref score);
                            char question2=Question2();
                            if (question2=='c')
                            {
                                 CorrectAnswer(ref score);
                                 question++;
                            }
                            else 
                            {
                                 WrongAnswer(ref score); 
                                 question++;
                            }

    
                                break;
                            }
                        }
                        
                        break;
                    case 2:
                    while (true)
                    {
                        Console.Clear();
                    ForegroundColor=ConsoleColor.Blue;
                    WriteLine("HOW TO PLAY ");
                    Write("Press any key to get back to the menu.");
                    Console.ReadKey();
                    Console.Clear();
                        break;
                     }
                    break;
                }
                    if (choice==3)
                    {
                        break;
                    }

        
            }
        }
        static int PrincipalMenu()
        {
            while (true)
            {
                try
                {
                    ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("NERDS GAME");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("1.- PLAY GAME");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("2. HOW TO PLAY");
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("3. EXIT");
                      ForegroundColor = ConsoleColor.White;
                    Write("Put the number of the action you would like to do: ");
                    
                    int prompt = Convert.ToInt32(ReadLine());
                    if (prompt == 1 || prompt == 2 || prompt == 3)
                        return prompt;
                    else
                    {
                        Clear();
                         ForegroundColor = ConsoleColor.Red;
                        WriteLine("That was not in the option. TRY AGAIN");
                        continue;
                    }
                }
                catch
                {
                    Clear();
                     ForegroundColor = ConsoleColor.Red;
                    WriteLine("That was not in the option. TRY AGAIN");
                }
            }
        }
        static int FirstMenu()
        {
            while (true)
            {
                try
                {
                    ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("SECTIOONS");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("1.- MATH");
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("2. HISTORY");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("3. BIOLOGY");
                      ForegroundColor = ConsoleColor.Blue;
                       WriteLine("4. GEOGRAPHY");
                        ForegroundColor = ConsoleColor.Magenta;
                       WriteLine("5. GEOGRAPHY");
                        ForegroundColor = ConsoleColor.DarkRed;
                       WriteLine("6. BACK");
                        ForegroundColor = ConsoleColor.White;
                    Write("Put the number of the action you would like to do: ");
                    
                    int prompt = Convert.ToInt32(ReadLine());
                    if (prompt == 1 || prompt == 2 || prompt == 3||prompt == 4)
                        return prompt;
                    else
                    {
                        Clear();
                         ForegroundColor = ConsoleColor.Red;
                        WriteLine("That was not in the option. TRY AGAIN");
                        continue;
                    }
                }
                catch
                {
                    Clear();
                     ForegroundColor = ConsoleColor.Red;
                    WriteLine("That was not in the option. TRY AGAIN");
                }
            }
        }
        static char Question1()
        {
            while (true)
            {
                try{
 ForegroundColor = ConsoleColor.White;
WriteLine("Who was the author of 'The odyssey'?");
ForegroundColor = ConsoleColor.Blue;
WriteLine("a) Homer");
ForegroundColor = ConsoleColor.Yellow;
WriteLine("b) Stephen King");
ForegroundColor = ConsoleColor.Magenta;
WriteLine("c) Aristotle");
ForegroundColor = ConsoleColor.Green;
WriteLine("d) Hesiod");
ForegroundColor = ConsoleColor.DarkGray;
WriteLine("TYPE JUST THE LETTER OF THE ANSWER");
ForegroundColor = ConsoleColor.White;
Write("Answer: ");
char answer=Convert.ToChar(ReadLine());
if ( answer== 'a' || answer == 'b'|| answer=='c'||answer == 'd')
                        return answer;
                    else
                    {
                        Clear();
                         ForegroundColor = ConsoleColor.Red;
                        WriteLine("That was not in the option. TRY AGAIN");
                        continue;
                    }
                }
                catch
                {
                    Clear();
                     ForegroundColor = ConsoleColor.Red;
                    WriteLine("That was not in the option. TRY AGAIN");
                }
                }
        
        }
          static char Question2()
        {
            while (true)
            {
                try{
 ForegroundColor = ConsoleColor.White;

WriteLine("Who was the fourth president of the United States?");
ForegroundColor = ConsoleColor.Blue;
WriteLine("a) Tomas Jefferson");
ForegroundColor = ConsoleColor.Yellow;
WriteLine("b) George Washington");
ForegroundColor = ConsoleColor.Magenta;
WriteLine("c) James Madison");
ForegroundColor = ConsoleColor.Green;
WriteLine("d) Abraham Lincoln");
ForegroundColor = ConsoleColor.DarkGray;
WriteLine("TYPE JUST THE LETTER OF THE ANSWER");
ForegroundColor = ConsoleColor.White;
Write("Answer: ");
char answer=Convert.ToChar(ReadLine());
Clear();
if ( answer== 'a' || answer == 'b'|| answer=='c'||answer == 'd')
                        return answer;
                    else
                    {
                        Clear();
                         ForegroundColor = ConsoleColor.Red;
                        WriteLine("That was not in the option. TRY AGAIN");
                        continue;
                    }
                }
                catch
                {
                    Clear();
                     ForegroundColor = ConsoleColor.Red;
                    WriteLine("That was not in the option. TRY AGAIN");
                }
                }
        
        }
         static char Question3()
        {
            while (true)
            {
                try{
WriteLine("Which era marked a switch from agricultural practices to industrial practices?");
ForegroundColor = ConsoleColor.Blue;
WriteLine("a) French Revolution");
ForegroundColor = ConsoleColor.Yellow;
WriteLine("b) ");
ForegroundColor = ConsoleColor.Magenta;
WriteLine("c) James Madison");
ForegroundColor = ConsoleColor.Green;
WriteLine("d) Abraham Lincoln");
ForegroundColor = ConsoleColor.DarkGray;
WriteLine("TYPE JUST THE LETTER OF THE ANSWER");
ForegroundColor = ConsoleColor.White;
Write("Answer: ");
char answer=Convert.ToChar(ReadLine());
Clear();
if ( answer== 'a' || answer == 'b'|| answer=='c'||answer == 'd')
                        return answer;
                    else
                    {
                        Clear();
                         ForegroundColor = ConsoleColor.Red;
                        WriteLine("That was not in the option. TRY AGAIN");
                        continue;
                    }
                }
                catch
                {
                    Clear();
                     ForegroundColor = ConsoleColor.Red;
                    WriteLine("That was not in the option. TRY AGAIN");
                }
                }
        
        }
         static void Status(ref int question, ref int score)
        {
            ForegroundColor=ConsoleColor.Cyan;
            WriteLine($"Question {question}  Score: {score}");
        }
        static void CorrectAnswer(ref int score)
        {
            ForegroundColor = ConsoleColor.Green;
        Write("CORRECT");
         ForegroundColor = ConsoleColor.Green;
        WriteLine(@"    +20 pts",20);
        score=+20;
        }
        static void WrongAnswer(ref int score)
        {
            ForegroundColor = ConsoleColor.Red;
        Write("INCORRECT");
         ForegroundColor = ConsoleColor.Red;
        WriteLine(@"    -10 pts",20);
        score=-10;
        }
        }
    }


