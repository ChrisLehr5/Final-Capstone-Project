using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProject
{
    class Program
    {
        //*******************************************
        // Application Type: Console
        // Description: Text Based Adventure Game
        // Author: Christine Largent
        // Date Created: 4/22/19
        // Last Modified: 4/28/19
        //*******************************************


        static void Main(string[] args)
        {
            Console.CursorVisible = true;
            Console.CursorSize = 55;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WindowHeight = 30;
            Console.WindowWidth = 100;

            gameTitle();

        }

        public static void gameTitle()
        {
            string userSelection;

            Console.WriteLine("\t\t\tWelcome To The Golden Mystery Game");
            Console.WriteLine();
            Console.WriteLine("This text based adventure game follows your character as you attempt to solve the mystery.");
            Console.WriteLine("Choices that you make determine whether or not you progress in the game, or fall victim to");
            Console.WriteLine("the deadly mystery surrounding the gold.");
            Console.WriteLine();
            Console.WriteLine();
            Console.Title = "Gold";
            string title = @"
                            _.--.
                        _.-'_:-'||
                    _.-'_.-::::'||
               _.-:'_.-::::::'  ||
             .'`-.-:::::::'     ||
            /.'`;|:::::::'      ||_
           ||   ||::::::'     _.;._'-._
           ||   ||:::::'  _.-!oo @.!-._'-.
           \'.  ||:::::.-!()oo @!()@.-'_.|
            '.'-;|:.-'.&$@.& ()$%-'o.'\U||
              `>'-.!@%()@'@_%-'_.-o _.|'||
               ||-._'-.@.-'_.-' _.-o  |'||
               ||=[ '-._.-\U/.-'    o |'||
               || '-.]=|| |'|      o  |'||
               ||      || |'|        _| ';
               ||      || |'|    _.-'_.-'
               |'-._   || |'|_.-'_.-'
            jgs '-._'-.|| |' `_.-'
                    '-.||_/.-'"; //source:http://ascii.co.uk/art/treasure

            Console.Write(title);
            Console.WriteLine();
            Console.WriteLine("Would you like to play? Yes or No?");
            userSelection = Console.ReadLine().ToLower().Trim();

            if (userSelection == "yes")
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Newspaper Article Dated Six Months Ago:");
                Console.WriteLine("_______________________________________");
                Console.WriteLine();
                Console.WriteLine("Police have identified the man found floating in the Mill Lake last week");
                Console.WriteLine("as Robert Killingsworth, aged 41, the local vineyward owner.");
                Console.WriteLine();
                Console.WriteLine("Killingsworth's body was identified through fingerprints, said Detective Noall.");
                Console.WriteLine("An autopsy determined he died from blunt force tramua.");
                Console.WriteLine();
                Console.WriteLine("Detective Noall said Robert's wife Elizabeth reported her husband's disappearence");
                Console.WriteLine("to police after he failed to meet her in town for dinner.");
                Console.WriteLine("_______________________________________");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Press any key to begin");
                Console.ReadLine();
                Console.Clear();

                characterIntro();
            }
            else if (userSelection == "no")
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Get outta here then!");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Press any key to continue");
                Console.ReadLine();
                DisplayClosingScreen();
            }
            else
            {
                Console.WriteLine("I don't understand. Let's try again.");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Press any key to begin");
                Console.ReadLine();
                Console.Clear();
                gameTitle();
            }

        }

        public static void characterIntro()
        {
            Console.WriteLine("\t\t\tCharacter Introduction:");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Your name is Kathyrn Lawless. You are Elizabeth Killingsworth's best friend.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("She volunteers often at the library where you have been the head librarian");
            Console.WriteLine("for the last ten years. You are unmarried but have a pack of nieces and nephews, as well as 15 cats.");
            Console.WriteLine("You are also the resident historical expert.");
            Console.WriteLine();
            Console.WriteLine("One day you discover old letters in the library archive.");
            Console.WriteLine();
            Console.WriteLine("100 years ago, when the founder of the vineyard died, his heirs were unable to locate his fortune. ");
            Console.WriteLine("The founder had come from the gold boom out west to start the vineyard and had always claimed to");
            Console.WriteLine("have a portion of his fortune hidden on the estate.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Reading this gives you a chill.");
            Console.WriteLine();
            Console.WriteLine("Was Elizabeth aware of this history? Could this have anything to do with Roberts death?");
            Console.WriteLine("You receive a letter invitation to Elizabeths house the next day- this will be the perfect");
            Console.WriteLine("opportunity to discuss the mystery around the missing gold and her husbands death.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
            first();
        }

        public static void first()
        {
            Console.Clear();
            Console.WriteLine("\t\tAct One: Arrival");
            Console.WriteLine();
            Console.WriteLine("You arrive at the Killingsworth Vineyard");
            Console.WriteLine();
            Console.Title = "House";
            string title = @"
           ) )        /\
          =====      /  \
         _|___|_____/ __ \____________
        |::::::::::/ |  | \:::::::::::|
        |:::::::::/  ====  \::::::::::|
        |::::::::/__________\:::::::::|
        |_________|  ____  |__________|
         | ______ | / || \ | _______ |
         ||  |   || ====== ||   |   ||       ###
         ||--+---|| |    | ||---+---||      #o###
         ||__|___|| |   o| ||___|___||    #####o###
         |========| |____| |=========|   #o#\#|#/###
        (^^-^^^^^-|________|-^^^--^^^)    ###\|/#o#
       (,, , ,, ,/________\,,,, ,, ,)      # }|{  #
      ','',,,,' /__________\,,,',',;;        }|{

   ";//source: http://ascii.co.uk/art

            Console.WriteLine(title);
            Console.WriteLine("\t\tPress any key to continue");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("The sun is setting and you find yourself standing in the front hall of the main");
            Console.WriteLine("house on the Killingsworth farm.");
            Console.WriteLine();
            Console.WriteLine("The house is a grand old victorian- the sweeping double staircase leading upstairs,");
            Console.WriteLine("while rooms branch off to either sides. A large fireplace sits against the west wall, and");
            Console.WriteLine("an overstuffed bookcase is placed on the east wall,");
            Console.WriteLine();
            Console.WriteLine("Two strangers are within the hall with you. One is a glamorous looking woman and the other a middle aged man.");
            Console.WriteLine("Neither of them are familair to you but they seem to know each other, talking near the fireplace.");
            Console.WriteLine("When you walk into the room their conversation stops. They both watch you, waiting.");
            Console.WriteLine();
            Console.WriteLine("Elizabeth is not present- you wonder where she is, and why these strangers are here...");
            Console.WriteLine();
            Console.WriteLine("What do you do?");
            decision();
        }

        public static void decision()
        {
            string choice;
            string userResponse;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1: Look Around");
            Console.WriteLine("2: Go Upstairs");
            Console.WriteLine("3: Introduce yourself");
            Console.WriteLine("4: Check Inventory");
            Console.WriteLine();
            Console.WriteLine("Choice:  ");
            Console.WriteLine();
            choice = Console.ReadLine().ToLower().Trim();
            Console.Clear();

            switch (choice)
            {
                case "1":
                case "look around":
                case "look":
                    lookAround();
                    break;

                case "2":
                case "go upstairs":
                case "stairs":
                case "upstairs":
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Without a second glance to the man and woman you march up the stairs.");
                    Console.WriteLine("Elizabth is probably within her study, which you know is down the hall to the right.");
                    upstairs();
                    break;

                case "4":
                case "inventory":
                case "check inventory":
                case "check":
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("You are suddenly struck with urge to look through your purse.");
                    Console.WriteLine("You reach into the leather bag and pull out");
                    inventory();
                    break;

                case "3":
                case "introduce yourself":
                case "introduce":
                    Console.Clear();
                    Console.Title = "people";
                    string art = @"
|\_____/|     ////\
|/// \\\|    /// \\\
 |/O O\|     |/o o\|
 d  ^ .b     C  )  D    
  \\m//      | \_/ |
   \_/        \___/
 __ooo__    _/<|_|>\_
/_     _\  / |/\_/\| \
| \_v_/ | |    |\|    |
|| _/ _/\\| |  |\|  | |
||)    ( \| |  |\|  | |
||      \ | \\ |\|  | |
||  --  |  (())\_/  | |
((      |   |___|___|_|
 |______|   |   Y   |))
  |-||-|    |   |   |
  | || |    |   |   |
  | || |    |   |   |
  | || |    |___|___|prs
 /u\||/u\   /qp| |qp\
(_/\||/\_) (___/ \___)"; //source: https://www.asciiart.eu/people/couples
                    Console.Write(art);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Do you introduce yourself to the man or the woman?");
                    userResponse = Console.ReadLine().ToLower();

                    if (userResponse == "man")
                    {
                        introduceMan();
                    }
                    else if (userResponse == "woman")
                    {
                        introduceWoman();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("You look at the two and sputter something nervously.");
                        Console.WriteLine("They both look at you, puzzled and unable to decipher your query.");
                        Console.WriteLine();
                        Console.WriteLine($"{userResponse}, really? Your face heats with embarrassment.");
                        Console.WriteLine("Ah well. You'll try again later, once your nerves have calmed.");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadLine();
                    }
                    decision();
                    break;

                default:
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("I don't understand that command");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Press any key to try again");
                    Console.ReadLine();
                    decision();
                    break;
            }

        }

        public static void lookAround()
        {
            string userResponse;

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("You look around the front hall- part of the original house, this area is quite grand.");
            Console.WriteLine("Wooden walls that have old fashioned painting of prominent family members.");
            Console.WriteLine("Thanks to the large fireplace and the cozy fire this area is warm.");
            Console.WriteLine();
            Console.Title = "Fireplace";
            string title = @"
  ______________________________________________________________________
 |: : : : : : : : : : : : : :|____|____|____|: : : : : : : : : : : : : :|
 | : : : : : : : : : : : : : |__|____|____|_| : : : : : : : : : : : : : |
 |: : : : : : : : : : : : : :|____|____|____|: : : : : : : : : : : : : :|
 | : : : : : :_: : : : : : : |__|____|____|_| : : : : : : :_: : : : : : |
 |: : : : : :/_\: : : : : : :|____|____|____|: : : : : : :/_\: : : : : :|
 | : : : : : :|: : : : : : :/___|____|____|__\: : : : : : :|: : : : : : |
 |: : : : : :[=]: : : : : :/_|____|____|____|_\: : : : : :[=]: : : : : :|
 | : : : : : :!: : : : : :/_____|____|____|____\: : : : : :!: : : : : : |
 |=========.-----.=======/___|____|____|____|___\=======.-----.=========|
 |         |     |      /_|___|     ) (    |___|_\      |     |         |
 |   .;.   |  *  |      |___|_| o )( ) ) o |_|___|      |  *  |   .;.   |
 | _;(;);_ |     |      |_|___| | ( ) )( | |___|_|      |     | _;(;);_ |
 |__|;;;|__()_____()____|___|_|/!\@@@@@@/!\|_|___|____()_____()__|;;;|__|      lc
    | ; |  ||_____||  /____________________________\  ||_____||  | ; |
           ||     ||  |____________________________|  ||     ||
          `====================================================`
         `======================================================`
        `========================================================` "; //source:http://ascii.co.uk/art/fireplac

            Console.Write(title);
            Console.WriteLine();
            Console.WriteLine("Would you like to investigate further?");
            userResponse = Console.ReadLine().ToLower();

            if (userResponse == "yes")
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Looking closer you notice that several places on the walls are discolored.");
                Console.WriteLine("Has Elizabth been forced to sell off antiques for money?");
                Console.WriteLine();
                Console.WriteLine("On painting in particular seems to leer at you. A portrait of man wearing");
                Console.WriteLine("a severely tailored suit and a top hat. You swear that the eyes glitter");
                Console.WriteLine("almost as if it was alive...");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Creeped out you move closer, slowly as to not alarm anyone. Suddenly you");
                Console.WriteLine("thrust your finger out and hit the painting in the eyeball. The -warm- squishy");
                Console.WriteLine("eyeball. It screams in pain, as you turn and flee the hall in terror.");
                Console.WriteLine();
                Console.WriteLine("Press any key to continue");
                Console.ReadLine();
                gameOver();

            }
            else if (userResponse == "no")
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("While you are bored, you aren't bored enough to go looking around.");
                Console.WriteLine("You decide to stick close to the fire to keep warm. After all Elizabeth");
                Console.WriteLine("may appear if you wander away, and you don't want to chance it.");
                Console.WriteLine();
                Console.WriteLine("Press any key to continue");
                Console.ReadLine();
                second();
            }
            else
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("You aren't a very good detective, are you?");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Press any key to try again");
                Console.ReadLine();
                second();
            }
        }

        public static void second()
        {
            string locationChoice;

            Console.Clear();
            Console.WriteLine("\t\t\tAct 2");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("A quarter of an hour has passed. A somber mood lingers in the air.");
            Console.WriteLine("You feel ill at ease. Where is Elizabeth? She is typically very prompt.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("The man, Franklin, speaks up, suggesting that you all search to find Elizabeth.");
            Console.WriteLine("A fine idea, you think. Certainly better than waiting here.");
            Console.WriteLine();
            Console.WriteLine("Where would you like to go?");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1: Garden");
            Console.WriteLine("2: Cellar");
            Console.WriteLine("3: Upstairs");
            locationChoice = Console.ReadLine().ToLower();
            Console.WriteLine();

            switch (locationChoice)
            {
                case "1":
                case "garden":
                case "outside":
                    garden();
                    break;

                case "2":
                case "cellar":
                case "basement":
                case "downstairs":
                    cellar();
                    break;

                case "3":
                case "upstairs":
                case "go upstairs":
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Elizabth may be upstairs in her study. She is known to get lost within books time to time.");
                    Console.WriteLine("Perhaps she simply lost track of the time?");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("You decide to go check alone, heading up the sweeping staircase towards her study.");
                    upstairs();
                    break;

                default:
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("I don't understand that command");
                    Console.WriteLine("Please try again");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    second();
                    break;
            }

            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }

        public static void introduceWoman()
        {
            string userResponse;

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("You walk over the woman. She looks at you with interest.");
            Console.WriteLine("Dressed glamourously she seems to have dropped in from a movie set- the dress");
            Console.WriteLine("she is wearing looks expensive but far too thin for the approaching fall.");
            Console.WriteLine();
            Console.WriteLine("\"Hello\", she says, \"My name is Dr. Sally Forth- I am Elizabths new neighbor\"");
            Console.WriteLine("\"I came over to talk to Elizabeth about a party I'm hosting next week\"");
            Console.WriteLine();
            Console.WriteLine("She flicks her long ash blonde hair away from her face.");
            Console.WriteLine();
            Console.WriteLine("\"I simply must have some overflow parking. Her empty field would be perfect!\"");
            Console.WriteLine("\"After all\" she continues tactlessly, \"Now that Robert is dead she won't be needing");
            Console.WriteLine("it. I can only imagine the offers on a vineyard this size!\"");
            Console.WriteLine();

            Console.WriteLine("Make an insight check?");
            Console.WriteLine("Yes, or No?");
            userResponse = Console.ReadLine().ToLower();

            if (userResponse == "yes")
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("You don't get the feeling that Elizabeth knows this woman well.");
                Console.WriteLine("She speaks of her as a casual acquantience, not a close friend.");
                Console.WriteLine("And after her comment about Robert...Well, perhaps she is just rather blunt.");
                Console.WriteLine();
                Console.WriteLine("You wonder why Elizabth agreed to see her tonight of all times....");
                Console.WriteLine();
                Console.WriteLine("Press any key to continue.");
                Console.ReadLine();
            }
            else if (userResponse == "no")
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("You aren't very interested in scrutinizing the woman.");
                Console.WriteLine("Everything about her seems to grate on your nerves.");
                Console.WriteLine("Besides, you are more concerned about the whereabouts of Elizabeth.");
                Console.WriteLine();
                Console.WriteLine("Press any key to continue.");
                Console.ReadLine();
            }
            else
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("You aren't very interested in this woman,");
                Console.WriteLine("judging from the lack of a coherent answer.");
                Console.WriteLine();
                Console.WriteLine($"{userResponse} indeed!");
                Console.WriteLine("Press any key to continue.");
                Console.ReadLine();
            }
            decision();
        }

        public static void cellar()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Familiar with the house, you know the cellar is located through a pantry door.");
            Console.WriteLine("Perhaps Elizabth went down to get a bottle of wine for her guests?");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("As you approach the door the man yells out \"I'm coming too\"!");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("He doesn't give you the option of declining. Annoyance surges through you,");
            Console.WriteLine("but not enough to argue about it. You shrug your shoulders. He can tag along if he wishes.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();
            Console.Clear();
            Console.Title = "Cellar";
            string title = @"
          ______________
        |\ ___________ /|
        | |  _ _ _ _  | |
        | | | | | | | | |
        | | |-+-+-+-| | |
        | | |-+-+=+%| | |
        | | |_|_|_|_| | |
        | |    ___    | |
        | |   [___] ()| |
        
        | |         ||| |
        | |         ()| |
        | |           | |
        | |           | |
        | |           | |
        |_|___________|_| ";//source:http://ascii.co.uk/art/doors


            Console.Write(title);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("In the cellar you learn that Franklin is a gossip.");
            Console.WriteLine("He advises that Dr. Forth is a famous shrink turned author. She has been blacklisted medically");
            Console.WriteLine("for writing about her famous patients.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("While this is interesting info to tuck away, you are more concerned about");
            Console.WriteLine("the whereabouts of Elizabth. You nod and mumble while investiagting.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Investigating turned nothing up in the cellar except dust and musty storage boxes.");
            Console.WriteLine("When you come back up the main thing on your mind is getting back to the fire, but");
            Console.WriteLine("Franklin frowns and looks around.");
            Console.WriteLine();
            Console.WriteLine("\"Where has Dr. Forth gone\"?");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();
            youWin();
        }

        public static void upstairs()
        {
            Random rnd = new Random();
            string[] secOptions = { "The study is dark. Fumbling for the lightswitch something alerts you- you are not alone in the dark!", "You open the door and hear something...someone...breathing heavily in the dark...", "Standing outside the door you get a bad feeling as you reach towards the knob..." };
            int randomNumber = rnd.Next(0, 3);
            string secText = secOptions[randomNumber];

            string secChoice;

            Console.WriteLine(secText);
            Console.WriteLine("Do you try to escape? Yes or no?");
            Console.WriteLine();
            secChoice = Console.ReadLine().ToLower();

            if (secChoice == "yes" || secChoice == "y")
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("You quickly pull back, escape the only thing on your mind!");
                Console.WriteLine("Not looking back you turn and flee towards the main hall!");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Press any key to continue.");
                Console.ReadLine();
                youWin();
            }
            else if (secChoice == "no" || secChoice == "n")
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Thinking to be brave, you attempt to carry on.");
                Console.WriteLine("But you have been distracted by the presence in front of you!");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("A sharp blow hits the back of your head, and you sink into unconsciousness.");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("\"Elizabeth...where...are...you...\"?");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Press any key to continue");
                Console.ReadLine();
                gameOver();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($"I know your distracted but {secChoice}? Really!?");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Please try again");
                second();
            }
        }

        public static void garden()
        {
            bool agree = true;
            string companionChoice;
            string userResponse;

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("You have decided to go out to the garden.");
            Console.WriteLine("Maybe Elizabeth is outside and has simply lost track of time.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("The woman speaks up suddenly.");
            Console.WriteLine("\"I would very much like to come with you\".");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("She seemed to know Franklin, you wonder why she wouldn't want to search with him...");
            Console.WriteLine("Do you allow the woman to come? Yes, or No?");
            companionChoice = Console.ReadLine().ToLower();
            Console.WriteLine();

            if (companionChoice == "yes")
            {
                agree = true;

                do
                {
                    Console.Clear();
                    Console.Title = "Roses";
                    string title = @"
                _(_)_                          wWWWw   _
      @@@@       (_)@(_)   vVVVv     _     @@@@  (___) _(_)_
     @@()@@ wWWWw  (_)\    (___)   _(_)_  @@()@@   Y  (_)@(_)
      @@@@  (___)     `|/    Y    (_)@(_)  @@@@   \|/   (_)\
       /      Y       \|    \|/    /(_)    \|      |/      |
    \ |     \ |/       | / \ | /  \|/       |/    \|      \|/
jgs \\|//   \\|///  \\\|//\\\|/// \|///  \\\|//  \\|//  \\\|//
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^"; //source: http://ascii.co.uk/art

                    Console.Write(title);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("The woman beams at you. Gathering up her coat she follows you outside into the garden.");
                    Console.WriteLine();
                    Console.WriteLine("Elizabeth is very keen on her gardening and has transfromed the area");
                    Console.WriteLine("into a patchwork of roses and shrubs. The season is past the peak but some blooms remain.");
                    Console.WriteLine();
                    Console.WriteLine("The woman, Dr. Forth, chatters while you investigate the garden.");
                    Console.WriteLine("You nod absently on occasion, while tuning her out.");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("You come before the entrance to the hedge maze.");
                    Console.WriteLine();
                    Console.WriteLine("Do you want to enter the maze?");
                    Console.WriteLine("Yes or No?");
                    userResponse = Console.ReadLine().ToLower();
                    Console.WriteLine();

                    if (userResponse == "yes")
                    {
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("\"Well I am not going in there. Good luck\"!");
                        Console.WriteLine("Dr. Forth leaves and heads back towards the house. You scoff at her lack of resolution.");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Several hours later you are cold and regretful of your choice.");
                        Console.WriteLine();
                        Console.WriteLine("You have tried yelling but nobody seems to hear your cries for help.");
                        Console.WriteLine("Where could everyone be?");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadLine();
                        gameOver();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("After some more fruitless searching in the garden you admit defeat- Elizabeth is not out here.");
                        Console.WriteLine("You both head back to the house.");
                        Console.WriteLine();
                        Console.WriteLine("\"I'll be so happy to get back into the warmth and...\" Dr. Forth stops upon opening the door.");
                        Console.WriteLine("The scene you walk into is chaos. The main hall is a mess- it appears that a struggle");
                        Console.WriteLine("has taken place. The bookcase has been overturned, and a chair near the fire is broken.");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("\"Where is Franklin?!\" Dr Forth exclaims.");
                        Console.WriteLine("Neither of you see him in the hall. Where could he be? Was Elizabth involved in this?");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadLine();
                        youWin();
                    }
                } while (agree);
            }

            else if (companionChoice == "no")
            {
                agree = false;
                do
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("The woman glares at you before turning around to face the fire.");
                    Console.WriteLine("Unswayed by the rebuff you head towards the garden.");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("After some more fruitless searching in the garden you admit defeat- Elizabeth is not out here.");
                    Console.WriteLine("You head back to the house.");
                    Console.WriteLine();
                    Console.WriteLine("You mutter \"I'll be so happy to get back into the warmth an\"-");
                    Console.WriteLine("The scene before you stops you short. The main hall is a mess- it appears that a struggle");
                    Console.WriteLine("has taken place. The bookcase has been overturned, and a chair is broken near the fire");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Where could Franklin be? Or Dr. Forth?");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadLine();
                    youWin();

                } while (!agree);
            }
            else
            {
                third();
            }
        }

        public static void introduceMan()
        {
            string userResponse;

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("You walk over to the man. He looks at you with interest.");
            Console.WriteLine();
            Console.WriteLine("\"My name is Franklin!- I am a friend of Elizabeth- and Vicki.\"");
            Console.WriteLine();
            Console.WriteLine("\"I know Elizabeth from her old hometown. Last we spoke she invited me to stop by.\"");
            Console.WriteLine("\"I'm in town on vacation, so here I am!\"");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Make an insight check?");
            Console.WriteLine("Yes, or No?");
            userResponse = Console.ReadLine().ToLower();

            if (userResponse == "yes")
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("You get the feeling that Franklin knows Elizabeth well, although you find it odd");
                Console.WriteLine("that not once in ten years she has ever mentioned him.");
                Console.WriteLine("Maybe an old boyfriend?");
                Console.WriteLine("And of all the times to stop, you wonder why so close after her husbands death.");
                Console.WriteLine("You do not recall seeing him at Roberts funeral.");
                Console.WriteLine();
                Console.WriteLine("...Wait a minute- who is Vicki?");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Press any key to continue.");
                Console.ReadLine();
            }
            else if (userResponse == "no")
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Franklin seems open and without guile.");
                Console.WriteLine("You don't bother pondering it further and chalk him up as a generic nice guy.");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Press any key to continue.");
                Console.ReadLine();
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"{userResponse}...? Franklin looks at you puzzled.");
            }
            decision();
        }

        public static void third()
        {
            int path;

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Deciding not to answer her question either way, you grab your jacket and make your way to the door.");
            Console.WriteLine("You go outside towards the garden.");
            Console.WriteLine();
            Console.WriteLine("Elizabeth is very keen on her gardening and has transfromed the area into a classic English garden.");
            Console.WriteLine("The season is past the peak but some blooms remain.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("The path near the hedge maze splits into two paths, one leading behind the house and the other around");
            Console.WriteLine("a bend. Small markers are next to the split - the left path numbered 10 and the right 25.");
            Console.WriteLine("You seem to recall one of these leading towards an old well.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Which path will you take? 10 or 25?");
            Console.Write("Path: ");
            int.TryParse(Console.ReadLine(), out path);

            while (path < 20)
            {
                Console.Clear();
                Console.WriteLine("You see a well ahead.");
                Console.Title = "Well";
                string title = @"      
               .'/\'.
             .'-/__\-'.
           .'--/____\--'.
         .'--./______\.--'.
       .'--../________\..--'.
     .'--.._/__________\_..--'.
   .'--..__/____________\__..--'.
 .'--..___/______________\___..--'.
'========'================'========'
      [_|__]            [_|__]
     =[__|_]=====""=====[__|_]==.
      [_|__]     '|     [_|__]  |
      [__|_]     |'     [__|_]  |
      [_|__]  .--JL--.  [_|__]  '===O
      [__|_]   \====/   [__|_]
      [_|__]_.-| .; |-._[_|__]
      [__|_]'._ \__/(_.'[__|_]
      [.-._]            [_.-.]
      [_.-.'--..____..--'.-._]
 (o)  [(_.'   .-.     .-.'._)\ (o)
(\'/) [  .-. (_.'.-. (_.' .-.](\'/)
   ;: [ (_.'.-. (_.' .-. (_.'| ;:'
;:    [ .-. '._) .-. '._).-. ]   ;:.
  ";// source: http://ascii.co.uk/art
                Console.Write(title);
                Console.WriteLine("\t\tPress any key to continue.");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Ah yes, this is the path towards the well.");
                Console.WriteLine("As you get closer you suddenly recall that Elizabeth cautioned going near the old well.");
                Console.WriteLine("Something about...unstable ground? Good thing you are paying attent-");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Press any key to continue");
                Console.ReadLine();
                gameOver();
            }

            while (path > 20)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("As you walk along the path suddenly you trip upon a rock!");
                Console.WriteLine();
                Console.WriteLine("Cursing the diminishing light you look down to kick it from your path.");
                Console.WriteLine("As you start to do so however you notice that the rock...appears to be wet.");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Getting closer you realize that the rock smells like wine. And a long ash blonde hair is beneath it...");
                Console.WriteLine("Has someone been in the garden, drinking perhaps?");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Press any key to continue");
                Console.ReadLine();
                youWin();
            }
        }


        public static void gameOver()
        {
            Console.Clear();
            Console.Title = "Dead";
            string title = @"
     .... NO! ...                  ... MNO! ...
   ..... MNO!! ...................... MNNOO! ...
 ..... MMNO! ......................... MNNOO!! .
..... MNOONNOO!   MMMMMMMMMMPPPOII!   MNNO!!!! .
 ... !O! NNO! MMMMMMMMMMMMMPPPOOOII!! NO! ....
    ...... ! MMMMMMMMMMMMMPPPPOOOOIII! ! ...
   ........ MMMMMMMMMMMMPPPPPOOOOOOII!! .....
   ........ MMMMMOOOOOOPPPPPPPPOOOOMII! ...
    ....... MMMMM..    OPPMMP    .,OMI! ....
     ...... MMMM::   o.,OPMP,.o   ::I!! ...
         .... NNM:::.,,OOPM!P,.::::!! ....
          .. MMNNNNNOOOOPMO!!IIPPO!!O! .....
         ... MMMMMNNNNOO:!!:!!IPPPPOO! ....
           .. MMMMMNNOOMMNNIIIPPPOO!! ......
          ...... MMMONNMMNNNIIIOO!..........
       ....... MN MOMMMNNNIIIIIO! OO ..........
    ......... MNO! IiiiiiiiiiiiI OOOO ...........
  ...... NNN.MNO! . O!!!!!!!!!O . OONO NO! ........
   .... MNNNNNO! ...OOOOOOOOOOO .  MMNNON!........
   ...... MNNNNO! .. PPPPPPPPP .. MMNON!........
      ...... OO! ................. ON! .......
         ................................

"; //source: http://ascii.co.uk/art
            Console.Write(title);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\tBetter luck next time!");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key to try again");
            Console.ReadLine();
            Console.Clear();
            gameTitle();
        }

        public static void youWin()
        {
            Console.Clear();
            Console.Title = "survive";
            string title = @"



            ^^                   @@@@@@@@@
       ^^       ^^            @@@@@@@@@@@@@@@
                            @@@@@@@@@@@@@@@@@@              ^^
                           @@@@@@@@@@@@@@@@@@@@
 ~~~~ ~~ ~~~~~ ~~~~~~~~ ~~ &&&&&&&&&&&&&&&&&&&& ~~~~~~~ ~~~~~~~~~~~ ~~~
 ~         ~~   ~  ~       ~~~~~~~~~~~~~~~~~~~~ ~       ~~     ~~ ~
   ~      ~~      ~~ ~~ ~~  ~~~~~~~~~~~~~ ~~~~  ~     ~~~    ~ ~~~  ~ ~~
   ~  ~~     ~         ~      ~~~~~~  ~~ ~~~       ~~ ~ ~~  ~~ ~
 ~  ~       ~ ~      ~           ~~ ~~~~~~  ~      ~~  ~             ~~
       ~             ~        ~      ~      ~~   ~             ~
pjb";// source:http://ascii.co.uk/art/sunset

            Console.Write(title);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\tYou survive to continue solving the mystery...");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
            gameTitle();
        }

        static void inventory()
        {
            Random rnd = new Random();
            string[] secOptions = { "a piece of lint.", "a letter that Elizabth wrote you, inviting you to her house tonight.", "an old piece of candy. Yum!", "that book you forgot to turn in." };
            int randomNumber = rnd.Next(0, 4);
            string secText = secOptions[randomNumber];

            string secChoice;

            Console.WriteLine(secText);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Do you continue digging in your purse? Yes or no?");
            Console.WriteLine();
            secChoice = Console.ReadLine().ToLower();

            if (secChoice == "yes" || secChoice == "y")
            {
                distracted();
            }
            else if (secChoice == "no" || secChoice == "n")
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("I don't have time for this right now!");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Press any key to continue");
                Console.ReadLine();
                decision();
            }
            else
            {
                Console.WriteLine("I don't understand what you mean.");
                Console.WriteLine("You drop your purse in exasperation.");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Press any key to continue");
                Console.ReadLine();
                second();
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
            second();
        }

        public static void distracted()
        {

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("You are distracted by checking your inventory and forget where you are.");
            Console.WriteLine("Looking up suddenly you realize that both the man and woman are gone. A shadow looms from behind you.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
            gameOver();
        }

        static void DisplayClosingScreen()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\t\tThank You For Playing!");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
            Environment.Exit(0);
        }
    }
}
