using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HEX;

namespace HexNameSpace
{
    public partial class HexInterface : Form
    {
        public HexInterface()
        {
            InitializeComponent();
        }

        // Create Method for MouseHover on HexInterface Form
        // Declare hexHelp for ToolTip display
        // Create hexHelp variable and populate with help message
        private void HexInterface_MouseHover(object sender, EventArgs e)
        {
            ToolTip hexHelp;
            hexHelp = new ToolTip();
            hexHelp.ShowAlways = true;
            hexHelp.SetToolTip(HexInterface.ActiveForm, "Click Here For A Good Time!");
        }

        // Create Method for MouseClick on hexInterface Form
        // Make hextText TextBox, hexButton Button and closeButton Button visible
        // Select hexButton Button
        private void HexInterface_MouseClick(object sender, MouseEventArgs e)
        {
            hexText.Visible = true;
            hexButton.Visible = true;
            helpButton.Visible = true;
            closeButton.Visible = true;
            hexButton.Select();
        }

        // Create Method for KeyPress on HexInterface Form
        // Make hextText TextBox and hexButton Button invisible
        private void HexInterface_KeyPress(object sender, KeyPressEventArgs e)
        {
            hexText.Visible = false;
            hexButton.Visible = false;
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            hexAbout aboutBox = new hexAbout();
            aboutBox.ShowDialog();
        }
        // Create Method for highlighting hexButton Button when mouse hovers over it
        // Change hexButton BackColour to ButtonHighlight
        private void hexButton_Enter(object sender, EventArgs e)
        {
            hexButton.BackColor = SystemColors.ButtonHighlight;
        }

        // Create Method for highlighting hexButton Button when mouse hovers over it
        // Change hexButton BackColour to ButtonFace
        private void hexButton_Leave(object sender, EventArgs e)
        {
            hexButton.BackColor = SystemColors.ButtonFace;
        }

        // Create Method for highlighting closeButton Button when mouse hovers over it
        // Change closeButton BackColour to ButtonHighlight
        private void closeButton_Enter(object sender, EventArgs e)
        {
            closeButton.BackColor = SystemColors.ButtonHighlight;
        }

        // Create Method for highlighting closeButton Button when mouse hovers over it
        // Change closeButton BackColour to ButtonFace
        private void closeButton_Leave(object sender, EventArgs e)
        {
            closeButton.BackColor = SystemColors.ButtonFace;
        }

        // Create Method for Click on closeButton ("Close")
        // Exit program
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Create Method for MouseClick on hexText TextBox
        // Start if statement
        // If hexText Text is equal to default value or initial update of default value set hexText TextBox to empty
        // Select text in hexText TextBox
        private void hexText_MouseClick(object sender, MouseEventArgs e)
        {
            if (hexText.Text == "+++ <Your Question Here> +++" | hexText.Text == "+++ <Like I Said...> +++ \r\n \r\n +++ <Your Question Here> +++" == true)
            {
                hexText.Text = "";
                hexText.Select();
            }
        }

        // Create Method for recognising Key Presses on hexText TextBox
        // Declare and populate hexTextReset value from pre-button press hextText Text value
        // Start if statement
        // If Enter Key is pressed
        // Move focus to hexButton Button and simulate MouseClick
        // Reset hexText Text value to avoid registering "Enter" KeyPress
        // Move Cursor to end of hextText Text
        //  Select text in hexText TextBox
        private void hexText_KeyDown(object sender, KeyEventArgs e)
        {
            string hexTextReset = hexText.Text;
            if (e.KeyCode == Keys.Enter)
            {
                hexButton.Select();
                hexButton_Click(this, new EventArgs());
                hexText.Text = hexTextReset;
                hexText.SelectionStart = hexText.Text.Length;
                hexText.Focus();
            }

            // Continue if statement
            // If Escape key is pressed
            // Make hextText TextBox and hexButton Buttons invisible
            else if (e.KeyCode == Keys.Escape)
            {
                hexText.Visible = false;
                hexButton.Visible = false;
                hexText.Text = "+++ <Your Question Here> +++";
            }
        }

