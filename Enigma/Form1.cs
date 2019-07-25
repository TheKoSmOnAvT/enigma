using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enigma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Splitter1_BackColorChanged(object sender, EventArgs e)
        {

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (ComboFirst.SelectedItem == null || ComboSecond.SelectedItem == null || ComboThrid.SelectedItem == null || TextBoxInput.Text == null)
            {
                MessageBox.Show("Select the routers and pull input,pls");
            }
            else {
                // TextBoxOut.Text = ComboFirst.SelectedItem.ToString();
                Algorthm Objs = new Algorthm(Convert.ToInt32(ComboFirst.SelectedItem),
                                             Convert.ToInt32(ComboSecond.SelectedItem),
                                             Convert.ToInt32(ComboThrid.SelectedItem),
                                             TextBoxInput.Text);

                TextBoxOut.Text = Objs.OutputString();
                for (int i = 0; i <= 100; i++)
                {
                    progressBar1.Value = i;
                }

                MessageBox.Show("LET'S DONE");
                progressBar1.Value = 0;
            }
        }

        private void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListBoxFirst_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ComboSecond_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboThrid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ThridRouter_Click(object sender, EventArgs e)
        {

        }
    }
}
