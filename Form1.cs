using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneHandBandit
{
    public partial class Form1 : Form
    {
        public int cash = 100;
        static readonly int[] winCombination = {000, 111, 222, 333, 444, 555, 666, 777, 888, 999,
            123, 321, 789, 234,345,3567,789,890,007, 080};

        public Form1()
        {
            
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lcash.Text = $"You have {cash}$";
            
        }

        private void Dvig1_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int dig = rand.Next(10);
            l1.Text = dig.ToString();
        }

        private void Dvig2_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int dig = rand.Next(10);
            l2.Text = dig.ToString();
        }

        private void Dvig3_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int dig = rand.Next(10);
            l3.Text = dig.ToString();
        }

        private void Button_start_Click(object sender, EventArgs e)
        {
            if (cash <= 0)
            {
                MessageBox.Show("Sorry, you totally lose!");
                Environment.Exit(0);
            }
            cash -=10;
            dvig1.Start(); dvig2.Start(); dvig3.Start();
            stop1.Start(); stop2.Start(); stop3.Start();
            Button_start.Enabled = false;
        }

        private void Stop1_Tick(object sender, EventArgs e)
        {
            dvig1.Stop(); stop1.Stop();
        }

        private void Stop2_Tick(object sender, EventArgs e)
        {
            dvig2.Stop(); stop2.Stop();
        }

        private void Stop3_Tick(object sender, EventArgs e)
        {
            dvig3.Stop(); stop3.Stop();
            string combination = l1.Text + l2.Text + l3.Text;
            if (winCombination.Contains(Convert.ToInt32(combination)))
            {
                MessageBox.Show("Congratulation, you win!!!!!");
                cash += 100;
            }
            lcash.Text = $"You have {cash}$";
            Button_start.Enabled = !false;

        }
    }
}