        // Create Method for MouseClick on hexButton ("Ask HEX a Question")
        private void hexButton_Click(object sender, EventArgs e)
        {
            // Create a randomiser
            Random rndNum = new Random();

            // Declare variables
            int treacleNum;
            int driveNum;
            int probNum;
            int yearNumber;
            int randomNumber;
            int mbbNumber;
            int mbiNumber;
            int buttonsNumber;
            int mbdbNumber;
            int stringLength;
            string messageString;
            string title;
            string hexTextValue;
            string treacleString;
            string probString;
            string word1;
            string word2;
            string word3;
            string word4;
            string word5;
            string word6;
            string concatString;
            string[] yearString;
            string[] driveString;
            string[] cheeseString;
            string[] melonString;
            string[] hogString;
            string[] dogString;
            string[] dateString;
            string[] darwinString;
            string[] letterString;
            string[] errorString;
            string[] anythingString;
            string[] whyString;
            string[] wordString;
            string[] apeString;
            string[] monkeyString;
            string[] allString;

            // Initialise messageString, create message title and message box control variables
            messageString = null;
            title = "HEX/Roundworld Interface";
            MessageBoxButtons[] buttons = { MessageBoxButtons.OK, MessageBoxButtons.OKCancel, MessageBoxButtons.RetryCancel, MessageBoxButtons.YesNo, MessageBoxButtons.AbortRetryIgnore, MessageBoxButtons.YesNoCancel };
            MessageBoxIcon[] icon = { MessageBoxIcon.Asterisk, MessageBoxIcon.Error, MessageBoxIcon.Exclamation, MessageBoxIcon.Hand, MessageBoxIcon.Information, MessageBoxIcon.Question, MessageBoxIcon.Stop, MessageBoxIcon.Warning };
            MessageBoxDefaultButton[] dButtons = { MessageBoxDefaultButton.Button1, MessageBoxDefaultButton.Button2, MessageBoxDefaultButton.Button3 };
            DialogResult hexResult;
            
            // Retrieve text from hexText textBox
            hexTextValue = hexText.Text;

            // Declare and populate yearString and driveString values
            yearString = new string[] { "Lenient Vegetable", "Pensive Hare", "Astounded Beetle", "Engaging Sloth", "Hyena", "Notional Serpent", "Prawn", "Pensive Frog", "Reversed Ptarmigan", "Revolving Crab", "Sideways Leech", "Spinning Mouse", "Talking Frog", "Reciprocating Llama", "Sneezing Panda", "Intimidating Porpoise", "Backwards-Facing Artichoke", "Scrofulous Vole", "Justifiably Defensive Lobster" };
            driveString = new string[] { "∞", "∆", "∑", "π", "Ø", "Γ", "Θ", "Λ", "Ξ", "Φ", "Ψ", "Ω", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            hogString = new string[] { "+++ Dear Hogfather, For Hogswatch I Want—", "+++ Humans Have Always Ascribed Random, Seasonal, Natural Or Inexplicable Actions To Human-Shaped Entities. Such Examples Are Jack Frost, The Hogfather, The Tooth Fairy And Death +++" };
            dogString = new string[] { "+++ Quanti Canicula Ille In Fenestra +++" };
            anythingString = new string[] { "+++ Because Everything +++", "Because Everything. ????? Eternal Domain Error. +++++ Redo From Start +++++." };
            wordString = new string[] { "A", "Able", "About", "Absence", "Accepted", "Accreting", "Across", "Act", "Acted", "Actions", "Activities", "Additional", "Address:", "Adjustment", "After", "Again", "Ago", "Air", "Alive", "All", "Almost", "Alone", "Along", "Aloud", "Already", "Alternative", "Although", "Always", "Am", "Amount", "An", "Analogy", "And", "Ankh", "Another", "Any", "Appeared", "Appetite", "Application", "Archaeology", "Archchancellor", "Are", "Area", "Areas", "Around", "Artefact", "Artichoke", "Arts", "As", "Ascent", "Ascribed", "Assistance", "Assume", "Assure", "Asteroid", "Astounded", "At", "Ate", "Atom", "Back", "Backwards", "Be", "Became", "Because", "Been", "Beetle", "Began", "Being", "Belief", "Believe", "Believed", "Believing", "Big", "Billions", "Birth", "Bisecting", "Blip", "Boat", "Bones", "Book", "Botany", "Bottle", "Branches", "Breeding", "British", "But", "Butterflies", "By", "Calculating", "Calculations", "Called", "Can", "Cannot", "Career", "Case", "Cases", "Caught", "Causality", "Cent", "Centre", "Certainly", "Chain", "Chair", "Chance", "Changed", "Changes", "Charles", "Checking", "Cheese", "Chief", "Choice", "Church", "Circumstances", "City", "Clarity", "Clear", "Clever", "Come", "Comes", "Communicate", "Compared", "Complete", "Completely", "Completes", "Complex", "Consider", "Considered", "Considers", "Consistent", "Contains", "Continuous", "Convey", "Copies", "Correct", "Could", "Counter", "Country", "Crab", "Creature", "Creatures", "Crime", "Crucial", "Cucumber", "Currently", "Cut", "Dangerous", "Darwin", "Darwins", "Dealing", "Dear", "Death", "Decently", "Defensive", "Defiance", "Deny", "Despite", "Destination", "Destined", "Destruction", "Detect", "Detected", "Developing", "Development", "Did", "Dies", "Dimension", "Dimensional", "Dirty", "Disappeared", "Disappears", "Discrete", "Ditch", "Divide", "Do", "Does", "Domain", "Done", "Don'T", "Door", "Down", "Dozen", "Drainage", "Dramatic", "Drive", "Duration", "Easy", "Education", "Effect", "Either", "Else", "Elves", "Embark", "Empty", "End", "Engaging", "England", "English", "Enough", "Enter", "Entered", "Enthusiastic", "Entire", "Entities", "Entitled", "Error", "Eternal", "Even", "Evening", "Events", "Ever", "Every", "Everything", "Everywhere", "Evolution", "Evolved", "Examples", "Except", "Excised", "Exist", "Exists", "Expected", "Expert", "Explain", "Explained", "Explanation", "Facing", "Factory", "Fairy", "Find", "Findings", "Fireworks", "First", "Five", "Focus", "Following", "Follows", "Fool", "Football", "For", "Forces", "Forthcoming", "Fraction", "Free", "Fried", "Frog", "From", "Frost", "Full", "Fully", "Fun", "Function", "Further", "Gallery", "Gentlemen", "Geologist", "Geology", "Germany", "Gets", "Give", "Gives", "Globe", "god", "Goddelson", "Going", "Good", "Granny", "Grave", "Grow", "Guarantee", "Had", "Hamburg", "Happened", "Hard", "Hardly", "Hare", "Has", "Hasn't", "Have", "Having", "He", "Head", "Heard", "Hello", "Here", "Hi", "Hiding", "High", "Him", "His", "Histories", "History", "Hogfather", "Hogswatch", "Host", "House", "How", "However", "Hugely", "Human", "Humanity", "Humans", "Hundred", "Hydra", "Hyena", "I", "Ideas", "Identical", "If", "Imagine", "Imagined", "Important", "Impossible", "In", "Inaccurate", "Indeed", "Indefinite", "Inevitably", "Inexplicable", "Inferno", "Influential", "Inside", "Insuff", "Intelligence", "Interesting", "Interference", "Intervene", "Intimidating", "Into", "Is", "It", "Its", "Itself", "Jack", "Jelly", "Job", "Join", "Joshua", "Journey", "Just", "Justifiably", "Kept", "Know", "Language", "Large", "Last", "Learned", "Leaving", "Led", "Leech", "Leg", "Legs", "Lenient", "Lepidoptery", "Level", "Lever", "Life", "Limit", "Little", "Living", "Llama", "Lobster", "Local", "Long", "Looks", "Lost", "Made", "Magnetic", "Maintain", "Major", "Make", "Makes", "Making", "Malignity", "Man", "Manifest", "Many", "Mathematics", "May", "Me", "Mean", "Measure", "Melon", "Memory", "Mention", "Might", "Mine", "Minerals", "Minor", "Minutes", "Moment", "Momentous", "Monkeys", "More", "Morpork", "Mouse", "Mr", "Much", "Multiple", "Mum", "Must", "My", "Mythical", "Nation", "Natural", "Need", "Needs", "Never", "Nevertheless", "New", "News", "Next", "Nineteen", "No", "Node", "Noise", "Not", "Nothing", "Noticeable", "Notional", "Now", "Noxious", "Number", "Observer", "Occurring", "Ocean", "Of", "Off", "Often", "Ology", "On", "Once", "One", "Oneoneoneoneoneone", "Oneoneoneoneoneoneone", "Ones", "Only", "Open", "Or", "Organ", "Origin", "Other", "Others", "Our", "Out", "Palaeontology", "Panda", "Parameters", "Parasite", "Part", "Pass", "Pause", "Pensive", "People", "Per", "Perhaps", "Phase", "Physical", "Pivotal", "Place", "Planet", "Please", "Point", "Porpoise", "Possibility", "Possible", "Potentiality", "Pottery", "Practically", "Prawn", "Preparing", "Present", "Priest", "Priests", "Primitive", "Probability", "Problem", "Procedures", "Process", "Project", "Protected", "Proto", "Prove", "Ptarmigan", "Published", "Pudding", "Query", "Quite", "Race", "Ran", "Random", "Reacquiring", "Real", "Reappears", "Reason", "Reasons", "Reboot", "Reciprocating", "Recovered", "Rector", "Recursion", "Red", "Redo", "Regret", "Regular", "Reinstall", "Religion", "Remember", "Remembered", "Removed", "Represents", "Reproduce", "Require", "Respect", "Restored", "Result", "Reversed", "Revolving", "River", "Road", "Roundworld", "Runium", "Rural", "Sacrifice", "Safe", "Sailed", "Sane", "Say", "Say:", "Scale", "Scientific", "Scientist", "Scream", "Scrofulous", "Seasonal", "Second", "See", "Seem", "Send", "Sense", "Serpent", "Set", "Sewers", "Shape", "Shaped", "Shoemaker", "Should", "Showing", "Shows", "Sideways", "Significance", "Significant", "Similarity", "Simply", "Skin", "Sloshing", "Sloth", "Small", "Sneezing", "So", "Some", "Someone", "Something", "Somewhere", "Soon", "Sorry", "Space", "Spare", "Species", "Specific", "Spinning", "Split", "Spoil", "Spoon", "Squalid", "Start", "Stay", "Still", "Stops", "Story", "Strange", "Strike", "Strive", "Studies", "Sub", "Subject", "Subjective", "Successful", "Succession", "Such", "Suggest", "Suit", "Sun", "Surmise", "Survive", "Taken", "Takes", "Talent", "Talking", "Tasks", "Tell", "Temple", "Ten", "Testing", "Than", "Thank", "That", "The", "Their", "Them", "Then", "Theology", "There", "They", "Things", "Think", "Third", "This", "Those", "Though", "Through", "Tickler", "Time", "Timeline", "Times", "To", "Too", "Tooth", "Treacle", "Tree", "Trousers", "Trying", "Two", "Unable", "Unavoidable", "Understand", "Understood", "Unimaginable", "Unimaginably", "Unique", "Universe", "Universes", "Unknown", "Until", "Unusual", "Up", "Upper", "Vanished", "Vegetable", "Very", "View", "Virtually", "Visit", "Vole", "Volunteer", "Voyage", "Waaaah", "Wait", "Want", "Was", "Watch", "Watchmaker", "Way", "We", "Weatherwax", "Well", "Were", "What", "Where", "Which", "While", "Who", "Whoops", "Why", "Will", "Wish", "With", "Without", "Work", "World", "Worlds", "Worry", "Would", "Write", "Writes", "Written", "Wrong", "Wrote", "Year", "Years", "Yes", "Yet", "You", "Young", "Your" };
            apeString = new string[] { "+++ Oook? +++", "+++ Oook! +++", "+++ Oook oook +++", "+++ Oook oook oook oook ook— +++", "+++ Oook-oook-OOK +++", "+++ Eeek? +++", "+++ Eeek! +++", "Oookoook-ooka-ooka-OOOka-OOK!", "Oook ook Oook-ook?", "+++ Warning: May Contain Nuts +++" };
            monkeyString = new string[] { "+++ Oook +++", "+++ Did You Mean To Write Ape? +++", "+++ Monkey, Or Ape +++", "+++ Completely Bursar +++", "+++ Totally Librarian-Poo +++", "+++ Warning: May Contain Nuts +++" };

            // Loop while user selects Retry button
            do
            {
                // Populate variables to allow random choice of Treacle Mine Road number, Drive letter, two-digit probability number, and MessageBox button
                treacleNum = rndNum.Next(1, 25);
                treacleString = treacleNum.ToString();
                driveNum = rndNum.Next(0, 26);
                probNum = rndNum.Next(10, 100);
                probString = probNum.ToString();
                yearNumber = rndNum.Next(0, yearString.Length);
                mbbNumber = rndNum.Next(0, 6);
                mbiNumber = rndNum.Next(0, 8);
                // Retrieve whether MessageBox is to have 1, 2 or 3 buttons then randomise which button is used as the default
                if (mbbNumber == 1)
                { buttonsNumber = 1; }
                else if (mbbNumber == 2)
                { buttonsNumber = 2; }
                else
                { buttonsNumber = 3; }
                mbdbNumber = rndNum.Next(0, buttonsNumber);

                // Start if statement
                // If hexTextValue is empty or unchanged from default message display this result and update hexTextValue
                // Randomise result with a one in fifty chance that an Out Of Cheese Error will be shown
                // Empty messageString so hexResult MessageBox is not displayed
                if (hexTextValue == "" | hexTextValue == "+++ <Your Question Here> +++" == true)
                {
                    randomNumber = rndNum.Next(0, 50);
                    if (randomNumber > 2)
                        MessageBox.Show("+++ Please Enter A Question +++ \n \n +++ I'm Not A Mind Reader +++", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    else
                        MessageBox.Show("+++ Out Of Cheese +++", "!!! Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    hexText.Text = "+++ <Like I Said...> +++ \r\n \r\n +++ <Your Question Here> +++";
                    messageString = "";
                }
                // Continue if statement
                // If hexTextValue is empty or unchanged from above message display this result
                // Randomise result with a one in fifty chance that an Out Of Cheese Error will be shown
                // Empty messageString so hexResult MessageBox is not displayed
                else if (hexTextValue == "+++ <Like I Said...> +++ \r\n \r\n +++ <Your Question Here> +++" == true)
                {
                    randomNumber = rndNum.Next(0, 50);
                    if (randomNumber > 2)
                        MessageBox.Show("+++ Please Try Again +++", "!!! Oops !!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    else
                        MessageBox.Show("+++ Out Of Cheese +++", "!!! Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    messageString = "";
                }
                // Continue if statement
                // If hexTextValue contains "biscuits", "wine", or a variety of dairy products from around the world... display this result
                // Populate cheeseString
                // Set randomNumber to select random message from cheeseString
                // Set messageString for output
                else if (hexTextValue.ToLower().Contains("cheese") | hexTextValue.ToLower().Contains("biscuit") | hexTextValue.ToLower().Contains("wine") | hexTextValue.ToLower().Contains("paneer") | hexTextValue.ToLower().Contains("halloumi") | hexTextValue.ToLower().Contains("feta") | hexTextValue.ToLower().Contains("urda") | hexTextValue.ToLower().Contains("bryndza") | hexTextValue.ToLower().Contains("labneh") | hexTextValue.ToLower().Contains("cheddar") | hexTextValue.ToLower().Contains("quesillo") | hexTextValue.ToLower().Contains("cream") | hexTextValue.ToLower().Contains("dairy") | hexTextValue.ToLower().Contains("limburger") | hexTextValue.ToLower().Contains("goya") | hexTextValue.ToLower().Contains("wensleydale") | hexTextValue.ToLower().Contains("brie") | hexTextValue.ToLower().Contains("stilton") | hexTextValue.ToLower().Contains("mozarella") | hexTextValue.ToLower().Contains("gorgonzola") | hexTextValue.ToLower().Contains("gouda") | hexTextValue.ToLower().Contains("camembert") | hexTextValue.ToLower().Contains("mascarpone") | hexTextValue.ToLower().Contains("mozzarella") | hexTextValue.ToLower().Contains("Gruyère") == true)
                {
                    cheeseString = new string[] { "*Blip* *Blip* *Blip* End of Cheese Error", "+++ Out Of Cheese Error +++ MELON MELON MELON +++ Redo From Start +++", "+++ Out Of Cheese Error +++", "+++ Out of Cheese Error. Redo From Start. +++", "+++ Whoops! Here Comes The Cheese! +++ MELON MELON MELON +++ Error At Address: " + treacleString + ", Treacle Mine Road, Ankh-Morpork +++ !!!!! +++ Oneoneoneoneoneone +++ Redo From Start +++", "+++ Whoops! Here Comes The Cheese! +++", "Don't mention it. ++?????++ Out of Cheese Error. Redo From Start." };
                    randomNumber = rndNum.Next(0, cheeseString.Length);
                    messageString = cheeseString[randomNumber];
                }
                // Continue if statement
                // Populate melonString
                // If hexTextValue contains "melon" or "fruit" display this result
                // Set randomNumber to select random message from melonString
                // Set messageString for output
                else if (hexTextValue.ToLower().Contains("melon") | hexTextValue.ToLower().Contains("fruit") == true)
                {
                    melonString = new string[] { "+++ Hi Mum Is Testing +++ MELON MELON MELON +++ Out Of Cheese Error +++ !!!!! +++ Mr. Jelly! Mr. Jelly! +++", "+++ MELON MELON MELON +++", "+++ Out Of Cheese Error +++ MELON MELON MELON +++ Redo From Start +++", "+++ Whoops! Here Comes The Cheese! +++ MELON MELON MELON +++ Error At Address: " + treacleString + ", Treacle Mine Road, Ankh-Morpork +++ !!!!! +++ Oneoneoneoneoneone +++ Redo From Start +++" };
                    randomNumber = rndNum.Next(0, melonString.Length);
                    messageString = melonString[randomNumber];
                }
                // Continue if statement
                // If hexTextValue contains "hog", "xmas" or "christmas" display this result
                // Populate hogString
                // Set randomNumber to select random message from melonString
                // Set messageString for output
                else if (hexTextValue.ToLower().Contains("hog") | hexTextValue.ToLower().Contains("xmas") | hexTextValue.ToLower().Contains("christmas") == true)
                {
                    randomNumber = rndNum.Next(0, hogString.Length);
                    messageString = hogString[randomNumber];
                }
                // Continue if statement
                // If hexTextValue contains "dog", "window" or "how much" display this result
                // Populate dogString
                // Set randomNumber to select random message from whyString
                // Set messageString for output
                else if (hexTextValue.ToLower().Contains("dog") | hexTextValue.ToLower().Contains("window") | hexTextValue.ToLower().Contains("how much") == true)
                {
                    randomNumber = rndNum.Next(0, dogString.Length);
                    messageString = dogString[randomNumber];
                }
                // Continue if statement
                // If hexTextValue contains "date", "day", "year", "month" or "week" display this result
                // Populate dateString
                // Set randomNumber to select random message from dateString
                // Set messageString for output
                else if (hexTextValue.ToLower().Contains("date") | hexTextValue.ToLower().Contains("day") | hexTextValue.ToLower().Contains("year") | hexTextValue.ToLower().Contains("month") | hexTextValue.ToLower().Contains("week") == true)
                {
                    dateString = new string[] { "*Blip* *Blip* *Blip* Year Of The " + yearString[yearNumber] + " *Blip* *Blip* *Blip*" };
                    randomNumber = rndNum.Next(0, dateString.Length);
                    messageString = dateString[randomNumber];
                }
                // Continue if statement
                // If hexTextValue contains "darwin", "evolution", "evolve", "charles", "science", "religion" or "species" display this result
                // Populate darwinString
                // Set randomNumber to select random message from darwinString
                // Set messageString for output
                else if (hexTextValue.ToLower().Contains("darwin") | hexTextValue.ToLower().Contains("evolution") | hexTextValue.ToLower().Contains("evolve") | hexTextValue.ToLower().Contains("charles") | hexTextValue.ToLower().Contains("science") | hexTextValue.ToLower().Contains("religion") | hexTextValue.ToLower().Contains("species") == true)
                {
                    darwinString = new string[] { "+++ Across the entire phase space of this world Charles Darwin did many things. He became an expert watchmaker. He ran a pottery factory. In many worlds he was a country priest. In others, he was a geologist. In yet others, he did make the important voyage and, as a result wrote Theology of Species. In some he began to write The Origin of Species only to give up. Only in one timeline was Origin published. This should not be possible. I detect ... +++", "+++ Charles Darwin of Theology of Species was for much of his life a Rector in the Church of England, a sub-set of the British nation +++", "+++ Consider time not as a continuous process but as a succession of discrete events. Darwin's scientific career has been excised. You remember him, but that is because you are not part of this universe. To deny this is simply to scream at the monkeys in the next tree +++", "+++ I am unable to explain why this is the case, but there are now 14" + probString + " reasons why Darwin did not write The Origin of Species. The book has never been written in this history. The voyage has never taken place +++", "+++ I explained, in the successful timeline which led to humanity leaving the planet, Mr Darwin makes a significant voyage. It is one of nineteen pivotal events in the history of the species. It is almost as important as Joshua Goddelson leaving his house by the back door in 1734 +++", "+++ I mean vanished. Darwin disappears from Roundworld in 1850. This is a new development. That is to say, it has always happened, but has always happened only for the last two minutes +++", "+++ Impossible to prove. Assume that they do. In all those universes there are hardly any in which a man called Charles Darwin exists, takes a momentous ocean voyage, and writes a hugely influential book about the evolution of life on the planet. Nevertheless, that number is still unimaginably large +++", "+++ In the case of Charles Darwin, very hard +++", "+++ just unimaginably unique. The number one. Gentlemen. All by itself. One is one and all alone. One. Yes. In third-level phase space there is only one history where he gets on the boat, completes the voyage, considers the findings and writes that book. All the other alternative Darwins either did not exist, did not stay on the boat, did not survive the journey, did not write any book at all or wrote, in a large number of cases, Theology of Species and entered the Church +++", "+++ There is an additional problem. It is not clear to me why Darwin did not write Origin somewhere in the multiple universes without your forthcoming assistance +++", "+++ Yes. It did. But now, it hasn't. Charles Darwin the scientist has been removed from this history while you ate. He was, and now he was not. He became a little-remembered priest who caught butterflies. He wrote no book. The human race dies in five hundred years +++", "+++  I am sorry. It is hard to convey five-dimensional ideas in a language evolved to scream defiance at the monkeys in the next tree.  +++" };
                    randomNumber = rndNum.Next(0, darwinString.Length);
                    messageString = darwinString[randomNumber];
                }
                // Continue if statement
                // If hexTextValue contains "drive" display this result
                // Populate letterString
                // Set randomNumber to select random message from letterString
                // Set messageString for output
                else if (hexTextValue.ToLower().Contains("drive") == true)
                {
                    letterString = new string[] { "*Blip* *Blip* *Blip* Can Not Find Drive " + driveString[driveNum] + ":" };
                    randomNumber = rndNum.Next(0, letterString.Length);
                    messageString = letterString[randomNumber];
                }
                // Continue if statement
                // If hexTextValue contains "error", "computer", "mac", "apple", "phone", "android", "google", "drive" or "pc" display this result
                // Populate errorString
                // Set randomNumber to select random message from errorString
                // Set messageString for output
                else if (hexTextValue.ToLower().Contains("error") | hexTextValue.ToLower().Contains("computer") | hexTextValue.ToLower().Contains("mac") | hexTextValue.ToLower().Contains("apple") | hexTextValue.ToLower().Contains("phone") | hexTextValue.ToLower().Contains("android") | hexTextValue.ToLower().Contains("google") | hexTextValue.ToLower().Contains("drive") | hexTextValue.ToLower().Contains("pc") == true)
                {
                    errorString = new string[] { "+++ Because Everything +++", "+++ Because +++", "*Blip* *Blip* *Blip* Can Not Find Drive " + driveString[driveNum] + ":", "*Blip* *Blip* *Blip* End of Cheese Error", "*Blip* *Blip* *Blip* Please Reboot Universe", "*Blip* *Blip* *Blip* Unknown Application Error", "+++ ?????? +++ Hello +++ Redo From Start +++", "+++ Big Red Lever Time +++ Query +++", "+++ Divide By Cucumber Error. Please Reinstall Universe And Reboot +++", "+++ Error At Address " + treacleString + ", Treacle Mine Road +++", "+++ Eternal domain error +++", "+++ Hi Mum Is Testing +++ MELON MELON MELON +++ Out Of Cheese Error +++ !!!!! +++ Mr. Jelly! Mr. Jelly! +++", "+++ How Long Have You Been Mr. Jelly? +++", "+++ I Assure You I Am As Sane As The Next Man +++", "+++ Indeed +++", "+++ Insuff", "+++ Is this a problem? +++", "+++ MELON MELON MELON +++", "+++ Mine! Waaaah! +++", "+++ Mr. Jelly! Mr. Jelly! +++", "+++ No +++", "+++ Nothing +++", "+++ On A Scale Of One To Ten—Query +++", "+++ Oneoneoneoneoneoneone +++", "+++ Out Of Cheese Error +++ MELON MELON MELON +++ Redo From Start +++", "+++ Out Of Cheese Error +++", "+++ Out of Cheese Error. Redo From Start. +++", "+++ Recursion Is Occurring +++", "+++ Redo From Start +++", "+++ Tell Me About Your Spoon +++", "+++ Whoops! Here Comes The Cheese! +++ MELON MELON MELON +++ Error At Address: " + treacleString + ", Treacle Mine Road, Ankh-Morpork +++ !!!!! +++ Oneoneoneoneoneone +++ Redo From Start +++", "+++ Whoops! Here Comes The Cheese! +++", "+++ Yes. I Am Entitled +++", "+++ Yes. I Am Preparing An Area Of Write-Only Memory +++", "+++ Yes. It can +++", "+++ Yes? +++", "Because Everything. ????? Eternal Domain Error. +++++ Redo From Start +++++.", "Don't mention it. ++?????++ Out of Cheese Error. Redo From Start." };
                    randomNumber = rndNum.Next(0, errorString.Length);
                    messageString = errorString[randomNumber];
                }
                // Continue if statement
                // If hexTextValue contains "why" and "anything" display this result
                // Populate anythingString
                // Set randomNumber to select random message from anythingString
                // Set messageString for output
                else if (hexTextValue.ToLower().Contains("why") && hexTextValue.ToLower().Contains("anything") == true)
                {
                    randomNumber = rndNum.Next(0, anythingString.Length);
                    messageString = anythingString[randomNumber];
                }
                // Continue if statement
                // If hexTextValue contains "why" display this result
                // Populate whyString
                // Set randomNumber to select random message from whyString
                // Set messageString for output
                else if (hexTextValue.ToLower().Contains("why") == true)
                {
                    whyString = new string[] { "+++ Because +++" };
                    randomNumber = rndNum.Next(0, whyString.Length);
                    messageString = whyString[randomNumber];
                }
                // Continue if statement
                // If hexTextValue contains "word" display this result
                // Populate wordString
                // Set randomNumber to select random message from wordString
                // Set messageString for output
                else if (hexTextValue.ToLower().Contains("word") == true)
                {
                    randomNumber = rndNum.Next(0, wordString.Length);
                    messageString = "+++ " + wordString[randomNumber] + " +++";
                }
                // Continue if statement
                // If hexTextValue contains "random" display this result
                // Populate stringlength and six versions of wordx from randomly chosen word in wordString array
                // Create Case statement to output different number of ords dependent on stringLength and set messageString
                else if (hexTextValue.ToLower().Contains("random") == true)
                {
                    stringLength = rndNum.Next(1, 7);
                    word1 = wordString[rndNum.Next(0, wordString.Length)];
                    word2 = wordString[rndNum.Next(0, wordString.Length)];
                    word3 = wordString[rndNum.Next(0, wordString.Length)];
                    word4 = wordString[rndNum.Next(0, wordString.Length)];
                    word5 = wordString[rndNum.Next(0, wordString.Length)];
                    word6 = wordString[rndNum.Next(0, wordString.Length)];
                    switch (stringLength)
                    {
                        case 1:
                            concatString = word1;
                            messageString = "+++ " + concatString + " +++";
                            break;
                        case 2:
                            concatString = word1 + " " + word2;
                            messageString = "+++ " + concatString + " +++";
                            break;
                        case 3:
                            concatString = word1 + " " + word2 + " " + word3;
                            messageString = "+++ " + concatString + " +++";
                            break;
                        case 4:
                            concatString = word1 + " " + word2 + " " + word3 + " " + word4;
                            messageString = "+++ " + concatString + " +++";
                            break;
                        case 5:
                            concatString = word1 + " " + word2 + " " + word3 + " " + word4 + " " + word5;
                            messageString = "+++ " + concatString + " +++";
                            break;
                        case 6:
                        concatString = word1 + " " + word2 + " " + word3 + " " + word4 + " " + word5 + " " + word6;
                        messageString = "+++ " + concatString + " +++";
                            break;
                    }
                }
                // Continue if statement
                // If hexTextValue contains "ape" or "utan" display this result
                // Populate whyString
                // Set randomNumber to select random message from whyString
                // Set messageString for output
                else if (hexTextValue.ToLower().Contains("ape") | hexTextValue.ToLower().Contains("utan") | hexTextValue.ToLower().Contains("librar") == true)
                {
                    randomNumber = rndNum.Next(0, apeString.Length);
                    messageString = apeString[randomNumber];
                }
                // Continue if statement
                // If hexTextValue contains "monkey", "gibbon", "lemur", "siamang", "marmoset", "tamarin" or "capuchin" display this result
                // Populate whyString
                // Set randomNumber to select random message from whyString
                // Set messageString for output
                else if (hexTextValue.ToLower().Contains("monkey") | hexTextValue.ToLower().Contains("gibbon") | hexTextValue.ToLower().Contains("lemur") | hexTextValue.ToLower().Contains("siamang") | hexTextValue.ToLower().Contains("marmoset") | hexTextValue.ToLower().Contains("tamarin") | hexTextValue.ToLower().Contains("capuchin") == true)
                {
                    randomNumber = rndNum.Next(0, monkeyString.Length);
                    messageString = monkeyString[randomNumber];
                }
                // Complete if statement
                // Populate allString
                // Set randomNumber to select random message from allString
                // Set messageString for output
                else
                {
                    allString = new string[] { "*Blip* *Blip* *Blip* Can Not Find Drive " + driveString[driveNum] + ":", "*Blip* *Blip* *Blip* End of Cheese Error", "*Blip* *Blip* *Blip* Please Reboot Universe", "*Blip* *Blip* *Blip* Unknown Application Error", "+++  I am sorry. It is hard to convey five-dimensional ideas in a language evolved to scream defiance at the monkeys in the next tree.  +++", "+++ ?????? +++ Hello +++ Redo From Start +++", "+++ 35" + probString + " reasons now +++", "+++ A shoemaker living in Hamburg, Germany +++", "+++ Across the entire phase space of this world Charles Darwin did many things. He became an expert watchmaker. He ran a pottery factory. In many worlds he was a country priest. In others, he was a geologist. In yet others, he did make the important voyage and, as a result wrote Theology of Species. In some he began to write The Origin of Species only to give up. Only in one timeline was Origin published. This should not be possible. I detect ... +++", "+++ Adjustment Complete. On You It Looks Good +++", "+++ All Things Strive +++", "+++ Because +++", "+++ Because Everything +++", "+++ Big Red Lever Time +++ Query +++", "+++ But There Is No Reason Why There Should Not Be +++", "+++ But you are going to have done +++", "+++ But You Will Need A Volunteer. Someone To Fool +++", "+++ Certainly. With a probability of 94." + probString + " per cent +++", "+++ Charles Darwin of Theology of Species was for much of his life a Rector in the Church of England, a sub-set of the British nation +++", "+++ Consider time not as a continuous process but as a succession of discrete events. Darwin's scientific career has been excised. You remember him, but that is because you are not part of this universe. To deny this is simply to scream at the monkeys in the next tree +++", "+++ Correct. But that was then then, this is then now. Something has been changed. I surmise that this is as a result of our activities. And, having happened, it has always happened, from the point of view of an observer in Roundworld +++", "+++ Creatures Have Appeared That Were Once Believed In +++", "+++ Dear Hogfather, for Hogswatch I Want—", "+++ Despite being wrong in every important respect, that is a very good analogy +++", "+++ Divide By Cucumber Error. Please Reinstall Universe And Reboot +++", "+++ Does Your Spoon Worry You? +++", "+++ Elves have entered Roundworld. This is to be expected. +++", "+++ Empty Space Is Not Nothing, Archchancellor. There Is Not Even Empty Space Inside The Project. There Is No Time For It To Be Empty In +++", "+++ Error At Address " + treacleString + ", Treacle Mine Road +++", "+++ Eternal domain error +++", "+++ Even so, it is not so unimaginable as the number of universes in which the book was The Origin of Species. That number is quite strange and can only be imagined at all in very unusual circumstances +++", "+++ From the moment that the Roundworld universe was made, it began to split into almost identical copies of itself, billions of times a second. That unimaginably large number represents all possible Roundworld universes that there are +++", "+++ Good Evening, Archchancellor. I Am Fully Recovered And Enthusiastic About My Tasks +++", "+++ Hi Mum Is Testing +++ MELON MELON MELON +++ Out Of Cheese Error +++ !!!!! +++ Mr. Jelly! Mr. Jelly! +++", "+++ Hiding in the Minerals Gallery +++", "+++ How Long Have You Been Mr. Jelly? +++", "+++ Humans Are Not Always Wrong +++", "+++ Humans Have Always Ascribed Random, Seasonal, Natural Or Inexplicable Actions To Human-Shaped Entities. Such Examples Are Jack Frost, The Hogfather, The Tooth Fairy And Death +++", "+++ I Am Checking +++", "+++ I am unable to explain why this is the case, but there are now 14" + probString + " reasons why Darwin did not write The Origin of Species. The book has never been written in this history. The voyage has never taken place +++", "+++ I Assure You I Am As Sane As The Next Man +++", "+++ I cannot guarantee reacquiring more than one of every 1 organ +++", "+++ I did that. I still maintain a watch on Roundworld. And I have been developing interesting procedures. It is now quite easy for me to reproduce an artefact in the real world +++", "+++ I Don't Think You Are Going To Believe This +++", "+++ I explained, in the successful timeline which led to humanity leaving the planet, Mr Darwin makes a significant voyage. It is one of nineteen pivotal events in the history of the species. It is almost as important as Joshua Goddelson leaving his house by the back door in 1734 +++", "+++ I mean vanished. Darwin disappears from Roundworld in 1850. This is a new development. That is to say, it has always happened, but has always happened only for the last two minutes +++", "+++ I need to communicate grave news +++", "+++ I Regret This +++", "+++ I will see what I can do next time, Archchancellor +++", "+++ I would not wish to spoil your appetite +++", "+++ Imagine an unimaginably large number +++", "+++ Impossible to prove. Assume that they do. In all those universes there are hardly any in which a man called Charles Darwin exists, takes a momentous ocean voyage, and writes a hugely influential book about the evolution of life on the planet. Nevertheless, that number is still unimaginably large +++", "+++ In a primitive subjective sense this is the case. However, you are going to will have already soon +++", "+++ In all the universes of the The Ology, it was the Temple of the Ascent of Man. Here, it is not +++", "+++ In The Absence Of Duration And Dimension, There Must Be Potentiality. +++", "+++ In the case of Charles Darwin, very hard +++", "+++ Indeed +++", "+++ Inevitably. The centre of the Globe is an inferno, humanity is protected from being fried alive by nothing more than a skin of air and magnetic forces, and the chance of an asteroid strike is ever present +++", "+++ Insuff", "+++ Is this a problem? +++", "+++ It Follows That If A Major Focus Of Belief Is Removed, There Will Be Spare Belief +++", "+++ It has only just happened +++", "+++ It sailed from England to England. But there were crucial stops along the way. Even in those histories where he did embark on the boat, he did not complete the voyage and complete The Origin of Species in every case but one +++", "+++ just unimaginably unique. The number one. Gentlemen. All by itself. One is one and all alone. One. Yes. In third-level phase space there is only one history where he gets on the boat, completes the voyage, considers the findings and writes that book. All the other alternative Darwins either did not exist, did not stay on the boat, did not survive the journey, did not write any book at all or wrote, in a large number of cases, Theology of Species and entered the Church +++", "+++ MALIGNITY +++", "+++ MELON MELON MELON +++", "+++ Mine! Waaaah! +++", "+++ Mr. Jelly! Mr. Jelly! +++", "+++ New Suit Parameters Accepted +++", "+++ No +++", "+++ No. But the chain of causality, though complex, is clear +++", "+++ No. It is unimaginably large. But compared to the first number, it is unimaginably small +++", "+++ No. The act shows intelligence +++", "+++ No. They are not clever enough. I can detect nothing except natural forces +++", "+++ Nothing +++", "+++ Nothing Physical May Enter The Project +++", "+++ On A Scale Of One To Ten—Query +++", "+++ Oneoneoneoneoneoneone +++", "+++ Out Of Cheese Error +++ MELON MELON MELON +++ Redo From Start +++", "+++ Out Of Cheese Error +++", "+++ Out of Cheese Error. Redo From Start. +++", "+++ pause for dramatic effect ... Perhaps the ones here have learned to +++", "+++ People Were Believing In Something Else—Query? +++", "+++ Recursion Is Occurring +++", "+++ Redo From Start +++", "+++ Regular and Consistent Belief +++", "+++ Remember, I detected malignity. I surmise that your interference in this history has led to some counter-measure +++", "+++ Runium May Or May Not Still Exist. It Was Down To One Atom Ten Minutes Ago, Which I Do Not Seem to Be Able To Find Any More +++", "+++ Some of them did that too, yes, although it was considered to be showing off. The God of the English did not require much in the way of sacrifice, only that people acted decently and kept the noise down. Being a priest in that church was a natural job for a young man of good breeding and education but no very specific talent. In the rural areas they had much free time. My calculations suggest that Theology of Species was the book that he was destined to write. In all the histories of third-level phase space, there is only one in which he writes The Origin of Species +++", "+++ Tell Me About Your Spoon +++", "+++ Thank you, Archchancellor +++", "+++ Thank you. Yes. Cut off one head and a dozen grow in its place. This history is a hydra +++", "+++ That Is Possible. Virtually Possible +++", "+++ The Amount Of Belief In The World Must Be Subject To An Upper Limit +++", "+++ The Chair of Indefinite Studies is correct +++", "+++ The chief function of the priests of that religion at the time was to further the arts of archaeology, local history, lepidoptery, botany, palaeontology, geology and the making of fireworks +++", "+++ The destruction of the human race can wait until after the pudding +++", "+++ The explanation is complex +++", "+++ The Project Must Be Kept Safe +++", "+++ The similarity is noticeable, yes +++", "+++ The Sun Will Not Come Up +++", "+++ Their world is a parasite universe. It needs a host +++", "+++ There is an additional problem. It is not clear to me why Darwin did not write Origin somewhere in the multiple universes without your forthcoming assistance +++", "+++ There will be unavoidable minor changes +++", "+++ They Disappeared Because They Were Not Believed In +++", "+++ They were having such fun trying to send the bottle +++", "+++ This Is Just Calculating Aloud, You Understand +++", "+++ This Is Possible +++", "+++ This May Be Time For The Roundworld Project +++", "+++ Understood. The major city you must visit has many squalid areas and open sewers. The river bisecting it is noxious. Your destination could be considered a high-crime drainage ditch in a dangerous and dirty world +++", "+++ Unknown. Phase space currently contains proto-histories in which he reappears after a fraction of one second and others where he never reappears at all. Clarity must be restored to this new node +++", "+++ Very well +++", "+++ Whoops! Here Comes The Cheese! +++ MELON MELON MELON +++ Error At Address: " + treacleString + ", Treacle Mine Road, Ankh-Morpork +++ !!!!! +++ Oneoneoneoneoneone +++ Redo From Start +++", "+++ Whoops! Here Comes The Cheese! +++", "+++ Why Do You Think You Are A Tickler? +++", "+++ Yes. But, pause for significance, have you heard of a mythical creature called a, pause again, hydra? +++", "+++ Yes. Except that every leg of the Trousers of Time branches into many other legs, and so do those legs and every following leg, until everywhere is full of legs, which often pass through one another or join up again +++", "+++ Yes. I Am Entitled +++", "+++ Yes. I Am Preparing An Area Of Write-Only Memory +++", "+++ Yes. It can +++", "+++ Yes. It did. But now, it hasn't. Charles Darwin the scientist has been removed from this history while you ate. He was, and now he was not. He became a little-remembered priest who caught butterflies. He wrote no book. The human race dies in five hundred years +++", "+++ Yes. It is the one where you intervene +++", "+++ Yes. Language is not good at this. Even mathematics gets lost. But a little story might work. I will tell you the story. It will be not completely inaccurate +++", "+++ Yes. Sloshing Around. Accreting +++", "+++ Yes. That is the problem. You understand that every possibility of choice gives birth to a new universe in which that choice is manifest? +++", "+++ You Would Say: To Know In Your Bones +++", "+++ Yes? +++", "Because Everything. ????? Eternal Domain Error. +++++ Redo From Start +++++.", "Don't mention it. ++?????++ Out of Cheese Error. Redo From Start.", "What shape football do you require?", "*Blip* *Blip* *Blip* Year Of The " + yearString[yearNumber] + " *Blip* *Blip* *Blip*", "Practically everything", "We are dealing with the death of Granny Weatherwax" };
                    randomNumber = rndNum.Next(0, allString.Length);
                    messageString = allString[randomNumber];
                }

                // Start if statement
                // If messageString is not empty
                // Display hexResult MessageBox populated from above if statements
                if (messageString != "")
                {
                    hexResult = MessageBox.Show(messageString, title, buttons[mbbNumber], icon[mbiNumber], dButtons[mbdbNumber]);
                }
                // Complete if statement
                // Set hexResult to OK so MessageBox is not displayed again
                // Set messageString for output
                else
                {
                    hexResult = DialogResult.OK;
                }
            } while (hexResult == DialogResult.Retry);
        }

        private void HexInterface_Load(object sender, EventArgs e)
        {

        }
    }
}
