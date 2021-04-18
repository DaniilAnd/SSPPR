using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Components;
using MetroFramework.Forms;

namespace Kurs_sppr
{
    public partial class Main : MetroForm
    {
        int[] input = null;
        private int sozd = 0;
        private int context = -1;
        DataGridViewCellStyle gray;
        double[,] krit = new double[3, 6];
        double[,] alt1 = new double[3, 6];
        double[,] alt2 = new double[3, 6];
        double[,] alt3 = new double[3, 6];
        double resalt1, resalt2, resalt3;
        public void MatrixInput(int[] i)
        {
            input = i;
        }
        void Supress()
        {
            средниеНормализованнойМатрицыКритериевToolStripMenuItem.Checked = true;
            весовыеКоэффициентыКритериевToolStripMenuItem.Checked = true;
            проверкаСогласованностиМатрицToolStripMenuItem.Checked = true;
            средниеНормализованнойМатрицыКритериевToolStripMenuItem_Click(this, EventArgs.Empty);
            весовыеКоэффициентыКритериевToolStripMenuItem_Click(this, EventArgs.Empty);
            проверкаСогласованностиМатрицToolStripMenuItem_Click(this, EventArgs.Empty);
        }
        void Cascade()
        {
            if (средниеНормализованнойМатрицыКритериевToolStripMenuItem.Checked == false)
                средниеНормализованнойМатрицыКритериевToolStripMenuItem_Click(this, EventArgs.Empty);
            if (весовыеКоэффициентыКритериевToolStripMenuItem.Checked == false)
                весовыеКоэффициентыКритериевToolStripMenuItem_Click(this, EventArgs.Empty);
            if (проверкаСогласованностиМатрицToolStripMenuItem.Checked == false)
                проверкаСогласованностиМатрицToolStripMenuItem_Click(this, EventArgs.Empty);
        }
            
        public Main()
        {
            InitializeComponent();
            MetroStyleManager.Default.Style = MetroFramework.MetroColorStyle.White;
            MetroStyleManager.Default.Theme = MetroFramework.MetroThemeStyle.Dark;
            gray = new DataGridViewCellStyle(dataGridView1.DefaultCellStyle);
            gray.BackColor = Color.Transparent;
            dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
            dataGridView1.Columns.Add("", "");
            dataGridView1.Columns.Add("", "");
            dataGridView1.Columns.Add("", "");
            dataGridView1.Columns.Add("", "");
            dataGridView1.Columns.Add("", "");
            dataGridView1.Columns.Add("", "");
            dataGridView1.Columns.Add("", "");
            dataGridView1.Columns[0].ValueType = typeof(double);
            dataGridView1.Columns[1].ValueType = typeof(double);
            dataGridView1.Columns[2].ValueType = typeof(double);
            dataGridView1.Columns[3].ValueType = typeof(double);
            dataGridView1.Columns[4].ValueType = typeof(double);
            dataGridView1.Columns[5].ValueType = typeof(double);
            dataGridView1.Columns[6].ValueType = typeof(double);
            dataGridView1.Columns[3].ReadOnly = true;
            dataGridView1.Columns[4].ReadOnly = true;
            dataGridView1.Columns[5].ReadOnly = true;
            dataGridView1.Columns[6].ReadOnly = true;
            dataGridView1.DefaultCellStyle.Format = "0.##";
            dataGridView1.Rows.Add(4);
            dataGridView1[0, 0].ReadOnly = true;
            dataGridView1[1, 1].ReadOnly = true;
            dataGridView1[2, 2].ReadOnly = true;
            alt1[0, 0] = 1.0; alt1[1, 1] = 1.0; alt1[2, 2] = 1.0;
            alt2[0, 0] = 1.0; alt2[1, 1] = 1.0; alt2[2, 2] = 1.0;
            alt3[0, 0] = 1.0; alt3[1, 1] = 1.0; alt3[2, 2] = 1.0;
            krit[0, 0] = 1.0; krit[1, 1] = 1.0; krit[2, 2] = 1.0;
            критерииToolStripMenuItem_Click(this, EventArgs.Empty);
        }

