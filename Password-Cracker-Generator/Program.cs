using System;
using System.Diagnostics;
using System.Threading;
namespace Password_Cracker_Generator
{
    class Program
    {
        static char[] characters = { '1', '2', '3', '4', '5', '6', '7', '8', '9',
                                    'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
                                    'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z', '!', '@' };
        static int count = 0;
        static bool aborted = false;
        static Stopwatch sw = new Stopwatch();
        static Random random = new Random();
        static string lastGuess = "";
        static void Main(string[] args)
        {
            while (true)
            {
                Menu();
            }
        }
        static void Cracker()
        {
            Console.Write("Please enter password: ");
            string password = Console.ReadLine();
            object threadPassword = password;
            Console.WriteLine("Brute force thread started");
            Thread BruteForceThread = new Thread(new ParameterizedThreadStart(BruteForce));
            BruteForceThread.Start(threadPassword);

            Console.WriteLine("Input thread started");
            Thread getInputThread = new Thread(GetInput);
            getInputThread.Start();
            while (!aborted)
                if (!BruteForceThread.IsAlive)
                {
                    aborted = true;

                }
            Console.WriteLine("Press any key to continue");
        }
        static void Generator()
        {
            Console.Write("Enter password length: ");
            string pLength = Console.ReadLine();
            string generatedPassword = "";
            for (int i = 0; i < Int32.Parse(pLength); i++)
            {
                int IDx = random.Next(characters.Length);
                generatedPassword += characters[IDx];
            }
            Console.WriteLine("Generated password: " + generatedPassword);
        }
        static void Menu()
        {
            string input = "";
            while (input != "1" && input != "2")
            {
                Console.WriteLine("[1] Password cracker\n[2] Password generator");
                Console.Write("Input: ");
                input = Console.ReadLine();
            }
            switch (input)
            {
                case "1":
                    Cracker();
                    break;
                case "2":
                    Generator();
                    break;
                default:
                    break;
            }
        }
        static void StopWatchOutput()
        {
            TimeSpan ts = sw.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            Console.WriteLine("Time :" + elapsedTime);
        }
        static void GetInput()
        {

            while (!aborted)
            {
                Console.ReadLine();
                if (!aborted)
                {
                    Console.WriteLine("Current guess: " + lastGuess);
                    Console.WriteLine("Current count: " + count);
                    StopWatchOutput();
                }
            }
            Console.WriteLine("Input thread aborted");

        }
        private static void BruteForce(object objString)
        {

            bool found = false;
            string guess = "";
            string password = objString.ToString();
            Console.WriteLine("You have entered: " + password);
            sw.Start();
            while (!found)
            {

                //Create a random password
                while (guess.Length != password.Length)
                {
                    int IDx = random.Next(characters.Length);
                    guess += characters[IDx];
                }
                if (guess == password)
                {
                    StopWatchOutput();
                    Console.WriteLine("After " + count + " moves, we found your password to be: " + guess);
                    found = true;
                }
                else
                {
                    count++;
                    lastGuess = guess;
                    guess = "";
                }

            }

            sw.Stop();
            Console.WriteLine("BruteForce thread aborted");
        }
    }
}
