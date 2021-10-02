using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe__Tut
{
    public partial class Form1 : Form
    {
        Boolean Checker;
        int PlusOne;
        void BoxNotWork()
        {
            Box1.Enabled = false;
            Box2.Enabled = false;
            Box3.Enabled = false;
            Box4.Enabled = false;
            Box5.Enabled = false;
            Box6.Enabled = false;
            Box7.Enabled = false;
            Box8.Enabled = false;
            Box9.Enabled = false;
        }
        void BoxWork()
        {
            Box1.Enabled = true;
            Box2.Enabled = true;
            Box3.Enabled = true;
            Box4.Enabled = true;
            Box5.Enabled = true;
            Box6.Enabled = true;
            Box7.Enabled = true;
            Box8.Enabled = true;
            Box9.Enabled = true;
        }
        void ResetBox()
        {
            Box1.Image = BoxReset.Image;
            Box2.Image = BoxReset.Image;
            Box3.Image = BoxReset.Image;
            Box4.Image = BoxReset.Image;
            Box5.Image = BoxReset.Image;
            Box6.Image = BoxReset.Image;
            Box7.Image = BoxReset.Image;
            Box8.Image = BoxReset.Image;
            Box9.Image = BoxReset.Image;
            Box1.BackColor = Color.FromArgb(50, 50, 50);
            Box2.BackColor = Color.FromArgb(50, 50, 50);
            Box3.BackColor = Color.FromArgb(50, 50, 50);
            Box4.BackColor = Color.FromArgb(50, 50, 50);
            Box5.BackColor = Color.FromArgb(50, 50, 50);
            Box6.BackColor = Color.FromArgb(50, 50, 50);
            Box7.BackColor = Color.FromArgb(50, 50, 50);
            Box8.BackColor = Color.FromArgb(50, 50, 50);
            Box9.BackColor = Color.FromArgb(50, 50, 50);
        }
        // Sound Play
        void SoundMultiply1()
        {
            using (var soundPlayer = new SoundPlayer(@"C:\Windows\TicTacToe\Audio File\Multiply1.wav"))
            {
                soundPlayer.Play();
            }
        }
        void SoundCircle1()
        {
            using (var soundPlayer = new SoundPlayer(@"C:\Windows\TicTacToe\Audio File\Circle1.wav"))
            {
                soundPlayer.Play();
            }
        }
        void SoundMultiply()
        {
            using (var soundPlayer = new SoundPlayer(@"C:\Windows\TicTacToe\Audio File\Multiply.wav"))
            {
                soundPlayer.Play();
            }
        }
        void SoundCircle()
        {
            using (var soundPlayer = new SoundPlayer(@"C:\Windows\TicTacToe\Audio File\Circle.wav"))
            {
                soundPlayer.Play();
            }
        }
        void SoundDraw()
        {
            using (var soundPlayer = new SoundPlayer(@"C:\Windows\TicTacToe\Audio File\Draw.wav"))
            {
                soundPlayer.Play();
            }
        }
        // Go for Different Forms Show
        void MessageMultiplyShow()
        {
            MessageMultiply messageMultiply = new MessageMultiply();
            messageMultiply.ShowDialog();
        }
        void MessageCircleShow()
        {
            MessageCircle messageCircle = new MessageCircle();
            messageCircle.ShowDialog();
        }
        void MessageDrawShow()
        {
            MessageDraw messageDraw = new MessageDraw();
            messageDraw.ShowDialog();
        }
        void StartNewGameMessageShow()
        {
            StartNewGameMessage startNewGameMessage = new StartNewGameMessage();
            startNewGameMessage.ShowDialog();
        }
        void ExitShow()
        {
            Exit ShowExit = new Exit();
            ShowExit.ShowDialog();
        }
        // That Count Score
        void Score()
        {
            // Player Multiply Wins ====
            if (Box1.Image == PicMultiply.Image && Box2.Image == PicMultiply.Image && Box3.Image == PicMultiply.Image)
            {
                Box1.BackColor = Color.FromArgb(20, 0, 185, 255);
                Box2.BackColor = Color.FromArgb(20, 0, 185, 255);
                Box3.BackColor = Color.FromArgb(20, 0, 185, 255);
                SoundMultiply();
                MessageMultiplyShow();
                PlusOne = int.Parse(MultiplyScore.Text);
                MultiplyScore.Text = Convert.ToString(PlusOne + 1);
                BoxNotWork();
            }
            else if (Box4.Image == PicMultiply.Image && Box5.Image == PicMultiply.Image && Box6.Image == PicMultiply.Image)
            {
                Box4.BackColor = Color.FromArgb(20, 0, 185, 255);
                Box5.BackColor = Color.FromArgb(20, 0, 185, 255);
                Box6.BackColor = Color.FromArgb(20, 0, 185, 255);
                SoundMultiply();
                MessageMultiplyShow();
                PlusOne = int.Parse(MultiplyScore.Text);
                MultiplyScore.Text = Convert.ToString(PlusOne + 1);
                BoxNotWork();
            }
            else if (Box7.Image == PicMultiply.Image && Box8.Image == PicMultiply.Image && Box9.Image == PicMultiply.Image)
            {
                Box7.BackColor = Color.FromArgb(20, 0, 185, 255);
                Box8.BackColor = Color.FromArgb(20, 0, 185, 255);
                Box9.BackColor = Color.FromArgb(20, 0, 185, 255);
                SoundMultiply();
                MessageMultiplyShow();
                PlusOne = int.Parse(MultiplyScore.Text);
                MultiplyScore.Text = Convert.ToString(PlusOne + 1);
                BoxNotWork();
            }
            else if (Box1.Image == PicMultiply.Image && Box4.Image == PicMultiply.Image && Box7.Image == PicMultiply.Image)
            {
                Box1.BackColor = Color.FromArgb(20, 0, 185, 255);
                Box4.BackColor = Color.FromArgb(20, 0, 185, 255);
                Box7.BackColor = Color.FromArgb(20, 0, 185, 255);
                SoundMultiply();
                MessageMultiplyShow();
                PlusOne = int.Parse(MultiplyScore.Text);
                MultiplyScore.Text = Convert.ToString(PlusOne + 1);
                BoxNotWork();
            }
            else if (Box2.Image == PicMultiply.Image && Box5.Image == PicMultiply.Image && Box8.Image == PicMultiply.Image)
            {
                Box2.BackColor = Color.FromArgb(20, 0, 185, 255);
                Box5.BackColor = Color.FromArgb(20, 0, 185, 255);
                Box8.BackColor = Color.FromArgb(20, 0, 185, 255);
                SoundMultiply();
                MessageMultiplyShow();
                PlusOne = int.Parse(MultiplyScore.Text);
                MultiplyScore.Text = Convert.ToString(PlusOne + 1);
                BoxNotWork();
            }
            else if (Box3.Image == PicMultiply.Image && Box6.Image == PicMultiply.Image && Box9.Image == PicMultiply.Image)
            {
                Box3.BackColor = Color.FromArgb(20, 0, 185, 255);
                Box6.BackColor = Color.FromArgb(20, 0, 185, 255);
                Box9.BackColor = Color.FromArgb(20, 0, 185, 255);
                SoundMultiply();
                MessageMultiplyShow();
                PlusOne = int.Parse(MultiplyScore.Text);
                MultiplyScore.Text = Convert.ToString(PlusOne + 1);
                BoxNotWork();
            }
            else if (Box1.Image == PicMultiply.Image && Box5.Image == PicMultiply.Image && Box9.Image == PicMultiply.Image)
            {
                Box1.BackColor = Color.FromArgb(20, 0, 185, 255);
                Box5.BackColor = Color.FromArgb(20, 0, 185, 255);
                Box9.BackColor = Color.FromArgb(20, 0, 185, 255);
                SoundMultiply();
                MessageMultiplyShow();
                PlusOne = int.Parse(MultiplyScore.Text);
                MultiplyScore.Text = Convert.ToString(PlusOne + 1);
                BoxNotWork();
            }
            else if (Box3.Image == PicMultiply.Image && Box5.Image == PicMultiply.Image && Box7.Image == PicMultiply.Image)
            {
                Box3.BackColor = Color.FromArgb(20, 0, 185, 255);
                Box5.BackColor = Color.FromArgb(20, 0, 185, 255);
                Box7.BackColor = Color.FromArgb(20, 0, 185, 255);
                SoundMultiply();
                MessageMultiplyShow();
                PlusOne = int.Parse(MultiplyScore.Text);
                MultiplyScore.Text = Convert.ToString(PlusOne + 1);
                BoxNotWork();
            }
            // Player Circle Wins ====
            else if (Box1.Image == PicCircle.Image && Box2.Image == PicCircle.Image && Box3.Image == PicCircle.Image)
            {
                Box1.BackColor = Color.FromArgb(20, 250, 49, 74);
                Box2.BackColor = Color.FromArgb(20, 250, 49, 74);
                Box3.BackColor = Color.FromArgb(20, 250, 49, 74);
                SoundCircle();
                MessageCircleShow();
                PlusOne = int.Parse(CircleScore.Text);
                CircleScore.Text = Convert.ToString(PlusOne + 1);
                BoxNotWork();
            }
            else if (Box4.Image == PicCircle.Image && Box5.Image == PicCircle.Image && Box6.Image == PicCircle.Image)
            {
                Box4.BackColor = Color.FromArgb(20, 250, 49, 74);
                Box5.BackColor = Color.FromArgb(20, 250, 49, 74);
                Box6.BackColor = Color.FromArgb(20, 250, 49, 74);
                SoundCircle();
                MessageCircleShow();
                PlusOne = int.Parse(CircleScore.Text);
                CircleScore.Text = Convert.ToString(PlusOne + 1);
                BoxNotWork();
            }
            else if (Box7.Image == PicCircle.Image && Box8.Image == PicCircle.Image && Box9.Image == PicCircle.Image)
            {
                Box7.BackColor = Color.FromArgb(20, 250, 49, 74);
                Box8.BackColor = Color.FromArgb(20, 250, 49, 74);
                Box9.BackColor = Color.FromArgb(20, 250, 49, 74);
                SoundCircle();
                MessageCircleShow();
                PlusOne = int.Parse(CircleScore.Text);
                CircleScore.Text = Convert.ToString(PlusOne + 1);
                BoxNotWork();
            }
            else if (Box1.Image == PicCircle.Image && Box4.Image == PicCircle.Image && Box7.Image == PicCircle.Image)
            {
                Box1.BackColor = Color.FromArgb(20, 250, 49, 74);
                Box4.BackColor = Color.FromArgb(20, 250, 49, 74);
                Box7.BackColor = Color.FromArgb(20, 250, 49, 74);
                SoundCircle();
                MessageCircleShow();
                PlusOne = int.Parse(CircleScore.Text);
                CircleScore.Text = Convert.ToString(PlusOne + 1);
                BoxNotWork();
            }
            else if (Box2.Image == PicCircle.Image && Box5.Image == PicCircle.Image && Box8.Image == PicCircle.Image)
            {
                Box2.BackColor = Color.FromArgb(20, 250, 49, 74);
                Box5.BackColor = Color.FromArgb(20, 250, 49, 74);
                Box8.BackColor = Color.FromArgb(20, 250, 49, 74);
                SoundCircle();
                MessageCircleShow();
                PlusOne = int.Parse(CircleScore.Text);
                CircleScore.Text = Convert.ToString(PlusOne + 1);
                BoxNotWork();
            }
            else if (Box3.Image == PicCircle.Image && Box6.Image == PicCircle.Image && Box9.Image == PicCircle.Image)
            {
                Box3.BackColor = Color.FromArgb(20, 250, 49, 74);
                Box6.BackColor = Color.FromArgb(20, 250, 49, 74);
                Box9.BackColor = Color.FromArgb(20, 250, 49, 74);
                SoundCircle();
                MessageCircleShow();
                PlusOne = int.Parse(CircleScore.Text);
                CircleScore.Text = Convert.ToString(PlusOne + 1);
                BoxNotWork();
            }
            else if (Box1.Image == PicCircle.Image && Box5.Image == PicCircle.Image && Box9.Image == PicCircle.Image)
            {
                Box1.BackColor = Color.FromArgb(20, 250, 49, 74);
                Box5.BackColor = Color.FromArgb(20, 250, 49, 74);
                Box9.BackColor = Color.FromArgb(20, 250, 49, 74);
                SoundCircle();
                MessageCircleShow();
                PlusOne = int.Parse(CircleScore.Text);
                CircleScore.Text = Convert.ToString(PlusOne + 1);
                BoxNotWork();
            }
            else if (Box3.Image == PicCircle.Image && Box5.Image == PicCircle.Image && Box7.Image == PicCircle.Image)
            {
                Box3.BackColor = Color.FromArgb(20, 250, 49, 74);
                Box5.BackColor = Color.FromArgb(20, 250, 49, 74);
                Box7.BackColor = Color.FromArgb(20, 250, 49, 74);
                SoundCircle();
                MessageCircleShow();
                PlusOne = int.Parse(CircleScore.Text);
                CircleScore.Text = Convert.ToString(PlusOne + 1);
                BoxNotWork();
            }
            // Match Draw ====
            else if (Box1.Image != BoxReset.Image && Box2.Image != BoxReset.Image && Box3.Image != BoxReset.Image && Box4.Image != BoxReset.Image && Box5.Image != BoxReset.Image && Box6.Image != BoxReset.Image && Box7.Image != BoxReset.Image && Box8.Image != BoxReset.Image && Box9.Image != BoxReset.Image)
            {
                MessageDrawShow();
                SoundDraw();
                PlusOne = int.Parse(DrawScore.Text);
                DrawScore.Text = Convert.ToString(PlusOne + 1);
            }
        }
        // Create Function for Picture Work as Button
        void BtnBox1()
        {
            if (Checker == false)
            {
                Box1.Image = PicMultiply.Image;
                SoundMultiply1();
                Checker = true;
            }
            else
            {
                Box1.Image = PicCircle.Image;
                SoundCircle1();
                Checker = false;
            }
            Score();
            Box1.Enabled = false;
        }
        void BtnBox2()
        {
            if (Checker == false)
            {
                Box2.Image = PicMultiply.Image;
                SoundMultiply1();
                Checker = true;
            }
            else
            {
                Box2.Image = PicCircle.Image;
                SoundCircle1();
                Checker = false;
            }
            Score();
            Box2.Enabled = false;
        }
        void BtnBox3()
        {
            if (Checker == false)
            {
                Box3.Image = PicMultiply.Image;
                SoundMultiply1();
                Checker = true;
            }
            else
            {
                Box3.Image = PicCircle.Image;
                SoundCircle1();
                Checker = false;
            }
            Score();
            Box3.Enabled = false;
        }
        void BtnBox4()
        {
            if (Checker == false)
            {
                Box4.Image = PicMultiply.Image;
                SoundMultiply1();
                Checker = true;
            }
            else
            {
                Box4.Image = PicCircle.Image;
                SoundCircle1();
                Checker = false;
            }
            Score();
            Box4.Enabled = false;
        }
        void BtnBox5()
        {
            if (Checker == false)
            {
                Box5.Image = PicMultiply.Image;
                SoundMultiply1();
                Checker = true;
            }
            else
            {
                Box5.Image = PicCircle.Image;
                SoundCircle1();
                Checker = false;
            }
            Score();
            Box5.Enabled = false;
        }
        void BtnBox6()
        {
            if (Checker == false)
            {
                Box6.Image = PicMultiply.Image;
                SoundMultiply1();
                Checker = true;
            }
            else
            {
                Box6.Image = PicCircle.Image;
                SoundCircle1();
                Checker = false;
            }
            Score();
            Box6.Enabled = false;
        }
        void BtnBox7()
        {
            if (Checker == false)
            {
                Box7.Image = PicMultiply.Image;
                SoundMultiply1();
                Checker = true;
            }
            else
            {
                Box7.Image = PicCircle.Image;
                SoundCircle1();
                Checker = false;
            }
            Score();
            Box7.Enabled = false;
        }
        void BtnBox8()
        {
            if (Checker == false)
            {
                Box8.Image = PicMultiply.Image;
                SoundMultiply1();
                Checker = true;
            }
            else
            {
                Box8.Image = PicCircle.Image;
                SoundCircle1();
                Checker = false;
            }
            Score();
            Box8.Enabled = false;
        }
        void BtnBox9()
        {
            if (Checker == false)
            {
                Box9.Image = PicMultiply.Image;
                SoundMultiply1();
                Checker = true;
            }
            else
            {
                Box9.Image = PicCircle.Image;
                SoundCircle1();
                Checker = false;
            }
            Score();
            Box9.Enabled = false;
        }
        public Form1()
        {
            InitializeComponent();
        }
        // Custom Close and minimize Button
        private void BtnClose_Click(object sender, EventArgs e)
        {
            ExitShow();
        }
        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        // PictureBox
        private void Box1_Click(object sender, EventArgs e)
        {
            BtnBox1();
        }
        private void Box2_Click(object sender, EventArgs e)
        {
            BtnBox2();
        }
        private void Box3_Click(object sender, EventArgs e)
        {
            BtnBox3();
        }
        private void Box4_Click(object sender, EventArgs e)
        {
            BtnBox4();
        }
        private void Box5_Click(object sender, EventArgs e)
        {
            BtnBox5();
        }
        private void Box6_Click(object sender, EventArgs e)
        {
            BtnBox6();
        }
        private void Box7_Click(object sender, EventArgs e)
        {
            BtnBox7();
        }
        private void Box8_Click(object sender, EventArgs e)
        {
            BtnBox8();
        }
        private void Box9_Click(object sender, EventArgs e)
        {
            BtnBox9();
        }
        // Settings For Game
        private void BtnStartNewGame_Click(object sender, EventArgs e)
        {
            StartNewGameMessageShow();
        }
        private void BtnResetScreen_Click(object sender, EventArgs e)
        {
            BoxWork();
            ResetBox();
        }
    }
}
