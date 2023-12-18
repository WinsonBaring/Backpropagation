using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backprop;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Backpropagation
{
    public partial class Form1 : Form
    {

        NeuralNet nn;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
                nn = new NeuralNet(4, 2, 1);
        

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Training the Network
                for (int j = 0; j < 1700; j++)
                {
                    nn.setInputs(0, 0.0);
                    nn.setInputs(1, 0.0);
                    nn.setInputs(2, 0.0);
                    nn.setInputs(3, 1.0);
                    nn.setDesiredOutput(0, 0.0);
                    nn.learn();

                    nn.setInputs(0, 0.0);
                    nn.setInputs(1, 0.0);
                    nn.setInputs(2, 1.0);
                    nn.setInputs(3, 0.0);
                    nn.setDesiredOutput(0, 0.0);
                    nn.learn();

                    nn.setInputs(0, 0.0);
                    nn.setInputs(1, 0.0);
                    nn.setInputs(2, 1.0);
                    nn.setInputs(3, 1.0);
                    nn.setDesiredOutput(0, 0.0);
                    nn.learn();

                    nn.setInputs(0, 0.0);
                    nn.setInputs(1, 1.0);
                    nn.setInputs(2, 0.0);
                    nn.setInputs(3, 0.0);
                    nn.setDesiredOutput(0, 0.0);
                    nn.learn();

                    nn.setInputs(0, 0.0);
                    nn.setInputs(1, 1.0);
                    nn.setInputs(2, 0.0);
                    nn.setInputs(3, 1.0);
                    nn.setDesiredOutput(0, 0.0);
                    nn.learn();

                    nn.setInputs(0, 0.0);
                    nn.setInputs(1, 1.0);
                    nn.setInputs(2, 1.0);
                    nn.setInputs(3, 0.0);
                    nn.setDesiredOutput(0, 0.0);
                    nn.learn();

                    nn.setInputs(0, 0.0);
                    nn.setInputs(1, 1.0);
                    nn.setInputs(2, 1.0);
                    nn.setInputs(3, 1.0);
                    nn.setDesiredOutput(0, 0.0);
                    nn.learn();

                    nn.setInputs(0, 1.0);
                    nn.setInputs(1, 0.0);
                    nn.setInputs(2, 0.0);
                    nn.setInputs(3, 0.0);
                    nn.setDesiredOutput(0, 0.0);
                    nn.learn();

                    nn.setInputs(0, 1.0);
                    nn.setInputs(1, 0.0);
                    nn.setInputs(2, 0.0);
                    nn.setInputs(3, 1.0);
                    nn.setDesiredOutput(0, 0.0);
                    nn.learn();

                    nn.setInputs(0, 1.0);
                    nn.setInputs(1, 0.0);
                    nn.setInputs(2, 1.0);
                    nn.setInputs(3, 0.0);
                    nn.setDesiredOutput(0, 0.0);
                    nn.learn();

                    nn.setInputs(0, 1.0);
                    nn.setInputs(1, 0.0);
                    nn.setInputs(2, 1.0);
                    nn.setInputs(3, 1.0);
                    nn.setDesiredOutput(0, 0.0);
                    nn.learn();

                    nn.setInputs(0, 1.0);
                    nn.setInputs(1, 1.0);
                    nn.setInputs(2, 0.0);
                    nn.setInputs(3, 0.0);
                    nn.setDesiredOutput(0, 0.0);
                    nn.learn();

                    nn.setInputs(0, 1.0);
                    nn.setInputs(1, 1.0);
                    nn.setInputs(2, 0.0);
                    nn.setInputs(3, 1.0);
                    nn.setDesiredOutput(0, 0.0);
                    nn.learn();

                    nn.setInputs(0, 1.0);
                    nn.setInputs(1, 1.0);
                    nn.setInputs(2, 1.0);
                    nn.setInputs(3, 0.0);
                    nn.setDesiredOutput(0, 0.0);
                    nn.learn();

                    nn.setInputs(0, 1.0);
                    nn.setInputs(1, 1.0);
                    nn.setInputs(2, 1.0);
                    nn.setInputs(3, 1.0);
                    nn.setDesiredOutput(0, 1.0);
                    nn.learn();


                    nn.setInputs(0, 0.0);
                    nn.setInputs(1, 0.0);
                    nn.setInputs(2, 0.0);
                    nn.setInputs(3, 0.0);
                    nn.setDesiredOutput(0, 0.0);
                    nn.learn();
                }
            

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
                
        }

        private void And1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label0.Text = "0";
            runner();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label0.Text = "1";
            runner();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            runner();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = "1";
            runner();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label2.Text = "0";
            runner();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label2.Text= "1";
            runner();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label3.Text = "0";
            runner();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label3.Text= "1";
            runner();
        }

        public void runner()
        {

            nn.setInputs(0, Convert.ToDouble(label0.Text));

            nn.setInputs(1, Convert.ToDouble(label1.Text));

            nn.setInputs(2, Convert.ToDouble(label2.Text));

            nn.setInputs(3, Convert.ToDouble(label3.Text));
            nn.run();
            label6.Text = "Actual Value:" + nn.getOuputData(0); 
            int result = nn.getOuputData(0) > .5 ? 1 : 0;
            label5.Text = ""+result;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (nn != null)
            {
                saveFileDialog1.DefaultExt = "txt";
                saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        nn.saveWeights(saveFileDialog1.FileName);
                        MessageBox.Show("Weights saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error saving weights: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void saveFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            String path = openFileDialog1.FileName;
            nn.loadWeights(path);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
