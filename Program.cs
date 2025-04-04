using System;
using System.IO;
using System.Media;
using System.Threading;

namespace Chatbot
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display the ASCII art logo
            DisplayAsciiArt();

            // Play the voice greeting
            PlayGreeting();

            // Display the Welcome Message
            DisplayWelcomeMessage();

            // Start the interaction loop
            StartInteractionLoop();
        }

        static void DisplayAsciiArt()
        {
            Console.ForegroundColor = ConsoleColor.Yellow; // Set ASCII art color to YELLOW
            string asciiArt = @"
▐▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▌
▐                                                                                                                                                                             ▌
▐     _______      ____     __  _______       .-''-.  .-------.                     .-'''-.     .-''-.      _______     ___    _ .-------.   .-./`) ,---------.  ____     __  ▌
▐    /   __  \     \   \   /  /\  ____  \   .'_ _   \ |  _ _   \                   / _     \  .'_ _   \    /   __  \  .'   |  | ||  _ _   \  \ .-.')\          \ \   \   /  / ▌
▐   | ,_/  \__)     \  _. /  ' | |    \ |  / ( ` )   '| ( ' )  |                  (`' )/`--' / ( ` )   '  | ,_/  \__) |   .'  | || ( ' )  |  / `-' \ `--.  ,---'  \  _. /  '  ▌
▐ ,-./  )            _( )_ .'  | |____/ / . (_ o _)  ||(_ o _) /     _ _    _ _  (_ o _).   . (_ o _)  |,-./  )       .'  '_  | ||(_ o _) /   `-'`""`    |   \      _( )_ .'   ▌
▐ \  '_ '`)      ___(_ o _)'   |   _ _ '. |  (_,_)___|| (_,_).' __  ( ' )--( ' )  (_,_). '. |  (_,_)___|\  '_ '`)     '   ( \.-.|| (_,_).' __ .---.     :_ _:  ___(_ o _)'    ▌
▐  > (_)  )  __ |   |(_,_)'    |  ( ' )  \'  \   .---.|  |\ \  |  |(_{;}_)(_{;}_).---.  \  :'  \   .---. > (_)  )  __ ' (`. _` /||  |\ \  |  ||   |     (_I_) |   |(_,_)'     ▌
▐ (  .  .-'_/  )|   `-'  /     | (_{;}_) | \  `-'    /|  | \ `'   / (_,_)--(_,_) \    `-'  | \  `-'    /(  .  .-'_/  )| (_ (_) _)|  | \ `'   /|   |    (_(=)_)|   `-'  /      ▌
▐  `-'`-'     /  \      /      |  (_,_)  /  \       / |  |  \    /                \       /   \       /  `-'`-'     /  \ /  . \ /|  |  \    / |   |     (_I_)  \      /       ▌
▐    `._____.'    `-..-'       /_______.'    `'-..-'  ''-'   `'-'                  `-...-'     `'-..-'     `._____.'    ``-'`-'' ''-'   `'-'  '---'     '---'   `-..-'        ▌
▐    ____    .--.      .--.   ____    .-------.        .-''-.  ,---.   .--.    .-''-.     .-'''-.    .-'''-.         _______       ,-----.  ,---------.                       ▌
▐  .'  __ `. |  |_     |  | .'  __ `. |  _ _   \     .'_ _   \ |    \  |  |  .'_ _   \   / _     \  / _     \       \  ____  \   .'  .-,  '.\          \                      ▌
▐ /   '  \  \| _( )_   |  |/   '  \  \| ( ' )  |    / ( ` )   '|  ,  \ |  | / ( ` )   ' (`' )/`--' (`' )/`--'       | |    \ |  / ,-.|  \ _ \`--.  ,---'                      ▌
▐ |___|  /  ||(_ o _)  |  ||___|  /  ||(_ o _) /   . (_ o _)  ||  |\_ \|  |. (_ o _)  |(_ o _).   (_ o _).          | |____/ / ;  \  '_ /  | :  |   \                         ▌
▐    _.-`   || (_,_) \ |  |   _.-`   || (_,_).' __ |  (_,_)___||  _( )_\  ||  (_,_)___| (_,_). '.  (_,_). '.        |   _ _ '. |  _`,/ \ _/  |  :_ _:                         ▌
▐ .'   _    ||  |/    \|  |.'   _    ||  |\ \  |  |'  \   .---.| (_ o _)  |'  \   .---..---.  \  :.---.  \  :       |  ( ' )  \: (  '\_/ \   ;  (_I_)                         ▌
▐ |  _( )_  ||  '  /\  `  ||  _( )_  ||  | \ `'   / \  `-'    /|  (_,_)\  | \  `-'    /\    `-'  |\    `-'  |       | (_{;}_) | \ `""/  \  ) /  (_(=)_)                        ▌
▐ \ (_ o _) /|    /  \    |\ (_ o _) /|  |  \    /   \       / |  |    |  |  \       /  \       /  \       /        |  (_,_)  /  '. \_/``"".'    (_I_)                         ▌
▐  '.(_,_).' `---'    `---` '.(_,_).' ''-'   `'-'     `'-..-'  '--'    '--'   `'-..-'    `-...-'    `-...-'         /_______.'     '-----'      '---'                         ▌
▐                                                                                                                                                                             ▌
▐▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▌
            ";
            Console.WriteLine(asciiArt);
        }

        static void PlayGreeting()
        {
            try
            {
                string audioFilePath = @"C:\Users\RC_Student_lab\source\repos\Chatbot\audio\Welcoming.wav";
                using (SoundPlayer player = new SoundPlayer(audioFilePath))
                {
                    player.PlaySync();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while trying to play the greeting: " + ex.Message);
            }
        }

        static void DisplayWelcomeMessage()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("*------------------------------------------------*");
            Console.WriteLine("*  Welcome to the Cybersecurity Awareness Bot :) *");
            Console.WriteLine("*------------------------------------------------*");
            Console.ResetColor();

            // Greet the user
            GreetUser();
        }

        // Fixed: Ensure `GreetUser` is static
        static void GreetUser()
        {
            Console.Write("Hello, hi there! What's your name? ");
            string userName = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Welcome, {userName}! I'm here to help you stay safe online.");
            Console.ResetColor();
        }

        static void StartInteractionLoop()
        {
            Console.WriteLine("\n" + new string('-', 50));
            Console.WriteLine("Feel free to ask me anything about cybersecurity!");
            Console.WriteLine(new string('-', 50));


            // Dictionary to hold keywords and their corresponding responses
            Dictionary<string, string> responses = new Dictionary<string, string>
            {
                { "password", "Always use strong passwords, change them regularly, and never share them with anyone." },
                { "phishing", "Be cautious of emails or messages that ask for personal information. Always verify the source." },
                { "browsing", "Use secure websites (https), avoid clicking on suspicious links, and keep your browser updated." },
                { "virus", "Make sure to have antivirus software installed and keep it updated." },
                { "malware", "Avoid downloading software from untrusted sources to prevent malware infections." },
                { "secure", "Always use two-factor authentication when available to enhance your account security." },
                { "safety", "Stay informed about the latest cybersecurity threats and best practices." }
            };


            while (true)
            {
                Console.Write("You: ");
                string userInput = Console.ReadLine().ToLower();

                // Check for keywords in user input
                bool foundResponse = false;
                string foundKeyword = string.Empty;

                foreach (var entry in responses)
                {
                    if (userInput.Contains(entry.Key))
                    {
                        foundResponse = true;
                        foundKeyword = entry.Key; // Store the found keyword
                        TypeWriter($"Bot: {entry.Value}");
                        break; // Exit the loop once a response is found
                    }
                }

                if (!foundResponse)
                {
                    TypeWriter("Bot: I'm sorry, I didn't understand that. I cannot help with that question at the moment.");
                    TypeWriter("Bot: Would you like to exit the program? (yes/no)");
                    string exitResponse = Console.ReadLine().ToLower();
                    if (exitResponse == "yes")
                    {
                        TypeWriter("Thank you for chatting! Stay safe online.");
                        return; // Exit the loop
                    }
                    else
                    {
                        TypeWriter("Bot: Please feel free to ask about cybersecurity topics like password safety, phishing, secure, malware, virus or safe browsing.");
                    }
                }
                else
                {
                    TypeWriter("Bot: Was that helpful? (yes/no)");
                    string feedback = Console.ReadLine().ToLower();
                    if (feedback == "no")
                    {
                        TypeWriter("Bot: I'm sorry! Please ask your question again or provide more details.");
                    }
                }
            }
        }


        static void TypeWriter(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red; // Set bot response color to RED
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(50);
            }
            Console.WriteLine();
        }
    }
}

