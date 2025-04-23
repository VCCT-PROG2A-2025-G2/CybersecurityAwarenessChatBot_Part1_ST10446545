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
    class AsciiArt  // This class handles the display of ASCII art for branding or visual enhancement
    {
        public static void Display() // Static method to display ASCII art in the console
        {
            Console.ForegroundColor = ConsoleColor.Cyan; // Set the text color to Cyan for visual appeal

            // Output stylized ASCII art text
            Console.WriteLine(@" 
  ______   ______  _____ ____    ____   ___ _____ 
 / ___\ \ / / __ )| ____|  _ \  | __ ) / _ \_   _|
| |    \ V /|  _ \|  _| | |_) | |  _ \| | | || |  
| |___  | | | |_) | |___|  _ <  | |_) | |_| || |  
 \____| |_| |____/|_____|_| \_\ |____/ \___/ |_|           
");
            Console.ResetColor();
        }
    }
}
//--------------------------------------------------------------- End of File --------------------------------------------------------------------


// Reference List
// https://www.asciiart.eu/text-to-ascii-art (Ln21, Used this website to create custom ascii art)