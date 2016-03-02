using System;
using System.IO;
using System.Windows.Forms;

namespace CSharpBombDefuser
{
    

    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            // Set up font for countdown timer and labels
            FontTool.LoadFont();
            FontTool.AllocFont(FontTool.Digital7Font, lblCountDown, 30);
            FontTool.AllocFont(FontTool.Digital7Font, lblWins,20);
            FontTool.AllocFont(FontTool.Digital7Font, lblWinsNumber, 20);
            FontTool.AllocFont(FontTool.Digital7Font, lblLosses, 20);
            FontTool.AllocFont(FontTool.Digital7Font, lblLossesNumber, 20);
            FontTool.AllocFont(FontTool.Digital7Font, lblTotal, 20);
            FontTool.AllocFont(FontTool.Digital7Font, lblTotalNumber, 20);
           // FontTool.AllocFont(FontTool.Digital7Font, , 8);




            // decide which wire is the dangerous one
            GameVariables.BombWires.MakeDangerWire(GameVariables.BombWires);

            //pop up box with story
            TheStory();

           // lblCountDown.Text = Convert.ToString(bombWires.DangerWire);
            WriteClock(GameVariables.TimeLeft);
            
            //start countdown timer
            timer1.Start();
            
        }



        //Method decides if wire is safe or live, sends on to appropriate method
        void AllButtonPress(object sender, EventArgs e)
        {
            //speed up timer
            timer1.Interval = 1000 / 60;

            //make a fake button
            Button fakeButton = sender as Button;
            //get the button number from the pressed button sender
            int buttonNumber = Convert.ToInt32(fakeButton.Name.Substring(fakeButton.Name.Length - 1));
            // if (fakeButton) wire has already been cut 
            if (GameVariables.BombWires.CutWires[buttonNumber - 1] == "Cut")
            {//do nothing
            }
            //if you cut the dangerous wire
            else if (GameVariables.BombWires.IsDangerWire(buttonNumber, GameVariables.BombWires))
            {
                //cut the wire (necessary for image change)
                Wires.CutWire(fakeButton, buttonNumber-1);
                //explode the bomb
                Kaboom();
            }
            
            else
            {
                //just cut the wire
                Wires.CutWire(fakeButton, buttonNumber - 1);
                
                //count how many wires are cut
                int cutWireCounter = 0;
                foreach (var wire in GameVariables.BombWires.CutWires)
                {
                    if (wire == "Cut")
                    {
                        cutWireCounter++;
                    }
                }
                //once 4 wires are cut, the bomb is defused
                if (cutWireCounter == 4)
                {
                    Defused();
                    
                }
            }

        }
        // method called when Mute checkbox is changed
        private void MuteStateChanged(object sender, EventArgs e)
        {
            if (cbxMute.Checked)
            {
                GameVariables.IsMuted = true;
            }
            else
            {
                GameVariables.IsMuted = false;
            }
        }
       
        //Method called when timer interval ticks
        private void timer1_Tick(object sender, EventArgs e)
        {

            //var for time=0
            TimeSpan timeOut = new TimeSpan(0,0,0);
            //var for time=1 second
            TimeSpan timeOff = new TimeSpan(0, 0, 1);
            //check there is time on the clock
            if (GameVariables.TimeLeft > timeOut)
            {
                //if timer tickes every second play beep
                if (timer1.Interval == 1000)
                {
                    PlaySound(Properties.Resources.Beep);
                }
                //if timer has sped up play beep every 10th tick (it's very annoying otherwise)
                //using *.Seconds%10==1 makes beep play on entering second 0 rather than on leaving
                else if (GameVariables.TimeLeft.Seconds%10 == 1)
                {
                    PlaySound(Properties.Resources.Beep);
                }
                //Take 1s(timeOff) from the clock
                GameVariables.TimeLeft = GameVariables.TimeLeft - timeOff;
                // Display the new time left
                WriteClock(GameVariables.TimeLeft);
            }
            else
            {
                
                //Blow up the bomb
                Kaboom();
               
                 
            }

        }

        private void WriteClock(TimeSpan time)
        {
            //Format and write the countdown timer
            //add { Convert.ToString(GameVariables.BombWires.DangerWire)+ }for debug
            lblCountDown.Text = String.Format("{0:00} : {1:00} : {2:00}", Convert.ToInt32(time.Hours), Convert.ToInt32(time.Minutes), Convert.ToInt32(time.Seconds));
        }
       
        //When the bomb explodes
        private  void Kaboom()
        {//to do: bomb explodes graphics and noise event

            // Stop the timer, set the timer to 00:00:00, .
            timer1.Stop();
            //Play the detonation sound effect
            PlaySound(Properties.Resources.Detonation);
            //set the timer to 00:00:00
            GameVariables.TimeLeft = TimeSpan.Zero;
            //show the new timer count on the screen
            WriteClock(GameVariables.TimeLeft);
            //Increment the games lost and total and write them to the form
            GameVariables.GamesLost++;
            GameVariables.GamesTotal++;
            lblLossesNumber.Text = Convert.ToString(GameVariables.GamesLost);
            lblTotalNumber.Text = Convert.ToString(GameVariables.GamesTotal);
            //set message box content for faliure
            string message = "The bomb exploded. Would you like to try again?";
            string caption = "Oops!";
            // call quit/reset message box, passing text content
            EndOrReset(message, caption);
           
           
            
        }

        //when the bomb is successfully defused
        private  void Defused()
        {

            //stop the countdown timer
            timer1.Stop();
            //increment the games won and total and write to the form.
            GameVariables.GamesWon++;
            GameVariables.GamesTotal++;
            lblWinsNumber.Text = Convert.ToString(GameVariables.GamesWon);
            lblTotalNumber.Text = Convert.ToString(GameVariables.GamesTotal);
            //set the message box content
            string message = "You successfully defused the bomb. Would you like to try again?";
            string caption = "Hooray!";
            //call the quit/reset message box, passing message box content.
            EndOrReset(message, caption);
        }

        //quit/reset message box
        void EndOrReset(string message, string caption)
        {
            //Set up the message box details
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.

            result = MessageBox.Show(this, message, caption, buttons);

            //If player wants to play again
            if (result == DialogResult.Yes)
            {
                //Go to Reset
                ResetGame();
            }
            //Otherwise Go to EndGame
            else EndTheGame();
        }

        //Method to reset all game elements. 
        private void ResetGame()
        {
            //for loop: change all wires array to uncut, 
            for (int i = 0; i < 6; i++)
            {
                GameVariables.BombWires.CutWires[i] = "Uncut";
            }
            
            //game counters to zero
            
            //pictures to uncut
            btnWire1.Image = Properties.Resources.Wire;
            btnWire2.Image = Properties.Resources.Wire;
            btnWire3.Image = Properties.Resources.Wire;
            btnWire4.Image = Properties.Resources.Wire;
            btnWire5.Image = Properties.Resources.Wire;
            btnWire6.Image = Properties.Resources.Wire;
            // randomise dangerwire
            GameVariables.BombWires.MakeDangerWire(GameVariables.BombWires);
            //reset the clock, clock speed, and restart the clock.
            TimeSpan reset = new TimeSpan(0,30,0);
            GameVariables.TimeLeft = reset;
            timer1.Interval = 1000;
            timer1.Start();

        }

        // Method called to close the program
        void EndTheGame()
        {
            Close();
        }

        //Method to check if game is muted and play sound
        private void PlaySound(UnmanagedMemoryStream soundFile)
        {
            //check if game is muted
            if (GameVariables.IsMuted){}
            else
            {
                System.Media.SoundPlayer player =
                    new System.Media.SoundPlayer(soundFile);
                player.Load();
                player.Play();
            }
        }
        //start of game message box text
        private void TheStory()

        {
            //set string variables
            string message = Properties.Resources.StoryText;
            string caption = "Bomb Defuser";
            //create basic message box with 
            MessageBox.Show(message, caption);
        }
    }
    public class GameVariables
    {
        
        public static TimeSpan TimeLeft = new TimeSpan(0, 30, 0);
        public static int GamesWon, GamesLost, GamesTotal;
        public static int TickSpeed = 1000;
        public static bool IsMuted;
        public static Wires BombWires = new Wires();
    }
}