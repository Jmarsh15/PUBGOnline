using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUBGOnline
{
    public partial class Form2 : Form
    {
        bool toggle1 = false;
        bool toggle2 = false;
        bool toggle3 = false;
        bool toggle4 = false;
        bool toggle5 = false;
        bool toggle6 = false;
        bool toggle7 = false;
        bool toggle8 = false;
        bool toggle9 = false;
        bool toggle10 = false;
        bool toggle11 = false;
        bool toggle12 = false;
        bool toggle13 = false;
        bool toggle14 = false;
        bool toggle15 = false;
        bool toggle16 = false;
        Form1 ths;
        Image eLeft = Properties.Resources.eliminateleft;
        Image eRight = Properties.Resources.eliminateright;

        public Form2(Form1 frm)
        {
            InitializeComponent();
            ths = frm;
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button_Load_Click(object sender, EventArgs e)
        {
            Image image =  Image.FromFile( @"C:\Users\Jmarsh\Desktop\PUBG\Team3.png");
            ths.Team1.ImageLocation = @"C:\Users\Jmarsh\Desktop\PUBG\Team1.png";
            ths.Team2.ImageLocation = @"C:\Users\Jmarsh\Desktop\PUBG\Team2.png";
            ths.Team3.ImageLocation = @"C:\Users\Jmarsh\Desktop\PUBG\Team2.png";
            ths.Team4.ImageLocation = @"C:\Users\Jmarsh\Desktop\PUBG\Team4.png";
            ths.Team5.ImageLocation = @"C:\Users\Jmarsh\Desktop\PUBG\Team5.png";
            ths.Team6.ImageLocation = @"C:\Users\Jmarsh\Desktop\PUBG\Team6.png";
            ths.Team7.ImageLocation = @"C:\Users\Jmarsh\Desktop\PUBG\Team7.png";
            ths.Team8.ImageLocation = @"C:\Users\Jmarsh\Desktop\PUBG\Team8.png";
            ths.pictureBox17.ImageLocation = @"C:\Users\Jmarsh\Desktop\PUBG\Team9.png";
            ths.Team10.ImageLocation = @"C:\Users\Jmarsh\Desktop\PUBG\Team10.png";
            ths.Team11.ImageLocation = @"C:\Users\Jmarsh\Desktop\PUBG\Team11.png";
            ths.Team12.ImageLocation = @"C:\Users\Jmarsh\Desktop\PUBG\Team12.png";
            ths.Team13.ImageLocation = @"C:\Users\Jmarsh\Desktop\PUBG\Team13.png";
            ths.Team14.ImageLocation = @"C:\Users\Jmarsh\Desktop\PUBG\Team14.png";
            ths.Team15.ImageLocation = @"C:\Users\Jmarsh\Desktop\PUBG\Team15.png";
            ths.Team16.ImageLocation = @"C:\Users\Jmarsh\Desktop\PUBG\Team16.png";
        }

        private void b_1E_Click(object sender, EventArgs e)
        {
           if (toggle1 == false)
           {
               ths.Team1e.Image = eLeft;
               toggle1 = true;
           }
           else 
           {
               ths.Team1e.Image = null;
               toggle1 = false;
           }
        }

        private void b_2E_Click(object sender, EventArgs e)
        {
            
            if (toggle2 == false)
            {
                ths.Update();
                toggle2 = true;
            }
            else
            {
                ths.Team2e.Image = null;
                toggle2 = false;
            }
        }

        private void b_3E_Click(object sender, EventArgs e)
        {
            if (toggle3 == false)
            {
                ths.Team3e.Image = eLeft;
                toggle3 = true;
            }
            else
            {
                ths.Team3e.Image = null;
                toggle3 = false;
            }
        }

        private void b_4E_Click(object sender, EventArgs e)
        {
            if (toggle4 == false)
            {
                ths.Team4e.Parent = ths.Team4;
                ths.Team4e.Image = eLeft;
                toggle4 = true;
            }
            else
            {
                ths.Team4e.Image = null;
                toggle4 = false;
            }
        }

        private void b_5E_Click(object sender, EventArgs e)
        {
            if (toggle5 == false)
            {
                ths.Team5e.Image = eLeft;
                toggle5 = true;
            }
            else
            {
                ths.Team5e.Image = null;
                toggle5 = false;
            }
        }

        private void b_6E_Click(object sender, EventArgs e)
        {
            if (toggle6 == false)
            {
                ths.Team6e.Image = eLeft;
                toggle6 = true;
            }
            else
            {
                ths.Team6e.Image = null;
                toggle6 = false;
            }
        }

        private void b_7E_Click(object sender, EventArgs e)
        {
            if (toggle7 == false)
            {
                ths.Team7e.Image = eLeft;
                toggle7 = true;
            }
            else
            {
                ths.Team7e.Image = null;
                toggle7 = false;
            }
        }

        private void b_8E_Click(object sender, EventArgs e)
        {
            if (toggle8 == false)
            {
                ths.Team8e.Image = eLeft;
                toggle8 = true;
            }
            else
            {
                ths.Team8e.Image = null;
                toggle8 = false;
            }
        }

        private void b_9E_Click(object sender, EventArgs e)
        {
            if (toggle9 == false)
            {
                ths.pictureBox17.ImageLocation = @"C:\Users\Jmarsh\Desktop\PUBG\eliminateright.jpg";
                toggle9 = true;
            }
            else
            {
                ths.pictureBox17.ImageLocation = @"C:\Users\Jmarsh\Desktop\PUBG\Team9.jpg";
                toggle9 = false;
            }
        }

        private void b_10E_Click(object sender, EventArgs e)
        {
            if (toggle10 == false)
            {
                ths.Team10.ImageLocation = @"C:\Users\Jmarsh\Desktop\PUBG\eliminateright.jpg";
                toggle10 = true;
            }
            else
            {
                ths.Team10.ImageLocation = @"C:\Users\Jmarsh\Desktop\PUBG\Team10.jpg";
                toggle10 = false;
            }
        }

        private void b_11E_Click(object sender, EventArgs e)
        {
            if (toggle11 == false)
            {
                ths.Team11.ImageLocation = @"C:\Users\Jmarsh\Desktop\PUBG\eliminateright.jpg";
                toggle11 = true;
            }
            else
            {
                ths.Team11.ImageLocation = @"C:\Users\Jmarsh\Desktop\PUBG\Team11.jpg";
                toggle11 = false;
            }
        }

        private void b_12E_Click(object sender, EventArgs e)
        {
            if (toggle12 == false)
            {
                ths.Team12.ImageLocation = @"C:\Users\Jmarsh\Desktop\PUBG\eliminateright.jpg";
                toggle12 = true;
            }
            else
            {
                ths.Team12.ImageLocation = @"C:\Users\Jmarsh\Desktop\PUBG\Team12.jpg";
                toggle12 = false;
            }
        }

        private void b_13E_Click(object sender, EventArgs e)
        {
            if (toggle13 == false)
            {
                ths.Team13.ImageLocation = @"C:\Users\Jmarsh\Desktop\PUBG\eliminateright.jpg";
                toggle13 = true;
            }
            else
            {
                ths.Team13.ImageLocation = @"C:\Users\Jmarsh\Desktop\PUBG\Team13.jpg";
                toggle13 = false;
            }
        }

        private void b_14E_Click(object sender, EventArgs e)
        {
            if (toggle14 == false)
            {
                ths.Team14.ImageLocation = @"C:\Users\Jmarsh\Desktop\PUBG\eliminateright.jpg";
                toggle14 = true;
            }
            else
            {
                ths.Team14.ImageLocation = @"C:\Users\Jmarsh\Desktop\PUBG\Team14.jpg";
                toggle14 = false;
            }
        }

        private void b_15E_Click(object sender, EventArgs e)
        {
            if (toggle15 == false)
            {
                ths.Team15.ImageLocation = @"C:\Users\Jmarsh\Desktop\PUBG\eliminateright.jpg";
                toggle15 = true;
            }
            else
            {
                ths.Team15.ImageLocation = @"C:\Users\Jmarsh\Desktop\PUBG\Team15.jpg";
                toggle15 = false;
            }
        }

        private void b_16E_Click(object sender, EventArgs e)
        {
            if (toggle16 == false)
            {
                ths.Team16.ImageLocation = @"C:\Users\Jmarsh\Desktop\PUBG\eliminateright.jpg";
                toggle16 = true;
            }
            else
            {
                ths.Team16.ImageLocation = @"C:\Users\Jmarsh\Desktop\PUBG\Team16.jpg";
                toggle16 = false;
            }
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            ths.Team1.ImageLocation = @"C:\Users\Jmarsh\Desktop\PUBG\Team1.png";
            ths.Team2.ImageLocation = @"C:\Users\Jmarsh\Desktop\PUBG\Team2.png";
            ths.Team3.ImageLocation = @"C:\Users\Jmarsh\Desktop\PUBG\Team3.png";
            ths.Team4.ImageLocation = @"C:\Users\Jmarsh\Desktop\PUBG\Team4.png";
            ths.Team5.ImageLocation = @"C:\Users\Jmarsh\Desktop\PUBG\Team5.png";
            ths.Team6.ImageLocation = @"C:\Users\Jmarsh\Desktop\PUBG\Team6.png";
            ths.Team7.ImageLocation = @"C:\Users\Jmarsh\Desktop\PUBG\Team7.png";
            ths.Team8.ImageLocation = @"C:\Users\Jmarsh\Desktop\PUBG\Team8.png";
            ths.pictureBox17.ImageLocation = @"C:\Users\Jmarsh\Desktop\PUBG\Team9.png";
            ths.Team10.ImageLocation = @"C:\Users\Jmarsh\Desktop\PUBG\Team10.png";
            ths.Team11.ImageLocation = @"C:\Users\Jmarsh\Desktop\PUBG\Team11.png";
            ths.Team12.ImageLocation = @"C:\Users\Jmarsh\Desktop\PUBG\Team12.png";
            ths.Team13.ImageLocation = @"C:\Users\Jmarsh\Desktop\PUBG\Team13.png";
            ths.Team14.ImageLocation = @"C:\Users\Jmarsh\Desktop\PUBG\Team14.png";
            ths.Team15.ImageLocation = @"C:\Users\Jmarsh\Desktop\PUBG\Team15.png";
            ths.Team16.ImageLocation = @"C:\Users\Jmarsh\Desktop\PUBG\Team16.png";
            toggle1 = false;
            toggle2 = false;
            toggle3 = false;
            toggle4 = false;
            toggle5 = false;
            toggle6 = false;
            toggle7 = false;
            toggle8 = false;
            toggle9 = false;
            toggle10 = false;
            toggle11 = false;
            toggle12 = false;
            toggle13 = false;
            toggle14 = false;
            toggle15 = false;
            toggle16 = false;
        }
    }
}
