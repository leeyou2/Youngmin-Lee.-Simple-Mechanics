using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Youngmin_Lee.Simple_Mechanics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("A");
            MessageBox.Show("ABC");
            MessageBox.Show("Hello");
            MessageBox.Show("Hello World");
            MessageBox.Show("Hello World!");
            MessageBox.Show(string.Format("Hello,"+"World!"));
            MessageBox.Show(string.Format("Hello" +","+ "World!"));
            MessageBox.Show(string.Format("Hello" + "," + "World"+"!"));
            //This is a single line comment.
            //This is another comment.
            //Still a third comment. 
            //This should not take long.
            //The more I do this the better I will get
            //This is block comment.
            //
        }
    }
}
