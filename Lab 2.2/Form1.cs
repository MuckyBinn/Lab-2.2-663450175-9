using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
        int index_count = 0;

        string[] area_id = new string[1000];
        string[] area_name = new string[1000];
        int[] area_score = new int[1000]; 
        
        int[] AG_score = new int[1];
        int start = 0,  sub_arr_length;
        int max_idx, max_value, min_value, min_idx;

        float[] A_grade = new float[8];
        int[] G_grade = new int[8];

        private void button1_Click(object sender, EventArgs e)
        {
            
            area_id[index_count] = Textboxstudent.Text;
            area_name[index_count] = textBoxname.Text;
            area_score[index_count] = int.Parse(score.Text);

            index_count++;
            Textboxstudent.Text = "";
            textBoxname.Text = "";
            score.Text = "";

            max_value = area_score.Max();
            max_idx = area_score.ToList().IndexOf(max_value);
            IdMax.Text = (area_id[max_idx]).ToString();
            NameMax.Text = (area_name[max_idx]).ToString();
            ScoreMax.Text = (area_score[max_idx]).ToString();

            AG_score = new int[index_count];
            sub_arr_length =index_count;
            Array.Copy(area_score, start, AG_score, 0, sub_arr_length);
            min_value = AG_score.Min();
            min_idx = area_score.ToList().IndexOf(min_value);
            Idmin.Text = (area_id[min_idx]).ToString();
            Namemin.Text = (area_name[min_idx]).ToString();
            ScoreMin.Text = (area_score[min_idx]).ToString();

            double AVG = (double)area_score.Sum() / (double)index_count;
            ScoreAVG.Text = string.Format("{0:0.00}", AVG);


            int point = area_score[index_count - 1];
            if (point >= 80 && point <= 100)
            {
                 
                G_grade[0] += 1;
                gradeA.Text = G_grade[0].ToString();
                A_grade[0] = G_grade[0] * 4;

            }
            else if (point >= 75 && point <= 79)
            {
                
                G_grade[1] += 1;
                gradBplus.Text = G_grade[1].ToString();
                A_grade[1] = G_grade[1] * 3.5f;
            }
            else if (point >= 70 && point <= 74)
            {
                
                G_grade[2] += 1;
                gradeB.Text = G_grade[2].ToString();
                A_grade[2] = G_grade[2] * 3.0f;

            }
            else if (point >= 65 && point <= 69)
            {
                
                G_grade[3] += 1;
                gradeCplus.Text = G_grade[3].ToString();
                A_grade[3] = G_grade[3] * 2.5f;
            }
            else if (point >= 60 && point <= 64)
            {
                
                G_grade[4] += 1;
                gradeC.Text = G_grade[4].ToString();
                A_grade[4] = G_grade[4] * 2.0f;
            }
            else if (point >= 55 && point <= 59)
            {
                
                G_grade[5] += 1;
                gradeDplus.Text = G_grade[5].ToString();
                A_grade[5] = G_grade[5] * 1.5f;
            }
            else if (point >= 50 && point <= 54)
            {
                
                G_grade[6] += 1;
                gradeD.Text = G_grade[6].ToString();
                A_grade[6] = G_grade[6] * 1.0f;
            }
            else
            {
                
                G_grade[7] += 1;
                gradeF.Text = G_grade[7].ToString();
            }
            

            Scoreplus.Text = $"{(double)A_grade.Sum() / (double)index_count:0.00}";

        }
    }
}