        private void новыйНаборКритериевToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (input != null)
            {
                DialogResult dr = new DialogResult();
                dr = MessageBox.Show("Новый набор критериев заменит существующий", "Внимание!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dr == System.Windows.Forms.DialogResult.Cancel) return;
            }
            input = null;
            Opros opros = new Opros(this);
            opros.ShowDialog();
            if (input == null) MessageBox.Show("Окно ввода было закрыто", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                krit[0, 0] = 1.0f;
                krit[1, 1] = 1.0f;
                krit[2, 2] = 1.0f;
                int c = 0;
                for (int i = 1; i <= 2; i++)
                    for (int j = i; j <= 2; j++)
                    {
                        if (input[c] > 0)
                        {
                            krit[i - 1, j] = input[c] + 1.0;
                            krit[j, i - 1] = 1.0 / (input[c] + 1.0);
                        }
                        else if (input[c] < 0)
                        {
                            krit[j, i - 1] = Math.Abs(input[c]) + 1.0;
                            krit[i - 1, j] = 1.0 / (Math.Abs(input[c]) + 1.0);
                        }
                        else
                        {
                            krit[j, i - 1] = input[c] + 1.0;
                            krit[i - 1, j] = input[c] + 1.0;
                        }
                        c++;
                    }
                критерииToolStripMenuItem_Click(this, EventArgs.Empty);
            }
            Supress();
            Cascade();
        }

        private void критерииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sozd |= 0x1;
            context = 0;
            toolStrip1.Items[1].Text = "Критерии";
            toolStrip1.Items[1].Enabled = false;
            dataGridView1.Columns[0].HeaderText = "Качество";
            dataGridView1.Columns[1].HeaderText = "Отзывы";
            dataGridView1.Columns[2].HeaderText = "Цена";
            for (int i = 0; i <= 2; i++)
                for (int j = 0; j <= 5; j++)
                    dataGridView1[j, i].Value = krit[i, j];
            Supress();
        }

