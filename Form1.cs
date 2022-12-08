using PruefungAfA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruefungAfA
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            
        
            try
            {
                int SelectedIndex = comboBox1.SelectedIndex;
                if (comboBox1.SelectedIndex == 0)
                {
                    Form2 form2 = new Form2();
                    form2.Show();
                    this.Hide();
                    form2.FormClosed += (object s, FormClosedEventArgs ev) => { this.Show();};
                    TimerAll.Instance.StartTime();




                }
                else if (comboBox1.SelectedIndex == 1)
                    {
                        Form3 frmmat = new Form3();
                        frmmat.Show();
                        this.Hide();
                        frmmat.FormClosed += (object s, FormClosedEventArgs ev) => { this.Show(); };
                    }
                else if (comboBox1.SelectedIndex == 2)
                    {
                        Form4 frm4 = new Form4();
                        frm4.Show();
                        this.Hide();
                        frm4.FormClosed += (object s, FormClosedEventArgs ev) => { this.Show(); };
                }
                else
                    {
                        label1.Text = "Sie haben nichts gewählt!";
                    }
                
            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;

            }
        }

        private void Frmmat_FormClosed(object sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }
        private void Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }
        private void Frm4_FormClosed(object sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "\r\n" + "Herzlich willkommen zum Eignungstest! \r\n" + "\r\n" +
                "Sie bekommen 50 Fragen in verschiedenen Richtungen! (Allgemeinwissen, Mathe und Logik, IT Fragen)" + "\r\n" +
                "Hier können Sie sich überprüfen wie Sie bereit zum Eignungstest Agentur für Arbeit  in Richtung der IT sind! " + "\r\n" +
                "Sie haben 45 Minuten Zeit damit an alle Fragen beantworten." + "\r\n" + "\r\n" + "\r\n" +
                "Viel Erfolg!";
            comboBox1.SelectedIndex = 0;  

        }

        
    }
}
