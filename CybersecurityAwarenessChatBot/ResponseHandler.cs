//*************************************************************
// Part1_POE_PROG6221_ST10446545
// ST10446545@vcconnect.edu.za
//*************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//----------------------------------------------------------------------------------------------------------------------------------------
namespace CybersecurityAwarenessChatBot
{
    class ResponseHandler // This class handles the chatbot's responses based on user input
    {
        public static void Respond(string question) // Main method to handle the response logic
        {
            // Convert question to lowercase for case-insensitive comparison
            string q = question.ToLower();

            // Responds to questions about the bot's well-being
            if (q.Contains("how") && q.Contains("you"))
            {
                Console.WriteLine("As your personal security assistant I'm running smoothly. Thanks!");
            }
            // Responds to questions about the bot's purpose or functionality
            else if (q.Contains("purpose") || q.Contains("what do you do") || q.Contains("function"))
            {
                Console.WriteLine("I’m here to assist you in staying safe online by educating you about cybersecurity.");
            }
            // Responds to general security-related questions
            else if (q.Contains("ask") || q.Contains("help"))
            {
                Console.WriteLine("You can ask about password safety, phishing, or safe browsing.");
            }
            // Responds to password-related questions
            else if (q.Contains("password"))
            {
                Console.WriteLine("When creating passwords, opt for long ones that consist of letters, numbers, and special characters. Avoid using the same password for multiple accounts.");
            }
            // Responds to phishing-related questions
            else if (q.Contains("phishing"))
            {
                Console.WriteLine("Phishing occurs when scammers deceive you into providing personal information through fraudulent messages or websites.");
            }
            // Responds to questions about safe internet browsing
            else if (q.Contains("browse") || q.Contains("internet") || q.Contains("browsing"))
            {
                Console.WriteLine("Only browse secure websites (those starting with https), avoid clicking on questionable links, and ensure you have antivirus software installed.");
            }
            // Displays available commands if the user asks for a list or options
            else if (q.Contains("list") || q.Contains("options") || q.Contains("commands"))  
            {
                ListCommands(); // Call method to list possible commands
            }
            else
            {
                Console.WriteLine("Hmm, Seems like I've run into a problem. Try asking something else."); // Response for unrecognized input
            }
        }
        //----------------------------------------------------------------------------------------------------------------------------------------
        public static void ListCommands()  // Method to display available chatbot commands
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nHey there, here are some things you can ask me:");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("1. How are you?");
            Console.WriteLine("2. What’s your purpose?");
            Console.WriteLine("3. What can I ask you about?");
            Console.WriteLine("4. Tell me about password safety");
            Console.WriteLine("5. What is phishing?");
            Console.WriteLine("6. How do I browse safely?");
            Console.WriteLine("7. Help");
            Console.WriteLine("--------------------------------------");
            Console.ResetColor();
        }
    }
}
//--------------------------------------------------------------- End of File --------------------------------------------------------------------

// Reference List
// https://chatgpt.com/share/680940de-8fa0-8008-894a-ae1f999cb223 (Ln22, asked chat for Simple Keyword Matching for user flexibility)