using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accord;
using Accord.Neuro;
using Accord.Neuro.Learning;

namespace MLP
{
    public partial class Form1 : Form
    {

        public static ActivationNetwork network = new ActivationNetwork(
             new BipolarSigmoidFunction(2), // Activation function
               inputsCount: 5,
               neuronsCount: new []{ 6, 1});
        BackPropagationLearning bp = new BackPropagationLearning(network);
        public string csv_file = "";
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void select_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();     //显示选择文件对话框
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "csv files (*.csv)|*.csv";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.textBox1.Text = openFileDialog1.FileName;          //显示文件路径
                this.csv_file = openFileDialog1.FileName;
                status.Text = "file selected";
            }
        }

        private void load_button_Click(object sender, EventArgs e)
        {
            if(this.csv_file == "")
            {
                content_box.Text += "Please select the CSV file!\r\n";
            }
            else
            {

            }
        }

        private void test_button_Click(object sender, EventArgs e)
        {

        }

        private void read_csv()
        {

        }
    }
}
