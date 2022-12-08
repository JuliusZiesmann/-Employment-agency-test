using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace PruefungAfA
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        protected override CreateParams CreateParams  //устраняет мерцание в форме посредством двойной буферизации
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            //обновляем модель
            TimerAll.Instance.Update();


            //делаем отрисовку модели
            var elapsed = TimerAll.Instance.ElapsedTime;
            Font mynew = new Font("Microsoft Sans Serif; 12pt", 12.0f);
            e.Graphics.DrawString(string.Format("{0:00}:{1:00}", (int)elapsed / 60, (int)elapsed % 60), mynew, Brushes.White, 712, 3);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Dieser Test besteht aus 10 Fragen, die alle beantwortet werden müssen.\r\n \r\n" +
                "Beispiel. Welches Muster muss in das gesuchte Feld?\r\n" +
                "Für dieser Aufgabe Richtige Lösung ist: „D“  \r\n \r\n" +
                "Klicken Sie „WEITER“ um Test weiter zu machen!";
            label4.BackColor = Color.Green;
            label9.BackColor = Color.Green;
            radioButton1.Visible=false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton5.Visible = false;
            button1.Visible = false;
            button2.Visible = false; 
            richTextBox1.Visible = false;
            timer1.Start();

        }
        

        private void button3_Click(object sender, EventArgs e)//"WEITER"
        {
            comboBox1.SelectedIndex = 1; //Frage 2
            textBox1.Parent = null;
            label4.BackColor = Color.Transparent;
            label9.BackColor = Color.Transparent;
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            radioButton5.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = false;
            pictureBox1.Image = Image.FromFile("C:\\C.Sharp\\PruefungAfA\\PruefungAfA\\grc\\mathe\\Frage 2\\Logicheskiy_test _2_-_Reshenia.jpg");
            pictureBox2.Image = Image.FromFile("C:\\C.Sharp\\PruefungAfA\\PruefungAfA\\grc\\mathe\\Frage 2\\2 A.png");
            pictureBox3.Image = Image.FromFile("C:\\C.Sharp\\PruefungAfA\\PruefungAfA\\grc\\mathe\\Frage 2\\2 B.png");
            pictureBox4.Image = Image.FromFile("C:\\C.Sharp\\PruefungAfA\\PruefungAfA\\grc\\mathe\\Frage 2\\2 C.png");
            pictureBox5.Image = Image.FromFile("C:\\C.Sharp\\PruefungAfA\\PruefungAfA\\grc\\mathe\\Frage 2\\2 D.png");
            pictureBox6.Image = Image.FromFile("C:\\C.Sharp\\PruefungAfA\\PruefungAfA\\grc\\mathe\\Frage 2\\2 E.png");
            textBox1.Visible = false;
            richTextBox1.Visible = true;
            radioButton4.Checked = false;
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox1.Text = "\r\n FRAGE 1";
            TimerAll.Instance.StartTime();
            
            
            
             
        }

        private void button1_Click(object sender, EventArgs e)//WAHL
        {
            if (comboBox1.SelectedIndex == 1 &&  radioButton2.Checked) //Frage 2
            {
                
                richTextBox1.BackColor = Color.Green;
                richTextBox1.Text = "Das war die richtige Antwort!";
                radioButton3.Enabled = false;
                radioButton4.Enabled = false;
                radioButton5.Enabled = false;
                radioButton1.Enabled = false;

            }
            else if (comboBox1.SelectedIndex == 1 && radioButton1.Checked)
            {

                richTextBox1.Text = "\r\nRichtige Antwort ist „B“";
                richTextBox1.BackColor = Color.Red;
                richTextBox1.BackColor = Color.Red;
                richTextBox1.ForeColor = Color.Yellow;
                radioButton3.Enabled = false;
                radioButton4.Enabled = false;
                radioButton5.Enabled = false;
                radioButton2.Enabled = false;

            }
            else if (comboBox1.SelectedIndex == 1 && radioButton3.Checked)
            {

                richTextBox1.BackColor = Color.Red;
                richTextBox1.BackColor = Color.Red;
                richTextBox1.Text = "\r\n Richtige Antwort ist „B“";
                richTextBox1.BackColor = Color.Red;
                richTextBox1.BackColor = Color.Red;
                richTextBox1.ForeColor = Color.Yellow;
                radioButton2.Enabled = false;
                radioButton4.Enabled = false;
                radioButton5.Enabled = false;
                radioButton1.Enabled = false;
            }
            else if (comboBox1.SelectedIndex == 1 && radioButton4.Checked)
            {

                richTextBox1.Text = "\r\n Richtige Antwort ist „B“";
                richTextBox1.BackColor = Color.Red;
                richTextBox1.ForeColor = Color.Yellow;
                radioButton3.Enabled = false;
                radioButton2.Enabled = false;
                radioButton5.Enabled = false;
                radioButton1.Enabled = false;
            }
            else if (comboBox1.SelectedIndex == 1 && radioButton5.Checked)
            {

                richTextBox1.Text = "\r\n Richtige Antwort ist „B“";
                richTextBox1.BackColor = Color.Red;
                richTextBox1.ForeColor = Color.Yellow;
                radioButton3.Enabled = false;
                radioButton4.Enabled = false;
                radioButton2.Enabled = false;
                radioButton1.Enabled = false;
            }

            else if (comboBox1.SelectedIndex == 2 && radioButton2.Checked) //Frage 3
            {

                richTextBox1.BackColor = Color.Green;
                richTextBox1.Text = "Das war die richtige Antwort!";
                radioButton3.Enabled = false;
                radioButton4.Enabled = false;
                radioButton5.Enabled = false;
                radioButton1.Enabled = false;

            }
            else if (comboBox1.SelectedIndex == 2 && radioButton1.Checked)
            {

                richTextBox1.Text = "\r\nRichtige Antwort ist „B“";
                richTextBox1.BackColor = Color.Red;
                richTextBox1.BackColor = Color.Red;
                richTextBox1.ForeColor = Color.Yellow;
                radioButton3.Enabled = false;
                radioButton4.Enabled = false;
                radioButton5.Enabled = false;
                radioButton2.Enabled = false;

            }
            else if (comboBox1.SelectedIndex == 2 && radioButton3.Checked)
            {

                richTextBox1.BackColor = Color.Red;
                richTextBox1.BackColor = Color.Red;
                richTextBox1.Text = "\r\n Richtige Antwort ist „B“";
                richTextBox1.BackColor = Color.Red;
                richTextBox1.BackColor = Color.Red;
                richTextBox1.ForeColor = Color.Yellow;
                radioButton2.Enabled = false;
                radioButton4.Enabled = false;
                radioButton5.Enabled = false;
                radioButton1.Enabled = false;
            }
            else if (comboBox1.SelectedIndex == 2 && radioButton4.Checked)
            {

                richTextBox1.Text = "\r\n Richtige Antwort ist „B“";
                richTextBox1.BackColor = Color.Red;
                richTextBox1.ForeColor = Color.Yellow;
                radioButton3.Enabled = false;
                radioButton2.Enabled = false;
                radioButton5.Enabled = false;
                radioButton1.Enabled = false;
            }
            else if (comboBox1.SelectedIndex == 2 && radioButton5.Checked)
            {

                richTextBox1.Text = "\r\n Richtige Antwort ist „B“";
                richTextBox1.BackColor = Color.Red;
                richTextBox1.ForeColor = Color.Yellow;
                radioButton3.Enabled = false;
                radioButton4.Enabled = false;
                radioButton2.Enabled = false;
                radioButton1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)//Nächste Frage
        {
            if (comboBox1.SelectedIndex == 1) //Frage 3
            {
                comboBox1.SelectedIndex = 2;
                textBox1.Parent = null;
                pictureBox1.Image = Image.FromFile("C:\\C.Sharp\\PruefungAfA\\PruefungAfA\\grc\\mathe\\Frage 3\\Frage 3.jpg");
                pictureBox2.Image = Image.FromFile("C:\\C.Sharp\\PruefungAfA\\PruefungAfA\\grc\\mathe\\Frage 3\\3 A.png");
                pictureBox3.Image = Image.FromFile("C:\\C.Sharp\\PruefungAfA\\PruefungAfA\\grc\\mathe\\Frage 3\\3 B#.png");
                pictureBox4.Image = Image.FromFile("C:\\C.Sharp\\PruefungAfA\\PruefungAfA\\grc\\mathe\\Frage 3\\3 C.png");
                pictureBox5.Image = Image.FromFile("C:\\C.Sharp\\PruefungAfA\\PruefungAfA\\grc\\mathe\\Frage 3\\3 D.png");
                pictureBox6.Image = Image.FromFile("C:\\C.Sharp\\PruefungAfA\\PruefungAfA\\grc\\mathe\\Frage 3\\3 E.png");
                textBox1.Visible = false;
                richTextBox1.Visible = true;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                richTextBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
                richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
                richTextBox1.Text = "\r\n FRAGE 2";


            }
            else if (comboBox1.SelectedIndex == 2) //Frage 4
            {
                comboBox1.SelectedIndex = 3;
                textBox1.Parent = null;
                pictureBox1.Image = Image.FromFile("C:\\C.Sharp\\PruefungAfA\\PruefungAfA\\grc\\mathe\\Frage 4\\Frage 4.png");
                pictureBox2.Image = Image.FromFile("C:\\C.Sharp\\PruefungAfA\\PruefungAfA\\grc\\mathe\\Frage 4\\4 A#.png");
                pictureBox3.Image = Image.FromFile("C:\\C.Sharp\\PruefungAfA\\PruefungAfA\\grc\\mathe\\Frage 4\\4 B.png");
                pictureBox4.Image = Image.FromFile("C:\\C.Sharp\\PruefungAfA\\PruefungAfA\\grc\\mathe\\Frage 4\\4 C.png");
                pictureBox5.Image = Image.FromFile("C:\\C.Sharp\\PruefungAfA\\PruefungAfA\\grc\\mathe\\Frage 4\\4 D.png");
                pictureBox6.Image = Image.FromFile("C:\\C.Sharp\\PruefungAfA\\PruefungAfA\\grc\\mathe\\Frage 4\\4 E.png");
                textBox1.Visible = false;
                richTextBox1.Visible = true;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                richTextBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
                richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
                richTextBox1.Text = "\r\n FRAGE 3";

            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                Refresh();
        }
    }
}
