/// Reid Ball
/// November 10 2016 
/// Very simple dating simulator. 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReidsAdventureSummative
{
    public partial class Form1 : Form
    {
        Random randGen = new Random();

        int scene = 0;  // tracks what part of the game the user is at
        string dateName; //determines what picture will be displayed
        int chance; //determines the outcome of random encounters

        public Form1()
        {
            InitializeComponent();

            //displays beginning scene description and options
            outputLabel.Text = "You downloaded a dating app and see you have gotten three matches at the end of the day."
                + " Who do you ask out?";
            redLabel.Text = "Jessica.";
            blueLabel.Text = "Marie.";
            greenLabel.Text = "Zoe.";
            outputPictureBox.Image = Properties.Resources.scene_0_image;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            /// check to see what button has been pressed and advance
            /// to the next appropriate scene
            if (e.KeyCode == Keys.M)       //red button press
            {
                if (scene == 0)
                {
                    dateName = "Jessica";
                    scene = 1;
                }
                else if (scene == 1)
                {
                    int chance = randGen.Next(1, 101);

                    if (chance < 90)
                    {
                        scene = 2;
                    }
                    else
                    {
                        scene = 18;
                    }
                }
                else if (scene == 2)
                {
                    scene = 4;
                }
                else if (scene == 4)
                {
                    scene = 8;
                }
                else if (scene == 5)
                {
                    if (chance < 90)
                    {
                        scene = 9;
                    }
                    else
                    {
                        scene = 17;
                    }
                }
                else if (scene == 3)
                {
                    scene = 6;
                }
                else if (scene == 6)
                {
                    scene = 12;
                }
                else if (scene == 7)
                {
                    scene = 15;
                }
                else if (scene == 8)
                {
                    scene = 20;
                }
                else if (scene == 9)
                {
                    scene = 20;
                }
                else if (scene == 10)
                {
                    scene = 19;
                }
                else if (scene == 11)
                {
                    scene = 20;
                }
                else if (scene == 12)
                {
                    scene = 20;
                }
                else if (scene == 13)
                {
                    scene = 20;
                }
                else if (scene == 14)
                {
                    scene = 20;
                }
                else if (scene == 15)
                {
                    scene = 19;
                }
                else if (scene == 16)
                {
                    scene = 20;
                }
                else if (scene == 17)
                {
                    scene = 19;
                }
                else if (scene == 18)
                {
                    scene = 20;
                }
                else if (scene == 19)
                {
                    scene = 0;
                }
                else if (scene == 20)
                {
                    scene = 0;
                }
            }
            else if (e.KeyCode == Keys.B)  //blue button press
            {
                if (scene == 0)
                {
                    dateName = "Marie";
                    scene = 1;
                }
                else if (scene == 1)
                {
                    int chance = randGen.Next(1, 101);

                    if (chance < 90)
                    {
                        scene = 3;
                    }
                    else
                    {
                        scene = 18;
                    }
                }
                else if (scene == 2)
                {
                    scene = 5;
                }
                else if (scene == 3)
                {
                    scene = 7;
                }
                else if (scene == 4)
                {
                    scene = 5;
                }
                else if (scene == 5)
                {
                    scene = 10;
                }
                else if (scene == 7)
                {
                    scene = 16;
                }
                else if (scene == 19)
                {
                    Application.Exit();
                }
                else if (scene == 20)
                {
                    Application.Exit();
                }
            }
            else if (e.KeyCode == Keys.H) //green button press
            {
                if (scene == 0)
                {
                    dateName = "Zoe";
                    scene = 1;
                }
                else if (scene == 5)
                {
                    scene = 11;
                }
                else if (scene == 6)
                {
                    scene = 14;
                }
            }

            /// Displays the text, image, and game options to screen depending on the current value of scene
            switch (scene)
            {
                case 0:  //start scene 
                    outputLabel.Text = "You downloaded a dating app and see you have gotten" +
                        " three matches at the end of the day. Who do you ask out?";
                    redLabel.Text = "Zoe.";
                    blueLabel.Text = "Marie.";
                    greenImage.Visible = true;
                    greenLabel.Visible = true;
                    greenLabel.Text = "Jessica.";
                    outputPictureBox.Image = Properties.Resources.scene_0_image;
                    break;
                case 1:
                    outputLabel.Text = "Do you ask her to the go to the festival or on a walk in the park?";
                    redLabel.Text = "Walk in the park.";
                    blueLabel.Text = "Festival.";
                    greenImage.Visible = false;
                    greenLabel.Visible = false;
                    if (dateName == "Jessica")
                    {
                        outputPictureBox.Image = Properties.Resources.park_jessica;
                    }
                    else if (dateName == "Marie")
                    {
                        outputPictureBox.Image = Properties.Resources.park_marie;
                    }
                    else
                    {
                        outputPictureBox.Image = Properties.Resources.park_zoe;
                    }
                    break;
                case 2:
                    outputLabel.Text = "You find her where you agreed to meet, and after some"
                        + " small talk you ask if she wants to feed the ducks or walk on the path through the park";
                    redLabel.Text = "Feed the ducks.";
                    blueLabel.Text = "Walk the path.";
                    if (dateName == "Jessica")
                    {
                        outputPictureBox.Image = Properties.Resources.park_jessica;
                    }
                    else if (dateName == "Marie")
                    {
                        outputPictureBox.Image = Properties.Resources.park_marie;
                    }
                    else
                    {
                        outputPictureBox.Image = Properties.Resources.park_zoe;
                    }
                    break;
                case 3:
                    outputLabel.Text = "You find her where you agreed to meet, and after some small talk"
                        + " you ask if she wants to __?";
                    blueLabel.Text = "Get food.";
                    redLabel.Text = "Watch a performance.";
                    if (dateName == "Jessica")
                    {
                        outputPictureBox.Image = Properties.Resources.carnival_neutral_jessica;
                    }
                    else if (dateName == "Marie")
                    {
                        outputPictureBox.Image = Properties.Resources.carnival_marie;
                    }
                    else
                    {
                        outputPictureBox.Image = Properties.Resources.carnival_zoe;
                    }
                    break;
                case 4:
                    outputLabel.Text = "She says shes actually scared of ducks and ask if you can do"
                        + " something else instead. What do you choose to do?";
                    blueLabel.Text = "Walk the path.";
                    redLabel.Text = "Leave.";
                    if (dateName == "Jessica")
                    {
                        outputPictureBox.Image = Properties.Resources.blushing_park_jessica;
                    }
                    else if (dateName == "Marie")
                    {
                        outputPictureBox.Image = Properties.Resources.happy_park_marie;
                    }
                    else
                    {
                        outputPictureBox.Image = Properties.Resources.blush_park_zoe;
                    }
                    break;
                case 5:
                    outputLabel.Text = "You start walking the path and while conversing with her you want to hold her hand, do you do it?";
                    greenImage.Visible = true;
                    greenLabel.Visible = true;
                    redLabel.Text = "Hold it without asking.";
                    blueLabel.Text = "Ask to hold it.";
                    greenLabel.Text = "Dont bother.";
                    if (dateName == "Jessica")
                    {
                        outputPictureBox.Image = Properties.Resources.park_jessica;
                    }
                    else if (dateName == "Marie")
                    {
                        outputPictureBox.Image = Properties.Resources.park_marie;
                    }
                    else
                    {
                        outputPictureBox.Image = Properties.Resources.park_zoe;
                    }
                    break;
                case 6:
                    outputLabel.Text = "She says yes, but ask you to decide which performance to watch. What performance do you pick?";
                    greenImage.Visible = true;
                    greenLabel.Visible = true;
                    redLabel.Text = "The magic show.";
                    blueLabel.Text = "The fire dancing performance.";
                    greenLabel.Text = "The choir performance.";
                    break;
                case 7:
                    outputLabel.Text = "She says she is starving but doesnt know what type of food to get and ask you to decide.";
                    blueLabel.Text = "Corn Dogs.";
                    redLabel.Text = "Cotton Candy.";
                    break;
                case 8:
                    outputLabel.Text = "You left the date because you were very determined to feed the ducks.";
                    blueLabel.Visible = false;
                    blueImage.Visible = false;
                    redLabel.Text = "Continue.";
                    if (dateName == "Jessica")
                    {
                        outputPictureBox.Image = Properties.Resources.angry_park_jessica;
                    }
                    else if (dateName == "Marie")
                    {
                        outputPictureBox.Image = Properties.Resources.mad_park_marie;
                    }
                    else
                    {
                        outputPictureBox.Image = Properties.Resources.angry_park_zoe;
                    }
                    break;
                case 9:
                    outputLabel.Text = "She slaps you for trying to touch her and storms off, leaving you alone on the path.";
                    blueImage.Visible = false;
                    blueLabel.Visible = false;
                    greenLabel.Visible = false;
                    greenImage.Visible = false;
                    redLabel.Text = "Continue.";
                    if (dateName == "Jessica")
                    {
                        outputPictureBox.Image = Properties.Resources.angry_park_jessica;
                    }
                    else if (dateName == "Marie")
                    {
                        outputPictureBox.Image = Properties.Resources.mad_park_marie;
                    }
                    else
                    {
                        outputPictureBox.Image = Properties.Resources.angry_park_zoe;
                    }
                    break;
                case 10:
                    outputLabel.Text = "She blushes and agrees to hold your hand and after some more small talk you reach the end of the path."
                        + " You say your goodbyes and part ways";
                    blueLabel.Visible = false;
                    blueImage.Visible = false;
                    greenLabel.Visible = false;
                    greenImage.Visible = false;
                    redLabel.Text = "Continue.";
                    if (dateName == "Jessica")
                    {
                        outputPictureBox.Image = Properties.Resources.blushing_park_jessica;
                    }
                    else if (dateName == "Marie")
                    {
                        outputPictureBox.Image = Properties.Resources.happy_park_marie;
                    }
                    else
                    {
                        outputPictureBox.Image = Properties.Resources.blush_park_zoe;
                    }
                    break;
                case 11:
                    outputLabel.Text = "You decide not to hold her hand and after some more small talk you reach the end of the path."
                        + " When you reach the end you say your goodbyes and part ways.";
                    blueLabel.Visible = false;
                    blueImage.Visible = false;
                    greenLabel.Visible = false;
                    greenImage.Visible = false;
                    redLabel.Text = "Continue.";
                    break;
                case 12:
                    outputLabel.Text = "You watch the performance but at the end she says she had a very good time and would love to see you again.";
                    blueLabel.Visible = false;
                    blueImage.Visible = false;
                    greenLabel.Visible = false;
                    greenImage.Visible = false;
                    redLabel.Text = "Continue.";
                    if (dateName == "Jessica")
                    {
                        outputPictureBox.Image = Properties.Resources.winning_end_game_jessica;
                    }
                    else if (dateName == "Marie")
                    {
                        outputPictureBox.Image = Properties.Resources.endgame_win_carnival_marie;
                    }
                    else
                    {
                        outputPictureBox.Image = Properties.Resources.win_carnival_zoe;
                    }
                    break;
                case 13:
                    outputLabel.Text = "You watch the performance but at the end she says would have rather seen the choir and then you say your goodbyes.";
                    blueLabel.Visible = false;
                    blueImage.Visible = false;
                    greenLabel.Visible = false;
                    greenImage.Visible = false;
                    redLabel.Text = "Continue.";
                    if (dateName == "Jessica")
                    {
                        outputPictureBox.Image = Properties.Resources.winning_end_game_jessica;
                    }
                    else if (dateName == "Marie")
                    {
                        outputPictureBox.Image = Properties.Resources.endgame_win_carnival_marie;
                    }
                    else
                    {
                        outputPictureBox.Image = Properties.Resources.win_carnival_zoe;
                    }
                    break;
                case 14:
                    outputLabel.Text = "Omce the performance finishes she thanks you for the wonderful night, she also tells you to keep an eye on your inbox.";
                    blueLabel.Visible = false;
                    blueImage.Visible = false;
                    greenLabel.Visible = false;
                    greenImage.Visible = false;
                    redLabel.Text = "Continue.";
                    if (dateName == "Jessica")
                    {
                        outputPictureBox.Image = Properties.Resources.winning_end_game_jessica;
                    }
                    else if (dateName == "Marie")
                    {
                        outputPictureBox.Image = Properties.Resources.endgame_win_carnival_marie;
                    }
                    else
                    {
                        outputPictureBox.Image = Properties.Resources.win_carnival_zoe;
                    }
                    break;
                case 15:
                    outputLabel.Text = "You ask her if she wants to get cotton candy and she says that sound great." +
                        " After you get the cotton candy you walk and talk around the festival looking at the displays and shops."
                        + " At the end she says she thanks you for everything and gives you a hug.";
                    blueLabel.Visible = false;
                    blueImage.Visible = false;
                    redLabel.Text = "Continue.";
                    if (dateName == "Jessica")
                    {
                        outputPictureBox.Image = Properties.Resources.winning_end_game_jessica;
                    }
                    else if (dateName == "Marie")
                    {
                        outputPictureBox.Image = Properties.Resources.endgame_win_carnival_marie;
                    }
                    else
                    {
                        outputPictureBox.Image = Properties.Resources.win_carnival_zoe;
                    }
                    break;
                case 16:
                    outputLabel.Text = "You get the corn dogs and she says she would've prefered something sweet. You walk around the festival looking at everything with her and having  really nice conversations, "
                        + " She thanks you for the corndog and goodtime, and then she hugs you.";
                    blueLabel.Visible = false;
                    blueImage.Visible = false;
                    redLabel.Text = "Continue.";
                    if (dateName == "Jessica")
                    {
                        outputPictureBox.Image = Properties.Resources.winning_end_game_jessica;
                    }
                    else if (dateName == "Marie")
                    {
                        outputPictureBox.Image = Properties.Resources.endgame_win_carnival_marie;
                    }
                    else
                    {
                        outputPictureBox.Image = Properties.Resources.win_carnival_zoe;
                    }
                    break;
                case 17:
                    outputLabel.Text = "She blushes and you continue walking the path with her until you reach the end. "
                        + " You say your goodbyes and she hugs you.";
                    blueLabel.Visible = false;
                    blueImage.Visible = false;
                    greenLabel.Visible = false;
                    greenImage.Visible = false;
                    redLabel.Text = "Continue.";
                    if (dateName == "Jessica")
                    {
                        outputPictureBox.Image = Properties.Resources.blushing_park_jessica;
                    }
                    else if (dateName == "Marie")
                    {
                        outputPictureBox.Image = Properties.Resources.happy_park_marie;
                    }
                    else
                    {
                        outputPictureBox.Image = Properties.Resources.blush_park_zoe;
                    }
                    break;
                case 18:
                    outputLabel.Text = "She never showed up, and you waited for over an hour. You go home and cry.";
                    blueLabel.Visible = false;
                    blueImage.Visible = false;
                    redLabel.Text = "Continue.";
                    break;
                case 19:
                    outputLabel.Text = "When you get home shes sent you a message saying that she had a great time"
                        + " and would love to see you again. Would you like to play again?";
                    redLabel.Text = "Play again.";
                    blueImage.Visible = true;
                    blueLabel.Visible = true;
                    blueLabel.Text = "Exit.";
                    outputPictureBox.Image = Properties.Resources.scene_0_image;
                    break;
                case 20:
                    outputLabel.Text = "You wait for days after the date hoping for a message from her"
                        + " but you never get one. Would you like to play again?";
                    redLabel.Text = "Play again.";
                    blueImage.Visible = true;
                    blueLabel.Visible = true;
                    blueLabel.Text = "Exit.";
                    outputPictureBox.Image = Properties.Resources.scene_0_image;
                    break;
                default:
                    break;
            }
        }

    }
}
