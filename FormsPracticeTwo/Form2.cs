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
    public partial class Form2 : Form
    {
        //set up one get/set for every textbox
        public string data
        {
            get { return three.Text; }
            set { three.Text = value; }
        }
        //setup pointer to form1
        public Form1 pointer;

        public Form2()  //constuctor
        {
            InitializeComponent();
        }
        public Form2(string x)  //constuctor
        {//vb you must manually type in init
            InitializeComponent();
            one.Text = x; //must put in after init
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //static variables read in load, NOT in constructor
            two.Text = Form1.boxOfData;

            //pull over from form1 pointer
            four.Text = pointer.four.Text;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.boxOfData = two.Text; //for static variables

            //push over to form1 pointer
            pointer.four.Text = four.Text;

            this.Close(); //vb me.close()
        }
    }
}
