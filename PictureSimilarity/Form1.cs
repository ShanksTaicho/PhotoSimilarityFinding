﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;


namespace PictureSimilarity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }        

        private void button2_Click(object sender, EventArgs e)
        {
            arl2.Clear();
            openFileDialog1.ShowDialog();
            bmp2 = (Bitmap)Bitmap.FromFile(openFileDialog1.FileName);
            pictureBox2.Image = bmp2;
            for (int a =0;a<bmp2.Width;a++)
            {
                for (int b = 0;b<bmp2.Height;b++)
                {
                    arl2.Add(bmp2.GetPixel(a, b).Name);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double equal = 0;
            double notequal =0;
            for (int a = 0; a < arl.Count; a++)
            {
                if (arl[a].ToString() == arl2[a].ToString())
                {
                    equal++;
                }
                else
                {
                    notequal++;
                }
            }

            if (notequal ==0)
            {
                label1.Text = "%100";
            }
            else
            {
                if (equal>notequal)
                {
                    label1.Text = "%" + Convert.ToString(100 - ((notequal * 100) / equal)).Substring(0, 5);
                }
                else
                {
                    label1.Text = "%" + Convert.ToString((equal * 100) / notequal).Substring(0, 5);
                }
            }

        }

        Bitmap bmp1, bmp2;
        ArrayList arl = new ArrayList();
        ArrayList arl2 = new ArrayList();

        private void button1_Click(object sender, EventArgs e)
        {

            arl.Clear();
            openFileDialog1.ShowDialog();
            bmp1 = (Bitmap)Bitmap.FromFile(openFileDialog1.FileName);
            pictureBox1.Image = bmp1;
            
            for(int a=0;a<bmp1.Width;a++)
            {
                for(int b=0;b<bmp1.Height;b++)
                {
                    arl.Add(bmp1.GetPixel(a, b).Name);
                }
            }
        }
    }
}
