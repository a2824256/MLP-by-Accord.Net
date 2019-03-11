using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using Accord.MachineLearning.DecisionTrees;
using Accord.MachineLearning.DecisionTrees.Learning;
using Accord.MachineLearning.DecisionTrees.Rules;
using Accord.Math.Optimization.Losses;
using Accord.Neuro;
using Accord.Neuro.Learning;
using Accord.Statistics.Filters;

namespace MLP
{
    public partial class Form1 : Form
    {

        public static ActivationNetwork network;
        public BackPropagationLearning bp;
        public DataTable dt;
        public string csv_file = "";
        public double error = 100.0;
        public int train_number = 0;
        public int test_number = 0;
        public int epoch = 0;
        public Form1()
        {
            InitializeComponent();
            content_box.ScrollBars = ScrollBars.Horizontal;
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
            OpenFileDialog openFileDialog1 = new OpenFileDialog();     
            openFileDialog1.InitialDirectory = "c:\\";
            //Can only select csv files
            openFileDialog1.Filter = "csv files (*.csv)|*.csv";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
                csv_file = openFileDialog1.FileName;
            }
        }

        //training the ANN
        public void Train()
        {
            //clear the textbox
            content_box.Text = "";
            try
            {
                double gaussian = Convert.ToDouble(gw.Text);
                //use Gaussian init the Weights
                new GaussianWeights(network, gaussian).Randomize();
                bp.LearningRate = Convert.ToDouble(lr.Text);
                bp.Momentum = Convert.ToDouble(momentum.Text);
            }
            //if input the If you enter a non-numeric string
            catch
            {
                new GaussianWeights(network, 0.1).Randomize();
                bp.LearningRate = 0.1;
                bp.Momentum = 0.0;
            }
            for (int epoch_num = 0; epoch_num < epoch; epoch_num++)
            {
                int count = 0;
                for(int i = 0; i < train_number; i++)
                {
                    double[] input = new double[30];
                    for (int sensor_i = 0; sensor_i < 30; sensor_i++)
                    {
                        input[sensor_i] = Convert.ToDouble(dt.Rows[i][sensor_i]);
                    }
                    double[] output = new double[6];
                    switch (dt.Rows[i][30])
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
            if(csv_file == "")
            {
                content_box.Text += "Data set not yet selected!\r\n";
            }
            else
            {
                //example input:15,15,15,
                String nodes_str = nodes.Text;
                String[] nodes_str_arr = nodes_str.Split(',');
                int[] n = new int[nodes_str_arr.Length+1];
                for (int index = 0; index < nodes_str_arr.Length; index++)
                {
                    n[index] = Convert.ToInt32(nodes_str_arr[index]);
                }
                //output layer is fixed(6)
                n[nodes_str_arr.Length] = 6;
                network = new ActivationNetwork(new BipolarSigmoidFunction(2), 30, n);
                bp = new BackPropagationLearning(network);
                dt = Csv2DataTable(this.csv_file, 0);
                train_number = Convert.ToInt32(TrainingRows.Text);
                test_number = Convert.ToInt32(TestRows.Text);
                epoch = Convert.ToInt32(Epoch.Text);
                Train();
            }
        }

        public int GetMaxIndex(double[] arr)
        {
            int max_index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= arr[max_index])
                {
                    max_index = i;
                }
            }
            return max_index;
        }

        public void Test()
        {
            test_number = Convert.ToInt32(TestRows.Text);
            double count = 0;
            double right = 0;
            for (int i = train_number; i < (test_number + train_number); i++)
            {
                double[] input = new double[30];
                for (int sensor_i = 0; sensor_i < 30; sensor_i++)
                {
                    input[sensor_i] = Convert.ToDouble(dt.Rows[i][sensor_i]);
                }

                int real_res = Convert.ToInt32(dt.Rows[i][30]);
                double[] res = network.Compute(input);
                if (real_res == GetMaxIndex(res))
                {
                    right+=1;
                }
                count+=1;
            }
            double final_accuracy = (right / test_number) * 100.0;
            Accuracy.Text = final_accuracy.ToString() + "%";
        }

        private void test_button_Click(object sender, EventArgs e)
        {
            if (.csv_file == "")
            {
                content_box.Text += "Data set not yet selected!\r\n";
            }
            else
            {
                Test();
            }
        }

        public DataTable Csv2DataTable(string filePath, int n)
        {
            DataTable dt = new DataTable();
            //load the file
            StreamReader reader = new StreamReader(filePath, System.Text.Encoding.Default, false);
            int m = 0;
            DataColumn column;
            //load the column
            for (int col = 0; col < 31; col++)
            {
                column = new DataColumn();
                column.DataType = Type.GetType("System.String");
                column.ColumnName = col.ToString();
                dt.Columns.Add(column);
            }
            //load the rows data
            while (!reader.EndOfStream)
            {
                m = m + 1;
                string str = reader.ReadLine();
                //Parsing row data
                string[] split = str.Split(',');
                if (m >= n + 1)
                {
                    DataRow dr = dt.NewRow();
                    for (int i = 0; i < split.Length; i++)
                    {
                        dr[i] = split[i];
                    }
                    dt.Rows.Add(dr);
                }
            }
            reader.Close();
            return dt;
        }


        private void GetRules_Click(object sender, EventArgs e)
        {
            if (csv_file == "")
            {
                content_box.Text += "Data set not yet selected!\r\n";
            }
            else
            {
                dt = Csv2DataTable(this.csv_file, 0);
                string str = Rules2String();
                content_box.Text = "";
                content_box.Text += str;
            }
        }

        public string Rules2String()
        {
            int count = dt.Rows.Count;
            int[][] inputs = new int [count][];
            string[] labels = new string[count];
            int num = 0;
            foreach (DataRow dr in dt.Rows)
            {
                int res = Convert.ToInt32(dr[30]);
                inputs[num] = new int[30];
                for (int sensor_i = 0; sensor_i < 30; sensor_i++)
                {
                    inputs[num][sensor_i] = Convert.ToInt32(dr[sensor_i]);
                }
                labels[num] = "class-"+res.ToString();
                num++;
            }
            var codebook = new Codification("Output", labels);
            int[] outputs = codebook.Transform("Output", labels);

            DecisionVariable[] dv = new DecisionVariable[30];
            for(int i = 0; i < 30; i++)
            {
                string name = "sensor_" + (i+1).ToString();
                dv[i] = new DecisionVariable(name, DecisionVariableKind.Continuous);
            }
            //use C45 Spanning tree algorithm
            var C45 = new C45Learning(dv);
            DecisionTree tree = C45.Learn(inputs, outputs);
            
            int[] predicted = tree.Decide(inputs);
            double error = new ZeroOneLoss(outputs).Loss(predicted);
            DecisionSet rules = tree.ToRules();
            return rules.ToString(codebook, "Output",System.Globalization.CultureInfo.InvariantCulture);
        }
    }
}
