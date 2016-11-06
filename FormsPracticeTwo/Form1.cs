using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsPracticeTwo
{
    public partial class Form1 : Form
    {
        //make shared variable for each textbox
        public static string boxOfData;

        private DateTime startTime = new DateTime();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text + " "  + textBox2.Text + " "
                + textBox3.Text + " " + textBox4.Text);
            textBox4.Text = "Hi from outside box";
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            textBox6.Text = e.KeyCode.ToString();
            if(e.KeyCode.ToString()=="F1")
            {
                MessageBox.Show("F1 Pressed");
            }
            if(e.KeyCode==Keys.Home)
            {
                MessageBox.Show("Go Home");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            startTime = DateTime.Now;
            DateTime current = new DateTime();
            DateTime diff = new DateTime();
            diff = current = startTime;
            label2.Text = diff.ToLongTimeString(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            boxOfData = two.Text; //for static variable; must be done BEFORE form2 is created
            Form2 f = new Form2(one.Text);
            f.pointer = this; 
            f.data = three.Text; //for get/set variable
            f.ShowDialog(); //modal form
            three.Text = f.data; //grab get/set variable
            //f.Show(); //modeless form

            //MDI form set IsMdiContainer to true in Form1 properties
            //f.MdiParent = this;
            //f.Show(); //MDI cannot do ShowDialog
            two.Text = boxOfData; //grab static variable
            MessageBox.Show("I'm back");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
