using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ClassHosp
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        Stopwatch tiempo = new Stopwatch();
        Stopwatch tiempo1 = new Stopwatch();
        Stopwatch tiempo2 = new Stopwatch();
        Stopwatch tiempo3 = new Stopwatch();
        Stopwatch tiempo4 = new Stopwatch();
        Stopwatch tiempo5 = new Stopwatch();
        Stopwatch tiempo6 = new Stopwatch();
        Stopwatch tiempo7 = new Stopwatch();

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
        


        private void button1_Click_1(object sender, EventArgs e)
        {
            label1.Text = "Ocupado";
            label1.BackColor = Color.Red;
            label1.Enabled = true;
            timer1.Enabled = true;
            tiempo.Start();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            label2.Text = "Ocupado";
            label2.BackColor = Color.Red;
            label2.Enabled = true;
            timer2.Enabled = true;
            tiempo1.Start();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            label3.Text = "Ocupado";
            label3.BackColor = Color.Red;
            label3.Enabled = true;
            timer3.Enabled = true;
            tiempo2.Start();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            label4.Text = "Ocupado";
            label4.BackColor = Color.Red;
            label4.Enabled = true;
            timer4.Enabled = true;
            tiempo3.Start();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            label5.Text = "Ocupado";
            label5.BackColor = Color.Red;
            label5.Enabled = true;
            timer5.Enabled = true;
            tiempo4.Start();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            label6.Text = "Ocupado";
            label6.BackColor = Color.Red;
            label6.Enabled = true;
            timer6.Enabled = true;
            tiempo5.Start();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            label13.Text = "Ocupado";
            label13.BackColor = Color.Red;
            label13.Enabled = true;
            timer7.Enabled = true;
            tiempo6.Start();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            label14.Text = "Ocupado";
            label14.BackColor = Color.Red;
            label14.Enabled = true;
            timer8.Enabled = true;
            tiempo7.Start();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            label1.Text = "Disponible";
            label1.BackColor = Color.Lime;
            label1.Enabled = true;
            timer1.Enabled = false;
            tiempo.Stop();
            tiempo.Reset();



        


            


           

            label14.Text = "Disponible";
            label14.BackColor = Color.Lime;
            label14.Enabled = true;
            timer8.Enabled = true;
            tiempo.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label15.Text = String.Format("{0:00}:{2:00}:{3:00}", tiempo.Elapsed.Hours, tiempo.Elapsed.Minutes, tiempo.Elapsed.Seconds, tiempo.Elapsed.Milliseconds / 10);
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label16.Text = String.Format("{0:00}:{2:00}:{3:00}", tiempo1.Elapsed.Hours, tiempo1.Elapsed.Minutes, tiempo1.Elapsed.Seconds, tiempo1.Elapsed.Milliseconds / 10);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            label12.Text = String.Format("{0:00}:{2:00}:{3:00}", tiempo2.Elapsed.Hours, tiempo2.Elapsed.Minutes, tiempo2.Elapsed.Seconds, tiempo2.Elapsed.Milliseconds / 10);
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            label11.Text = String.Format("{0:00}:{2:00}:{3:00}", tiempo3.Elapsed.Hours, tiempo3.Elapsed.Minutes, tiempo3.Elapsed.Seconds, tiempo3.Elapsed.Milliseconds / 10);
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            label10.Text = String.Format("{0:00}:{2:00}:{3:00}", tiempo4.Elapsed.Hours, tiempo4.Elapsed.Minutes, tiempo4.Elapsed.Seconds, tiempo4.Elapsed.Milliseconds / 10);
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            label7.Text = String.Format("{0:00}:{2:00}:{3:00}", tiempo5.Elapsed.Hours, tiempo5.Elapsed.Minutes, tiempo5.Elapsed.Seconds, tiempo5.Elapsed.Milliseconds / 10);
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            label8.Text = String.Format("{0:00}:{2:00}:{3:00}", tiempo6.Elapsed.Hours, tiempo6.Elapsed.Minutes, tiempo6.Elapsed.Seconds, tiempo6.Elapsed.Milliseconds / 10);
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            label9.Text = String.Format("{0:00}:{2:00}:{3:00}", tiempo7.Elapsed.Hours, tiempo7.Elapsed.Minutes, tiempo7.Elapsed.Seconds, tiempo7.Elapsed.Milliseconds / 10);
        }

        private void button10_Click(object sender, EventArgs e)
        {

            label2.Text = "Disponible";
            label2.BackColor = Color.Lime;
            label2.Enabled = true;
            timer2.Enabled = true;
            tiempo1.Stop();
            tiempo1.Reset();
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label3.Text = "Disponible";
            label3.BackColor = Color.Lime;
            label3.Enabled = true;
            timer3.Enabled = true;
            tiempo2.Stop();
            tiempo2.Reset();
        }

        private void button12_Click(object sender, EventArgs e)
        {

            label4.Text = "Disponible";
            label4.BackColor = Color.Lime;
            label4.Enabled = true;
            timer4.Enabled = true;
            tiempo3.Stop();
            tiempo3.Reset();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label5.Text = "Disponible";
            label5.BackColor = Color.Lime;
            label5.Enabled = true;
            timer5.Enabled = true;
            tiempo4.Stop();
            tiempo4.Reset();
        }

        private void button14_Click(object sender, EventArgs e)
        {

            label6.Text = "Disponible";
            label6.BackColor = Color.Lime;
            label6.Enabled = true;
            timer6.Enabled = true;
            tiempo5.Stop();
            tiempo5.Reset();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            label13.Text = "Disponible";
            label13.BackColor = Color.Lime;
            label13.Enabled = true;
            timer7.Enabled = true;
            tiempo6.Stop();
            tiempo6.Reset();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            label14.Text = "Disponible";
            label14.BackColor = Color.Lime;
            label14.Enabled = true;
            timer8.Enabled = true;
            tiempo7.Stop();
            tiempo7.Reset();
        }
    }
}

  
