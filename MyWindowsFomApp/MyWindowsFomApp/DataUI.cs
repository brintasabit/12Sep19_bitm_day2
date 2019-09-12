using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWindowsFomApp
{
    public partial class DataUI : Form
    {
        public DataUI()
        {
            InitializeComponent();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            int firstnum = Convert.ToInt32(FirstNumTextbox.Text);
            int secondnum = Convert.ToInt32(SecondNumTextbox.Text);
            int result = firstnum + secondnum;
            ResultTextbox.Text = result.ToString();
            MessageBox.Show("Sum is " +result);
            
        }
    }
}
