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
                                while (true)
                                {
                                   int finalscore=HistoryTrivia();
                                   ForegroundColor=ConsoleColor.Yellow;
                            WriteLine($"YOUR FINAL SCORE IS {finalscore} ");
                             ForegroundColor=ConsoleColor.White;
                            Write("Press Esc if you want to go back to the menu, or  Press Enter if you want to play again:");
                            ConsoleKey key = Console.ReadKey().Key;
                            if (key == ConsoleKey.Enter)
                             continue;
                             else if (key==ConsoleKey.Escape)
                             {
                               break; 
                             }
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
                    ForegroundColor=ConsoleColor.White;
                    WriteLine("Each section (Mathematics, geography, biology, history and movies) is divided into 2 or 3 mini-games, like for example; trivia, character guess, continue the story, and riddles. Every time you complete one of these minigames you will have more points and you will be able to finish and unlock more sections. For the multiple choice questions you must answer only with the letters ''a', 'b', 'c', and 'd'. If you get a question right you will have 20 more points, otherwise, if you answer wrong you will lose 10 points");
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
                    Console.WriteLine("SECTIONS");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("1.- MATH");
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("2. HISTORY");
                    ForegroundColor = ConsoleColor.Green;
                    Write("3. BIOLOGY");
                    ForegroundColor = ConsoleColor.DarkGray;
                    WriteLine(@$"                       NOT AVAILABLE", 20);
                      ForegroundColor = ConsoleColor.Blue;
                       Write("4. GEOGRAPHY");
                       ForegroundColor = ConsoleColor.DarkGray;
                    WriteLine(@$"                     NOT AVAILABLE", 20);
                        ForegroundColor = ConsoleColor.Magenta;
                       Write("5. GEOGRAPHY");
                       ForegroundColor = ConsoleColor.DarkGray;
                    WriteLine(@$"                     NOT AVAILABLE", 20);
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
 ForegroundColor = ConsoleColor.White;
WriteLine("Which era marked a switch from agricultural practices to industrial practices?");
ForegroundColor = ConsoleColor.Blue;
WriteLine("a) French Revolution");
ForegroundColor = ConsoleColor.Yellow;
WriteLine("b) The Industrial Revolution");
ForegroundColor = ConsoleColor.Magenta;
WriteLine("c) Agricultural Revolution");
ForegroundColor = ConsoleColor.Green;
WriteLine("d) The Renaissance");
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
        score+=20;
        }
        static void WrongAnswer(ref int score)
        {
            ForegroundColor = ConsoleColor.Red;
        Write("INCORRECT");
         ForegroundColor = ConsoleColor.Red;
        WriteLine(@"    -10 pts",20);
        score-=10;
        }
        static char Question4()
        {
            while (true)
            {
                try{
 ForegroundColor = ConsoleColor.White;
WriteLine("How many U.S. presidents have been assassinated?");
ForegroundColor = ConsoleColor.Blue;
WriteLine("a) 3");
ForegroundColor = ConsoleColor.Yellow;
WriteLine("b) 6");
ForegroundColor = ConsoleColor.Magenta;
WriteLine("c) 10");
ForegroundColor = ConsoleColor.Green;
WriteLine("d) 4");
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
        static char Question5()
        {
            while (true)
            {
                try{
 ForegroundColor = ConsoleColor.White;
WriteLine("What year did women receive the right to vote in the United States??");
ForegroundColor = ConsoleColor.Blue;
WriteLine("a) 1923");
ForegroundColor = ConsoleColor.Yellow;
WriteLine("b) 1823");
ForegroundColor = ConsoleColor.Magenta;
WriteLine("c) 1886");
ForegroundColor = ConsoleColor.Green;
WriteLine("d) 1920");
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
        static char Question6()
        {
            while (true)
            {
                try{
 ForegroundColor = ConsoleColor.White;
WriteLine("What year did the Berlin wall fall?");
ForegroundColor = ConsoleColor.Blue;
WriteLine("a) 1989");
ForegroundColor = ConsoleColor.Yellow;
WriteLine("b) 1889");
ForegroundColor = ConsoleColor.Magenta;
WriteLine("c) 1991");
ForegroundColor = ConsoleColor.Green;
WriteLine("d) 1990");
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
        static char Question7()
        {
            while (true)
            {
                try{
 ForegroundColor = ConsoleColor.White;
WriteLine("Who was prime minister of the UK for most of the Second World War?");
ForegroundColor = ConsoleColor.Blue;
WriteLine("a) Margareth Thatcher");
ForegroundColor = ConsoleColor.Yellow;
WriteLine("b) Winston Churchil");
ForegroundColor = ConsoleColor.Magenta;
WriteLine("c) Anthony Eden");
ForegroundColor = ConsoleColor.Green;
WriteLine("d) Harold McMillan");
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
        static char Question8()
        {
            while (true)
            {
                try{
 ForegroundColor = ConsoleColor.White;
WriteLine("In which country in ancient times was mummification carried out on important people when they died?");
ForegroundColor = ConsoleColor.Blue;
WriteLine("a) Ancient Greece");
ForegroundColor = ConsoleColor.Yellow;
WriteLine("b) Ancient China");
ForegroundColor = ConsoleColor.Magenta;
WriteLine("c) Ancient India");
ForegroundColor = ConsoleColor.Green;
WriteLine("d) Ancient Egypt");
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
        static char Question9()
        {
            while (true)
            {
                try{
 ForegroundColor = ConsoleColor.White;
WriteLine("What was the date of the Boston Tea Party?");
ForegroundColor = ConsoleColor.Blue;
WriteLine("a) Dec. 16, 1773,");
ForegroundColor = ConsoleColor.Yellow;
WriteLine("b) Dec. 23, 1774");
ForegroundColor = ConsoleColor.Magenta;
WriteLine("c) Dec. 17, 1773");
ForegroundColor = ConsoleColor.Green;
WriteLine("d) Dec, 16 1774");
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
        
        static int HistoryTrivia()
        {
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
                            Status(ref question, ref score);
                            char question3=Question3();
                            if (question3=='b')
                            {
                                 CorrectAnswer(ref score);
                                 question++;
                            }
                            else 
                            {
                                 WrongAnswer(ref score); 
                                 question++;
                            }
                            char question4=Question4();
                            if (question4=='d')
                            {
                                 CorrectAnswer(ref score);
                                 question++;
                            }
                            else 
                            {
                                 WrongAnswer(ref score); 
                                 question++;
                            }
                             char question5=Question5();
                            if (question5=='d')
                            {
                                 CorrectAnswer(ref score);
                                 question++;
                            }
                            else 
                            {
                                 WrongAnswer(ref score); 
                                 question++;
                            }
                            char question6=Question6();
                            if (question6=='a')
                            {
                                 CorrectAnswer(ref score);
                                 question++;
                            }
                            else 
                            {
                                 WrongAnswer(ref score); 
                                 question++;
                            }
                             char question7=Question7();
                            if (question7=='b')
                            {
                                 CorrectAnswer(ref score);
                                 question++;
                            }
                            else 
                            {
                                 WrongAnswer(ref score); 
                                 question++;
                            }
                            char question8=Question8();
                            if (question8=='d')
                            {
                                 CorrectAnswer(ref score);
                                 question++;
                            }
                            else 
                            {
                                 WrongAnswer(ref score); 
                                 question++;
                            }
                            char question9=Question9();
                            if (question9=='a')
                            {
                                 CorrectAnswer(ref score);
                                 question++;
                            }
                            else 
                            {
                                 WrongAnswer(ref score); 
                                 question++;
                            }
                            return score;
                            }
                        }

        }
        


