using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication17
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public bool mypro { get; set; }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
        int counter = 1;
        int y = 82;
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            label2.Text = counter + "% program running";

            counter++;
            if (counter == 100)
            {
                label2.Text = counter + "% Completed";
            }
            panel1.Location = new Point(85, y++);
            if (y == 181)
            {
                timer1.Stop();
                panel1.Visible = false;
                Form1 game = new Form1();
                game.Show();
                this.Hide();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {

            timer1.Stop();
                DialogResult ex = MessageBox.Show("Do you want Exit ?", " Note ", MessageBoxButtons.OKCancel);
            
            
            {
                timer1.Stop();
                
                if (ex.ToString() == "Cancel")
                {
                    timer1.Start();
                    e.Cancel = true;
                }

            }
            
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
