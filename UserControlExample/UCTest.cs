using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControlExample
{
    public partial class UCTest : UserControl
    {
        public UCTest()
        {
            InitializeComponent();
        }
        public int numberofLates { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            numberofLates++;
            label1.Text = numberofLates.ToString();
        }
    }
}
