using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kurs_sppr
{
    public partial class Opros : Form
    {
        Main mainform;
        string[] Xs, Ys;
        int count;
        string temp;
        List<int> otvety = new List<int>();
        string ObnovitStroku()
        {
            switch (trackBar1.Value)
            {
                case -5: temp = Ys[count].ToString() + " критически важнее, чем " + Xs[count].ToString(); break;
                case -4: temp = Ys[count].ToString() + " гораздо важнее, чем " + Xs[count].ToString(); break;
                case -3: temp = Ys[count].ToString() + " заметно важнее, чем " + Xs[count].ToString(); break;
                case -2: temp = Ys[count].ToString() + " несколько важнее, чем " + Xs[count].ToString(); break;
                case -1: temp = Ys[count].ToString() + " чуть важнее, чем " + Xs[count].ToString(); break;
                case 0: temp = Ys[count].ToString() + " и " + Xs[count].ToString() + " равнозначны"; break;
                case 5: temp = Xs[count].ToString() + " критически важнее, чем " + Ys[count].ToString(); break;
                case 4: temp = Xs[count].ToString() + " гораздо важнее, чем " + Ys[count].ToString(); break;
                case 3: temp = Xs[count].ToString() + " заметно важнее, чем " + Ys[count].ToString(); break;
                case 2: temp = Xs[count].ToString() + " несколько важнее, чем " + Ys[count].ToString(); break;
                case 1: temp = Xs[count].ToString() + " чуть важнее, чем " + Ys[count].ToString(); break;
            }
            return char.ToUpper(temp[0]) + temp.Substring(1); ;
        }
        public Opros(Main mainform)
        {
            InitializeComponent();
            this.mainform = mainform;
            count = 0;
            Xs = new string[] { "Качество изображения", "Качество изображения", "Цена" };
            Ys = new string[] { "Цена", "Цена", "Качество изображения" };
            if (Xs.Length != Ys.Length)
            {
                MessageBox.Show("Программисту - списки парных критериев имеют разную длину", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            progressBar1.Maximum = Xs.Length-1;
            label2.Text = ObnovitStroku();
            label1.Text = "Что вам более важно: " + Xs[count] + " или " + Ys[count] + "?";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
            otvety.Add(trackBar1.Value);
            if (count < Xs.Length - 1) count++;
            else { mainform.MatrixInput(otvety.ToArray()); this.Close(); }
            label2.Text = ObnovitStroku();
            label1.Text = "Что вам более важно: " + Xs[count] + " или " + Ys[count] + "?";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label2.Text = ObnovitStroku();
        }
    }
}
