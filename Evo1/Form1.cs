using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evo1
{
    public partial class Form1 : Form
    {
        public string[] population;

        public double[] sectors;

        public string ConverterToBinary(int number, int length)
        {
            string digit = Convert.ToString(number, 2);
            if (digit.Length < length)
            {
                digit = digit.PadLeft(length, '0');
            }
            if (digit.Length > length)
            {
                digit = digit.Substring(digit.Length - length);
            }
            return digit;
        }

        public void Generation(int num)
        {
            population = new string[num];
            for (int i = 0; i < num; i++)
            {
                Random number = new Random();
                string osob = ConverterToBinary(number.Next(), Convert.ToInt32(textBox2.Text));
                population[i] = osob;
            }
        }

        public double func(int x)
        {
            return (double)Math.Sin(x / 4) + 1.5;
        }

        public void Selection()
        {
            Random rand = new Random();
            sectors = new double[Convert.ToInt32(textBox2.Text)];
            sectors[0] = func(Convert.ToInt32(population[0]));
            for (int i = 1; i < Convert.ToInt32(textBox2.Text); i++)
            {
                sectors[i] = sectors[i - 1] + func(ConverterToDecimal(population[i]));
            }

            for (int i = 0; i < Convert.ToInt32(textBox2.Text); i++)
            {
                sectors[i] /= sectors[Convert.ToInt32(textBox2.Text) - 1];
            }

            for (int i = 0; i < Convert.ToInt32(textBox2.Text); i++)
            {
                double randomValue = rand.NextDouble();
                for (int j = 0; j < Convert.ToInt32(textBox2.Text); j++)
                {
                    if (randomValue < sectors[j])
                    {
                        population[i] = population[j];
                        j = Convert.ToInt32(textBox2.Text);
                    }
                }
            }
            int stop = 0;
        }

        public void Crossing(int point)
        {
            for (int i = 1; i < Convert.ToInt32(textBox2.Text); i += 2)
            {
                StringBuilder part1 = new StringBuilder(population[i - 1]);
                StringBuilder part2 = new StringBuilder(population[i]);
                for (int j = point - 1; j < population[i].Length; j++)
                {
                    part1[j] = population[i][j];
                    part2[j] = population[i - 1][j];
                }
                population[i - 1] = part1.ToString();
                population[i] = part2.ToString();
            }
        }

        public void Mutation()
        {
            for (int i = 0; i < Convert.ToInt32(textBox2.Text); i++)
            {
                StringBuilder sb = new StringBuilder(population[i]);
                for (int j = 0; j < sb.Length; j++)
                {
                    if (sb[j] == '0')
                        sb[j] = '1';
                    else
                        sb[j] = '0';
                }
                population[i] = sb.ToString();
            }
        }

        public int Result()
        {
            int result = 0;
            double max = 0;
            for (int i = 0; i < Convert.ToInt32(textBox2.Text); i++)
            {
                if (max <= func(ConverterToDecimal(population[i])))
                {
                    max = func(ConverterToDecimal(population[i]));
                    result = ConverterToDecimal(population[i]);
                }
            }
            return result;
        }

        public int ConverterToDecimal(string digit)
        {
            return Convert.ToInt32(digit, 2);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(textBox1.Text);
            int length = Convert.ToInt32(textBox2.Text);
            string digit = ConverterToBinary(number, length);
            textBox3.Text = digit;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = ConverterToDecimal(textBox3.Text).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Generation(Convert.ToInt32(textBox4.Text));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Selection();
            label6.Text = population[0];
            label7.Text = population[1];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Crossing(Convert.ToInt32(textBox5.Text));
            label8.Text = population[0];
            label9.Text = population[1];
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Mutation();
            label6.Text = population[0];
            label7.Text = population[1];
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label10.Text = Result().ToString();
        }
    }
}
