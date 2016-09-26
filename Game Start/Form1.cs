/* Created by: Manuel Muncaster
 * Date: September 8, 2016
 * Purpose: Create a game start screen
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;


namespace Game_Start
{
    public partial class gamescreenState : Form
    {
        public gamescreenState()
        {
            InitializeComponent();
            gamestartsState.Visible = false;
            numberState.Visible = false;
            //gotextState.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SoundPlayer player = new SoundPlayer(Properties.Resources.alert);

            player.Play();
            buttonstartState.Visible = false;
            gamestartsState.Visible = true;
            numberState.Visible = true;
            Refresh();

            Thread.Sleep(1250);
            numberState.Text = "2";
            Refresh();

            Thread.Sleep(1250);
            numberState.Text = "1";
            Refresh();

            Thread.Sleep(1240);
            gamestartsState.Visible = false;
            numberState.Visible = false;
            //gotextState.Visible = true;

            Graphics formGraphics = this.CreateGraphics();
            Graphics fg= this.CreateGraphics();

            Font drawFont = new Font("Times New Roman", 125, FontStyle.Bold);
            Font ramsFont = new Font("Trebuchet", 30, FontStyle.Bold);
            Font ramsarcadeFont = new Font("Trebuchet", 10, FontStyle.Bold);

            Pen redPen = new Pen(Color.Red, 10);
            Pen whitePen = new Pen(Color.White, 10);

            SolidBrush redBrush = new SolidBrush(Color.Red);
            SolidBrush whiteBrush = new SolidBrush(Color.White);

            formGraphics.DrawEllipse(redPen, 40, 35, 200, 200);
            formGraphics.FillEllipse(redBrush, 40, 35, 200, 200);
            fg.DrawString("C", drawFont, whiteBrush, 45, 40);
            fg.DrawString("Rams", ramsFont, whiteBrush, 115, 115);

            fg.TranslateTransform(265, 90);
            fg.RotateTransform(90);
            fg.DrawString("Rams Arcade", ramsarcadeFont, whiteBrush, new Rectangle());
            fg.ResetTransform();

            Thread.Sleep(1250);
            formGraphics.Clear(Color.Black);
            Refresh();
            

            Pen bluePen = new Pen(Color.Blue, 10);
            Pen yellowPen = new Pen(Color.Yellow, 10);
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
            // Maze Lines
            formGraphics.DrawLine(bluePen, 0, 5, 260, 5);
            formGraphics.DrawLine(bluePen, 255, 5, 200, 25000);
            formGraphics.DrawLine(bluePen, 0, 90, 170, 90);
            formGraphics.DrawLine(bluePen, 164, 90, 200, 25000);
            // Pac-Man
            formGraphics.DrawArc(yellowPen, 5, 20, 50, 50, 30, 300);
            formGraphics.DrawPie(yellowPen, 5, 20, 50, 50, 30, 300);
            formGraphics.FillPie(yellowBrush, 5, 20, 50, 50, 30, 300);

            Thread.Sleep(1250);
            formGraphics.Clear(Color.Black);
            Refresh();

         


















        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
