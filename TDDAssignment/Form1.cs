using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TDDAssignment
{
    public partial class SpeedCalc : Form                               //this class represents our form
    {
        public SpeedCalc()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)                  // the calculate button is represented with the class
        {


            try
            {
                var dist = double.Parse(DistanceTxtBox.Text);
                var time = double.Parse(TimeTxtBox.Text);
                var speed = SpeedCalculator(dist, time);
                ResultTxtBox.Text = speed.ToString();
            }
            catch (Exception exception)
            {

                ResultTxtBox.Text = "Something went wrong";
            }
        }

        public double SpeedCalculator(double distance, double time)                 //calculates the speed given the distance and time
        {
            double speed = distance / time;
            return speed;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
