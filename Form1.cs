using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPG2END
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rng = new Random();
            int d1 = rng.Next(1, 6);
            int d2 = rng.Next(1, 6);
            int ans;
            bool parse = int.TryParse(textBox1.Text, out ans);
            if (ans >=2 && ans <=12 && ans % 1 == 0 && parse)
            {
                label1.Text = $"{d1} och {d2}";
                if (d2 + d1 == ans)
                {
                    label2.Text = "Rätt";
                }
                else
                {
                    label2.Text = "fel";
                }
            }
            else
            {
                label2.Text = "Inte ett tal mellan 2 och 12 eller inte ett heltal";
            }
        }
    }
}
