using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car_refuelling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        List<int> ededler = new List<int>();
        int i = 0;

        private void button1_Click(object sender, EventArgs e)
        {


            ededler.Add(0);


            ededler.Add(Convert.ToInt32(textBox1.Text));
            i++;

            textBox1.Clear();


        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {

            int car_km = Convert.ToInt32(textBox2.Text);


            int numRefills = 0;
            int current_refill = 0;

            while (current_refill <= ededler.Count)
            {

                int last_refil;

                last_refil = current_refill;

                while (current_refill <= ededler.Count && ededler.ElementAt(current_refill + 1) -
                    ededler.ElementAt(last_refil) <= car_km)
                {
                    current_refill++;
                }

                if (current_refill == last_refil)
                {
                    MessageBox.Show("IMPOSSIBLE");
                    break;
                }

                if (current_refill <= ededler.Count)
                {
                    numRefills++;

                }


            }

            MessageBox.Show("Resilt is "+numRefills.ToString());
            


        }
    }
}
