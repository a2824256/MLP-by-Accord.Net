using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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
               inputsCount: 30,
               neuronsCount: new []{ 30, 6});
        public BackPropagationLearning bp = new BackPropagationLearning(network);
        public DataTable dt;
        public string csv_file = "";
        public  double error = 100.0;
        public  int train_number = 0;
        public  int test_number = 0;
        public  int total_rows = 0;
        public  int epoch = 0;
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

        public void train()
        {
            new GaussianWeights(network, 0.1).Randomize();
            //bp.LearningRate = 0.1;
            for (int epoch_num = 0; epoch_num < epoch; epoch_num++)
            {
                int count = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    if (count >= train_number)
                    {
                        Console.WriteLine(count);
                        break;
                    }
                    double[] input = { Convert.ToDouble(dr[0]), Convert.ToDouble(dr[1]), Convert.ToDouble(dr[2]),Convert.ToDouble(dr[3]),Convert.ToDouble(dr[4]),Convert.ToDouble(dr[5]),Convert.ToDouble(dr[6]),
                    Convert.ToDouble(dr[7]),Convert.ToDouble(dr[8]),Convert.ToDouble(dr[9]),Convert.ToDouble(dr[10]),Convert.ToDouble(dr[11]),Convert.ToDouble(dr[12]),Convert.ToDouble(dr[13]),
                    Convert.ToDouble(dr[14]),Convert.ToDouble(dr[15]),Convert.ToDouble(dr[16]),Convert.ToDouble(dr[17]),Convert.ToDouble(dr[18]),Convert.ToDouble(dr[19]),Convert.ToDouble(dr[20]),
                    Convert.ToDouble(dr[21]),Convert.ToDouble(dr[22]),Convert.ToDouble(dr[23]),Convert.ToDouble(dr[24]),Convert.ToDouble(dr[25]),Convert.ToDouble(dr[26]),Convert.ToDouble(dr[27]),
                    Convert.ToDouble(dr[28]),Convert.ToDouble(dr[29])};
                    double[] output = new double[6];
                    switch (dr[30])
                    {
                        case 0:
                            output = new double[6] { 1, 0, 0, 0, 0, 0 };
                            break;
                        case 1:
                            output = new double[6] { 0, 1, 0, 0, 0, 0 };
                            break;
                        case 2:
                            output = new double[6] { 0, 0, 1, 0, 0, 0 };
                            break;
                        case 3:
                            output = new double[6] { 0, 0, 0, 1, 0, 0 };
                            break;
                        case 4:
                            output = new double[6] { 0, 0, 0, 0, 1, 0 };
                            break;
                        case 5:
                            output = new double[6] { 0, 0, 0, 0, 0, 1 };
                            break;
                    }
                    error = bp.Run(input, output);
                    count++;
                }
                content_box.Text += "Epoch " + (epoch_num + 1) + ",Error:" + error + "\r\n";
            }
        }

        public void load_button_Click(object sender, EventArgs e)
        {
            if(this.csv_file == "")
            {
                content_box.Text += "Please select the CSV file!\r\n";
            }
            else
            {
                dt = CsvToDataTable(this.csv_file, 0);
                train_number = Convert.ToInt32(TrainingRows.Text);
                test_number = Convert.ToInt32(TestRows.Text);
                total_rows = Convert.ToInt32(TotalRows.Text);
                epoch = Convert.ToInt32(Epoch.Text);
                train();
            }
        }

        public int getIndex(double[] array)
        {
            int max_index = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] > array[max_index])
                {
                    max_index = i;
                }
            }
            return max_index;
        }

        public void test()
        {
            int count = 0;
            int right = 0;
            foreach (DataRow dr in dt.Rows)
            {
                if (count < train_number)
                {
                    count++;
                    continue;
                }
                if(count > (train_number + test_number))
                {
                    break;
                }
                double[] input = { Convert.ToDouble(dr[0]), Convert.ToDouble(dr[1]), Convert.ToDouble(dr[2]),Convert.ToDouble(dr[3]),Convert.ToDouble(dr[4]),Convert.ToDouble(dr[5]),Convert.ToDouble(dr[6]),
                    Convert.ToDouble(dr[7]),Convert.ToDouble(dr[8]),Convert.ToDouble(dr[9]),Convert.ToDouble(dr[10]),Convert.ToDouble(dr[11]),Convert.ToDouble(dr[12]),Convert.ToDouble(dr[13]),
                    Convert.ToDouble(dr[14]),Convert.ToDouble(dr[15]),Convert.ToDouble(dr[16]),Convert.ToDouble(dr[17]),Convert.ToDouble(dr[18]),Convert.ToDouble(dr[19]),Convert.ToDouble(dr[20]),
                    Convert.ToDouble(dr[21]),Convert.ToDouble(dr[22]),Convert.ToDouble(dr[23]),Convert.ToDouble(dr[24]),Convert.ToDouble(dr[25]),Convert.ToDouble(dr[26]),Convert.ToDouble(dr[27]),
                    Convert.ToDouble(dr[28]),Convert.ToDouble(dr[29])};
                int real_res = Convert.ToInt32(dr[30]);
                double[] res = network.Compute(input);
                int class_index = getIndex(res);
                //content_box.Text += res[0].ToString()+"," + res[1].ToString() + "," + res[2].ToString() + "," + res[3].ToString() + "," + res[4].ToString() + "," + res[5].ToString() + "," + "\r\n";
                //content_box.Text += "real:" + real_res.ToString() + ",res:" + class_index.ToString() + "\r\n";
                if (real_res == GetMaxIndex(res))
                {
                    right++;
                }
                count++;
            }
            double final_accuracy = ((double)right / (double)test_number)*100;
            Accuracy.Text = final_accuracy.ToString() + "%";
        }

        private void test_button_Click(object sender, EventArgs e)
        {
            if (this.csv_file == "")
            {
                content_box.Text += "Please select the CSV file!\r\n";
            }
            else
            {
                test();
            }
        }

        public DataTable CsvToDataTable(string filePath, int n)
        {
            DataTable dt = new DataTable();
            StreamReader reader = new StreamReader(filePath, System.Text.Encoding.Default, false);
            int m = 0;
            bool sw = false;
            DataColumn column; //列名
            for (int c = 0; c < 31; c++)
            {
                column = new DataColumn();
                column.DataType = Type.GetType("System.String");
                column.ColumnName = c.ToString();
                //content_box.Text += column.ColumnName;
                dt.Columns.Add(column);
            }
            //column = new DataColumn();
            //column.DataType = Type.GetType("System.String");
            //column.ColumnName = "res";
            //dt.Columns.Add(column);
            //Console.Write(column.ColumnName);
            //Console.WriteLine("\r\n");
            while (!reader.EndOfStream)
            {
                m = m + 1;
                string str = reader.ReadLine();
                string[] split = str.Split(',');
                if (m >= n + 1)
                {
                    DataRow dr = dt.NewRow();
                    for (int i = 0; i < split.Length; i++)
                    {
                        dr[i] = split[i];
                        //Console.Write(dr[i].ToString()+",");
                    }
                    //Console.WriteLine("\r\n");
                    dt.Rows.Add(dr);
                }
            }
            reader.Close();
            return dt;
        }

        public int GetMaxIndex(double[] arr)
        {
            int max_index = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= arr[max_index])
                {
                    max_index = i;
                }
            }
            return max_index;
        }
    }
}
