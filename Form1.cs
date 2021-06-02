using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gaussSonya
{
    public partial class Form1 : Form
    {
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int N = Convert.ToInt32(textBox1.Text);
            double[,] A = new double[N, N];
            double[] B = new double[N];

            for (int i = 0; i < N; i++)
            {

                for (int j = 0; j < (N); j++)
                {
                     A[i, j] = Convert.ToInt32(dataGridView1.Rows[i].Cells[j].Value.ToString());
                     dataGridView3.Rows[i].Cells[j].Value= A[i, j];
                }
            }

            for (int i = 0; i < 1; i++)
                for (int j = 0; j < N; j++)
                {
                    B[j] = Convert.ToInt32(dataGridView2.Rows[j].Cells[0].Value.ToString());
                    dataGridView4.Rows[j].Cells[0].Value = B[j];
                }
            double[] x = new double[N];
            for (int i = 0; i < N; i++)
            { x[i] = 0; } /// корни
             int k = 0;
             int prei = 0;
                    for (k = 0; k < N; k++) //Решение
                    {
                        for (int i = k + 1; i < N; i++)
                        {

                            for (int j = k + 1; j < N; j++)
                            {
                                {
                                    A[i, j] = A[i, j] - (A[k, j] * A[i, k] / A[k, k]);
                                    dataGridView3.Rows[i].Cells[j].Value = A[i, j];
                                    if (i != prei||(k==(N-2))) // не дает на 2ой раз пересчитать этот столб
                                    {
                                        B[i] = B[i] - (B[k] * A[i, k] / A[k, k]);
                                    }
                                    dataGridView4.Rows[i].Cells[0].Value = B[i];
                                    prei = i;
                                }
                               
                            }
                          

                        }

                    }
               for (int i = 0; i < N; i++) //нули
                  {
                      for (int j = 0; j < N; j++)
                      {
                          if (i > j)
                          {
                              dataGridView3.Rows[i].Cells[j].Value = 0;
                          }
                      }
                  }

                for ( k = N - 1; k >= 0; k--) // для корней
                {
                    double sum = 0;
                    for (int j = k + 1; j < N; j++)
                        sum = sum + A[k, j] * x[j];
                    x[k] = (B[k] - sum) / A[k, k];
                    dataGridView5.Rows[k].Cells[0].Value = x[k];
                }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int N = Convert.ToInt32(textBox1.Text);
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.ColumnCount = Convert.ToInt32(textBox1.Text);
            dataGridView1.RowCount = N;
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();
            dataGridView5.Columns.Clear();
            dataGridView2.ColumnCount = 1;
            dataGridView2.RowCount = N;


            dataGridView3.Rows.Clear();
            dataGridView3.Columns.Clear();
            dataGridView3.ColumnCount = Convert.ToInt32(textBox1.Text);
            dataGridView3.RowCount = N;
            dataGridView4.Rows.Clear();
            dataGridView4.Columns.Clear();
            dataGridView4.ColumnCount = 1;
            dataGridView4.RowCount = N;
            dataGridView5.ColumnCount = 1;
            dataGridView5.RowCount = N;

            for (int i = 0; i < N; i++)
            {

                for (int j = 0; j < (N); j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = 1;
                    dataGridView2.Rows[i].Cells[0].Value = 2;
                }

            }
            if (N == 4)
            {
                dataGridView1.Rows[0].Cells[0].Value = 1;
                dataGridView1.Rows[0].Cells[1].Value = 2;
                dataGridView1.Rows[0].Cells[2].Value = -3;
                dataGridView1.Rows[0].Cells[3].Value = 1;

                dataGridView1.Rows[1].Cells[0].Value = 2;
                dataGridView1.Rows[1].Cells[1].Value = 1;
                dataGridView1.Rows[1].Cells[2].Value = 4;
                dataGridView1.Rows[1].Cells[3].Value = -2;

                dataGridView1.Rows[2].Cells[0].Value = -2;
                dataGridView1.Rows[2].Cells[1].Value = -3;
                dataGridView1.Rows[2].Cells[2].Value = 1;
                dataGridView1.Rows[2].Cells[3].Value = 3;

                dataGridView1.Rows[3].Cells[0].Value = 1;
                dataGridView1.Rows[3].Cells[1].Value = -2;
                dataGridView1.Rows[3].Cells[2].Value = 4;
                dataGridView1.Rows[3].Cells[3].Value = -5;

                dataGridView2.Rows[0].Cells[0].Value = 3;
                dataGridView2.Rows[1].Cells[0].Value = 6;
                dataGridView2.Rows[2].Cells[0].Value = -4;
                dataGridView2.Rows[3].Cells[0].Value = -4;
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int N = Convert.ToInt32(textBox1.Text);
            double[,] A = new double[N, N];
            double[] B = new double[N];

            for (int i = 0; i < N; i++)
            {

                for (int j = 0; j < (N); j++)//заполнение
                {
                    A[i, j] = Convert.ToInt32(dataGridView1.Rows[i].Cells[j].Value.ToString());
                    dataGridView3.Rows[i].Cells[j].Value = A[i, j];
                }
            }

            for (int i = 0; i < 1; i++)
                for (int j = 0; j < N; j++)//заполнение
                {
                    B[j] = Convert.ToInt32(dataGridView2.Rows[j].Cells[0].Value.ToString());
                    dataGridView4.Rows[j].Cells[0].Value = B[j];
                }
            double[] x = new double[N];
            for (int i = 0; i < N; i++)
            { 
                x[i] = 0; /// корни
            }
            int prei = 0;
            for (int k = 0; k<N;k++)//решение
            {
                for(int i = 0;i<N;i++)
                {
                    for(int j=0;j<N;j++)
                    {
                        if ((i != k) && (j != k)) // нахождение 
                        {
                            A[i, j] = A[i, j] - (A[i, k] * A[k, j] / A[k, k]);
                            if (i != prei) // не дает на 2ой раз пересчитать этот столб
                            {
                                B[i] = B[i] - A[i, k] * B[k] / A[k, k];
                            }
                            dataGridView3.Rows[i].Cells[j].Value = A[i, j];
                            dataGridView4.Rows[i].Cells[0].Value = B[i];
                            prei = i;
                        }
                    }
                }
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {

                        if (i != k)
                        {
                            A[i, k] = 0;
                            dataGridView3.Rows[i].Cells[j].Value = A[i, j];
                        }
                    }
                }

            } // конец for()

            for(int i =0;i<N;i++)
            {
                for(int j = 0;j<N;j++)
                {
                    if (A[i, j] != 0)
                    {
                        x[i] = B[i] / A[i, j];
                        dataGridView5.Rows[i].Cells[0].Value = x[i];
                    }
                    
                }
            }
            MessageBox.Show("ЛИПОВЫХ НУЛЕЙ НЕТ!");
        }
    }
}