        private void пустая1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sozd |= 0x2;
            context = 1;
            toolStrip1.Items[1].Text = пустая1ToolStripMenuItem.Text;
            toolStrip1.Items[1].Enabled = true;
            dataGridView1.Columns[0].HeaderText = "Аккумулятор";
            dataGridView1.Columns[1].HeaderText = "ОС";
            dataGridView1.Columns[2].HeaderText = "Цена";
            for (int i = 0; i <= 2; i++)
                for (int j = 0; j <= 5; j++)
                    dataGridView1[j, i].Value = alt1[i, j];
            Supress();
        }

        private void пустая2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sozd |= 0x4;
            context = 2;
            toolStrip1.Items[1].Text = пустая2ToolStripMenuItem.Text;
            toolStrip1.Items[1].Enabled = true;
            dataGridView1.Columns[0].HeaderText = "Аккумулятор";
            dataGridView1.Columns[1].HeaderText = "ОС";
            dataGridView1.Columns[2].HeaderText = "Цена";
            for (int i = 0; i <= 2; i++)
                for (int j = 0; j <= 5; j++)
                    dataGridView1[j, i].Value = alt2[i, j];
            Supress();
        }

        private void пустая3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sozd |= 0x8;
            context = 3;
            toolStrip1.Items[1].Text = пустая3ToolStripMenuItem.Text;
            toolStrip1.Items[1].Enabled = true;
            dataGridView1.Columns[0].HeaderText = "Аккумулятор";
            dataGridView1.Columns[1].HeaderText = "ОС";
            dataGridView1.Columns[2].HeaderText = "Цена";
            for (int i = 0; i <= 2; i++)
                for (int j = 0; j <= 5; j++)
                    dataGridView1[j, i].Value = alt3[i, j];
            Supress();
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            switch (context)
            {
                case 1: пустая1ToolStripMenuItem.Text = toolStripTextBox1.Text; break;
                case 2: пустая2ToolStripMenuItem.Text = toolStripTextBox1.Text; break;
                case 3: пустая3ToolStripMenuItem.Text = toolStripTextBox1.Text; break;
            }
        }

        private void средниеНормализованнойМатрицыКритериевToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1[2, 2].Value == "" || (double)dataGridView1[2, 2].Value == 0.0) { MessageBox.Show("Нет матрицы!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (средниеНормализованнойМатрицыКритериевToolStripMenuItem.Checked == false)
            {
                dataGridView1.Columns[3].HeaderText = "Средние значения норм. матрицы";
                switch (context)
                {
                    case 0:
                        krit[0, 3] = ((double)dataGridView1[0, 0].Value + (double)dataGridView1[0, 1].Value + (double)dataGridView1[0, 2].Value);
                        krit[1, 3] = ((double)dataGridView1[1, 0].Value + (double)dataGridView1[1, 1].Value + (double)dataGridView1[1, 2].Value);
                        krit[2, 3] = ((double)dataGridView1[2, 0].Value + (double)dataGridView1[2, 1].Value + (double)dataGridView1[2, 2].Value);
                        dataGridView1[3, 0].Value = krit[0, 3];
                        dataGridView1[3, 1].Value = krit[1, 3];
                        dataGridView1[3, 2].Value = krit[2, 3];
                        break;
                    case 1:
                        alt1[0, 3] = ((double)dataGridView1[0, 0].Value + (double)dataGridView1[0, 1].Value + (double)dataGridView1[0, 2].Value);
                        alt1[1, 3] = ((double)dataGridView1[1, 0].Value + (double)dataGridView1[1, 1].Value + (double)dataGridView1[1, 2].Value);
                        alt1[2, 3] = ((double)dataGridView1[2, 0].Value + (double)dataGridView1[2, 1].Value + (double)dataGridView1[2, 2].Value);
                        dataGridView1[3, 0].Value = alt1[0, 3];
                        dataGridView1[3, 1].Value = alt1[1, 3];
                        dataGridView1[3, 2].Value = alt1[2, 3];
                        break;
                    case 2:
                        alt2[0, 3] = ((double)dataGridView1[0, 0].Value + (double)dataGridView1[0, 1].Value + (double)dataGridView1[0, 2].Value);
                        alt2[1, 3] = ((double)dataGridView1[1, 0].Value + (double)dataGridView1[1, 1].Value + (double)dataGridView1[1, 2].Value);
                        alt2[2, 3] = ((double)dataGridView1[2, 0].Value + (double)dataGridView1[2, 1].Value + (double)dataGridView1[2, 2].Value);
                        dataGridView1[3, 0].Value = alt2[0, 3];
                        dataGridView1[3, 1].Value = alt2[1, 3];
                        dataGridView1[3, 2].Value = alt2[2, 3];
                        break;
                    case 3:
                        alt3[0, 3] = ((double)dataGridView1[0, 0].Value + (double)dataGridView1[0, 1].Value + (double)dataGridView1[0, 2].Value);
                        alt3[1, 3] = ((double)dataGridView1[1, 0].Value + (double)dataGridView1[1, 1].Value + (double)dataGridView1[1, 2].Value);
                        alt3[2, 3] = ((double)dataGridView1[2, 0].Value + (double)dataGridView1[2, 1].Value + (double)dataGridView1[2, 2].Value);
                        dataGridView1[3, 0].Value = alt3[0, 3];
                        dataGridView1[3, 1].Value = alt3[1, 3];
                        dataGridView1[3, 2].Value = alt3[2, 3];
                        break;
                }
                for (int i = 0; i <= 2; i++)
                    for (int j = 0; j <= 2; j++)
                        dataGridView1[j, i].Value = (double)dataGridView1[j, i].Value / (double)dataGridView1[3, j].Value;
                средниеНормализованнойМатрицыКритериевToolStripMenuItem.Checked ^= true;
            }
            else { dataGridView1.Columns[3].HeaderText = ""; dataGridView1[3, 0].Value = ""; dataGridView1[3, 1].Value = ""; dataGridView1[3, 2].Value = ""; средниеНормализованнойМатрицыКритериевToolStripMenuItem.Checked ^= true; }
        }

        private void весовыеКоэффициентыКритериевToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (весовыеКоэффициентыКритериевToolStripMenuItem.Checked == false)
            {
                dataGridView1.Columns[4].HeaderText = "Весовые коэффициенты";
                if (dataGridView1[3, 2].Value == "" || (double)dataGridView1[3, 2].Value == 0.0) средниеНормализованнойМатрицыКритериевToolStripMenuItem_Click(this, EventArgs.Empty);
                switch (context)
                {
                    case 0:
                        krit[0, 4] = ((double)dataGridView1[0, 0].Value + (double)dataGridView1[1, 0].Value + (double)dataGridView1[2, 0].Value) / 3.0;
                        krit[1, 4] = ((double)dataGridView1[0, 1].Value + (double)dataGridView1[1, 1].Value + (double)dataGridView1[2, 1].Value) / 3.0;
                        krit[2, 4] = ((double)dataGridView1[0, 2].Value + (double)dataGridView1[1, 2].Value + (double)dataGridView1[2, 2].Value) / 3.0;
                        dataGridView1[4, 0].Value = krit[0, 4];
                        dataGridView1[4, 1].Value = krit[1, 4];
                        dataGridView1[4, 2].Value = krit[2, 4];
                        break;
                    case 1:
                        alt1[0, 4] = ((double)dataGridView1[0, 0].Value + (double)dataGridView1[1, 0].Value + (double)dataGridView1[2, 0].Value) / 3.0;
                        alt1[1, 4] = ((double)dataGridView1[0, 1].Value + (double)dataGridView1[1, 1].Value + (double)dataGridView1[2, 1].Value) / 3.0;
                        alt1[2, 4] = ((double)dataGridView1[0, 2].Value + (double)dataGridView1[1, 2].Value + (double)dataGridView1[2, 2].Value) / 3.0;
                        dataGridView1[4, 0].Value = alt1[0, 4];
                        dataGridView1[4, 1].Value = alt1[1, 4];
                        dataGridView1[4, 2].Value = alt1[2, 4];
                        break;
                    case 2:
                        alt2[0, 4] = ((double)dataGridView1[0, 0].Value + (double)dataGridView1[1, 0].Value + (double)dataGridView1[2, 0].Value) / 3.0;
                        alt2[1, 4] = ((double)dataGridView1[0, 1].Value + (double)dataGridView1[1, 1].Value + (double)dataGridView1[2, 1].Value) / 3.0;
                        alt2[2, 4] = ((double)dataGridView1[0, 2].Value + (double)dataGridView1[1, 2].Value + (double)dataGridView1[2, 2].Value) / 3.0;
                        dataGridView1[4, 0].Value = alt2[0, 4];
                        dataGridView1[4, 1].Value = alt2[1, 4];
                        dataGridView1[4, 2].Value = alt2[2, 4];
                        break;
                    case 3:
                        alt3[0, 4] = ((double)dataGridView1[0, 0].Value + (double)dataGridView1[1, 0].Value + (double)dataGridView1[2, 0].Value) / 3.0;
                        alt3[1, 4] = ((double)dataGridView1[0, 1].Value + (double)dataGridView1[1, 1].Value + (double)dataGridView1[2, 1].Value) / 3.0;
                        alt3[2, 4] = ((double)dataGridView1[0, 2].Value + (double)dataGridView1[1, 2].Value + (double)dataGridView1[2, 2].Value) / 3.0;
                        dataGridView1[4, 0].Value = alt3[0, 4];
                        dataGridView1[4, 1].Value = alt3[1, 4];
                        dataGridView1[4, 2].Value = alt3[2, 4];
                        break;
                }
                весовыеКоэффициентыКритериевToolStripMenuItem.Checked ^= true;
            }
            else { dataGridView1.Columns[4].HeaderText = ""; dataGridView1[4, 0].Value = ""; dataGridView1[4, 1].Value = ""; dataGridView1[4, 2].Value = ""; весовыеКоэффициентыКритериевToolStripMenuItem.Checked ^= true; }
        }

        private void проверкаСогласованностиМатрицToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (проверкаСогласованностиМатрицToolStripMenuItem.Checked == false)
            {
                dataGridView1.Columns[5].HeaderText = "Проверка согласованности";
                if (dataGridView1[4, 2].Value == "" || (double)dataGridView1[4, 2].Value == 0.0) весовыеКоэффициентыКритериевToolStripMenuItem_Click(this, EventArgs.Empty);
                double nmax = 0.0;

                switch (context)
                {
                    case 0:
                        for (int i = 0; i <= 2; i++)
                            nmax += krit[i, 0] * (double)dataGridView1[4, 0].Value + krit[i, 1] * (double)dataGridView1[4, 1].Value + krit[i, 2] * (double)dataGridView1[4, 2].Value;
                        krit[0, 5] = (nmax - 3) / 2;
                        krit[1, 5] = 1.98 / 3.0;
                        krit[2, 5] = ((nmax - 3) / 2) / (1.98 / 3.0);
                        if (krit[2, 5] < 0.1) dataGridView1[5, 3].Style.BackColor = Color.Green;
                        else dataGridView1[5, 3].Style.BackColor = Color.Red;
                        break;
                    case 1:
                        for (int i = 0; i <= 2; i++)
                            nmax += alt1[i, 0] * (double)dataGridView1[4, 0].Value + alt1[i, 1] * (double)dataGridView1[4, 1].Value + alt1[i, 2] * (double)dataGridView1[4, 2].Value;
                        alt1[0, 5] = (nmax - 3) / 2;
                        alt1[1, 5] = 1.98 / 3.0;
                        alt1[2, 5] = ((nmax - 3) / 2) / (1.98 / 3.0);
                        if (alt1[2, 5] < 0.1) dataGridView1[5, 3].Style.BackColor = Color.Green;
                        else dataGridView1[5, 3].Style.BackColor = Color.Red;
                        break;
                    case 2:
                        for (int i = 0; i <= 2; i++)
                            nmax += alt2[i, 0] * (double)dataGridView1[4, 0].Value + alt2[i, 1] * (double)dataGridView1[4, 1].Value + alt2[i, 2] * (double)dataGridView1[4, 2].Value;
                        alt2[0, 5] = (nmax - 3) / 2;
                        alt2[1, 5] = 1.98 / 3.0;
                        alt2[2, 5] = ((nmax - 3) / 2) / (1.98 / 3.0);
                        if (alt2[2, 5] < 0.1) dataGridView1[5, 3].Style.BackColor = Color.Green;
                        else dataGridView1[5, 3].Style.BackColor = Color.Red;
                        break;
                    case 3:
                        for (int i = 0; i <= 2; i++)
                            nmax += alt3[i, 0] * (double)dataGridView1[4, 0].Value + alt3[i, 1] * (double)dataGridView1[4, 1].Value + alt3[i, 2] * (double)dataGridView1[4, 2].Value;
                        alt3[0, 5] = (nmax - 3) / 2;
                        alt3[1, 5] = 1.98 / 3.0;
                        alt3[2, 5] = ((nmax - 3) / 2) / (1.98 / 3.0);
                        if (alt3[2, 5] < 0.1) dataGridView1[5, 3].Style.BackColor = Color.Green;
                        else dataGridView1[5, 3].Style.BackColor = Color.Red;
                        break;
                }
                dataGridView1[5, 0].Value = "CI = " + ((nmax - 3) / 2).ToString();
                dataGridView1[5, 1].Value = "RI = " + (1.98 / 3.0).ToString();
                dataGridView1[5, 2].Value = "CR = " + (((nmax - 3) / 2) / (1.98 / 3.0)).ToString();
                dataGridView1[5, 3].Value = "CR < 0.1";
                проверкаСогласованностиМатрицToolStripMenuItem.Checked ^= true;
            }
            else { dataGridView1.Columns[5].HeaderText = ""; dataGridView1[5, 0].Value = ""; dataGridView1[5, 1].Value = ""; dataGridView1[5, 2].Value = ""; dataGridView1[5, 3].Value = ""; проверкаСогласованностиМатрицToolStripMenuItem.Checked ^= true; dataGridView1[5, 3].Style.BackColor = Color.White; }
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellLeave(object sender, DataGridViewCellParsingEventArgs e)
        {
            if (e.ColumnIndex != e.RowIndex && e.ColumnIndex < 3 && e.RowIndex < 3)
            {
                double temp;
                if (!double.TryParse(e.Value.ToString(), out temp)) { MessageBox.Show("Значение должно быть вещественным числом!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); e.Value = dataGridView1[e.ColumnIndex, e.RowIndex].Value; return; }
                double itemp = 0.0;
                if (temp < 1.0) { itemp = Math.Round(1.0 / temp); temp = 1.0 / itemp; }
                else if (temp > 1.0) { temp = Math.Round(temp); itemp = 1.0 / temp; }
                else { temp = 1.0; itemp = 1; }
                if (temp > 6.0 || itemp < 1/6.0) { MessageBox.Show("Значение не может быть больше 6.0!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); e.Value = dataGridView1[e.ColumnIndex, e.RowIndex].Value; return; }
                if (temp < 1.0 / 6.0 || itemp > 6.0) { MessageBox.Show("Значение не может быть меньше 1/6!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); e.Value = dataGridView1[e.ColumnIndex, e.RowIndex].Value;  return; }
                e.Value = temp;
                switch (context)
                {
                    case 0:
                        krit[e.RowIndex, e.ColumnIndex] = temp;
                        krit[e.ColumnIndex, e.RowIndex] = itemp;
                        break;
                    case 1:
                        alt1[e.RowIndex, e.ColumnIndex] = temp;
                        alt1[e.ColumnIndex, e.RowIndex] = itemp;
                        break;
                    case 2:
                        alt2[e.RowIndex, e.ColumnIndex] = temp;
                        alt2[e.ColumnIndex, e.RowIndex] = itemp;
                        break;
                    case 3:
                        alt3[e.RowIndex, e.ColumnIndex] = temp;
                        alt3[e.ColumnIndex, e.RowIndex] = itemp;
                        break;
                }
                dataGridView1[e.RowIndex, e.ColumnIndex].Value = itemp;
                dataGridView1[e.ColumnIndex, e.RowIndex].Value = temp;
                Supress();
                
            }
        }

        private void рекомендацииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sozd != 15) { MessageBox.Show("Заполнить критерии и альтернативы!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            resalt1 = alt1[0, 4] * krit[0, 4] + alt1[1, 4] * krit[1, 4] + alt1[2, 4] * krit[2, 4];
            resalt2 = alt2[0, 4] * krit[0, 4] + alt2[1, 4] * krit[1, 4] + alt2[2, 4] * krit[2, 4];
            resalt3 = alt3[0, 4] * krit[0, 4] + alt3[1, 4] * krit[1, 4] + alt3[2, 4] * krit[2, 4];

            MessageBox.Show(пустая1ToolStripMenuItem.Text + " = " + resalt1.ToString() + Environment.NewLine +
                            пустая2ToolStripMenuItem.Text + " = " + resalt2.ToString() + Environment.NewLine +
                            пустая3ToolStripMenuItem.Text + " = " + resalt3.ToString() + Environment.NewLine +
                            Environment.NewLine + "Лучший вес - " + Math.Max(resalt1, Math.Max(resalt2, resalt3)));
        }
    }
}

