﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8
{
    public partial class Form1 : Form
    {
        private int[] Arr = new int[10];
        public Form1()
        {
            InitializeComponent();
        }

        private void txtN_TextChanged(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearFields()
        {
            lblArr.Text = "";
            lblResult.Text = "";
            labelSortik.Text = "";
            btnSort.Enabled = false;
            button1.Enabled = false;
        }


        static int[] Insertion(int[] a)
        {
            for (int i = 1; i < a.Length; i++)
            {
                int k = a[i];
                int j = i - 1;

                while (j >= 0 && a[j] > k)
                {
                    a[j + 1] = a[j];
                    a[j] = k;
                    j--;
                }
            }
            return a;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Arr.Length; i++)
            {
                labelSortik.Text += Arr[i];
                if (i != Arr.Length - 1) labelSortik.Text += ", ";
            }
            button1.Enabled = true;
        }

        private void labelSortik_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnNewArr_Click_1(object sender, EventArgs e)
        {
            int n = 10;
            int a = int.Parse(txtMin.Text);
            int b = int.Parse(txtMax.Text);
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                Arr[i] = r.Next(a, b);
                lblArr.Text += Arr[i];
                if (i != n) lblArr.Text += ", ";
            }
            btnSort.Enabled = true;
            button1.Enabled = true;
        }

        private int MinNumber(int[] x, int m)
        {
            int min = x[m];
            int MinN = m;
            for (int i = m; i < x.Length; i++)
            {
                if (x[i] < min)
                {
                    min = x[i];
                    MinN = i;
                }
            }
            return MinN;
        }

        private void btnSort_Click_1(object sender, EventArgs e)
        {
            int k, t;
            for (int i = 0; i < Arr.Length; i++)
            {
                k = MinNumber(Arr, i);
                t = Arr[i];
                Arr[i] = Arr[k];
                Arr[k] = t;
                lblResult.Text += Arr[i];
                if (i != Arr.Length - 1) { lblResult.Text += ", "; }
            }
            btnSort.Enabled = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < Arr.Length; i++)
            {
                labelSortik.Text += Arr[i];
                if (i != Arr.Length - 1) labelSortik.Text += ", ";
            }
            button1.Enabled = true;
        }

        private void txtMax_TextChanged_1(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void txtMin_TextChanged_1(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
