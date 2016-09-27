using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jimmy
{
    public partial class Jimmy : Form
    {
        public Jimmy()
        {
            InitializeComponent();
        }

        private void Jimmy_Load(object sender, EventArgs e)
        {

        }

        private void Hello_Click(object sender, EventArgs e)
        {
            int milliseconds = 2000;
            DialogResult dialogResult = MessageBox.Show("A new friend?", "Hi im Jimmy", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("JIMMY: I always wanted a new friend");
                System.Threading.Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY: Will you play with me im lonely");
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("JIMMY: Why not? ");
                Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY: Jimmy MAD");
                Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY:Il just make you play my game");
            }

            dialogResult = MessageBox.Show("Lets Play Dungeon", "Hi im Jimmy", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("JIMMY: Ok youre in my dungeon");
                Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY: You have to escape");
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("JIMMY: I dont care so...");
                Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY:Ok youre in my dungeon ");
                Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY: You have to escape  ");

            }



        }

        private void button2_Click(object sender, EventArgs e)
        {

            int milliseconds = 2000;
            MessageBox.Show("JIMMY: Cancel if your a Chicken ");
            Thread.Sleep(milliseconds);
            DialogResult dialogResult = MessageBox.Show("DUNGEON TWO READY", "Hi im Jimmy", MessageBoxButtons.YesNoCancel);

            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("JIMMY: Your not a Chicken");
                Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY: You meet a man with two cups ");
                Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY: Yes: Sit with him");
                Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY: No: Sit with him");

            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("JIMMY: Chicken but you didnt press cancel stupid");
                Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY: You meet a man with two cups ");
                Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY: Yes: Sit with him");
                Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY: No: Sit with him");
            }
            MessageBox.Show("Sit?!", "Hi im Jimmy", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("JIMMY: He asks you to take  a drink ");
                System.Threading.Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY: Yes: Take the one on the left");
                Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY: No: Take the one on the right ");



            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("JIMMY: He asks you to take  a drink ");
                System.Threading.Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY: Yes: Take the one on the left");
                Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY: No: Take the one on the right ");
            }
            MessageBox.Show("Left or Right", "Hi im Jimmy", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("JIMMY: You take the left drink ");
                System.Threading.Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY: You die");
                Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY: Lol");
                Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY: GAME OVER");
                Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY: It was fun bye");



            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("JIMMY: You take the right drink ");
                System.Threading.Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY: Poor manners he says");
                Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY: Lol why is he pulling out a gun");
                Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY: GAME OVER");
                Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY: It was fun bye");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int milliseconds = 2000;
            DialogResult dialogResult = MessageBox.Show("ARE YOU READY", "Hi im Jimmy", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("JIMMY: Alright you have a sword and sheild");
                System.Threading.Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY: A skeleton archer charges at you what do you do");
                Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY: Yes: Charge at it with your sword");
                Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY: No: Charge at it with your sheild");

            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("JIMMY: Be a man is what my mom always tells me");
                Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY: Alright you have a sword and sheild");
                System.Threading.Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY: A skeleton archer  charges at you what do you do");
                Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY: Yes: Charge at it with your sword");
                Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY: No: Charge at it with your sheild");
            }
            MessageBox.Show("FIGHT", "Hi im Jimmy", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("JIMMY: You charged at it with your sword ");
                System.Threading.Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY: He shoots you in the face");
                Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY: GAME OVER ");
                Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY: Dont look at me you didnt tell me to input a swing after you got to him");
                Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY HAPPY");
                Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY:One more to go");

            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("JIMMY: You charged at him with your shield");
                Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY: Used Sheild Bash to kill archer");
                System.Threading.Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY: An assasin leaps from above thrusting his blade in your chest ");
                Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY: GAME OVER ");
                Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY: Lol you didnt ask if there was anything else");
                Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY HAPPY");
                Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY:One more to go");

            }
        }



    }
}

        

