using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_Ping
{
    public partial class SettingsPing : Form
    {
        public SettingsPing()
        {
            InitializeComponent();
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;        // Запрещаем изменение формы
            groupBox1.Location = new System.Drawing.Point(205, 85);
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            button1.Location = new System.Drawing.Point(225, 200);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            
            int w = (int)this.ClientSize.Width; // ширина окна            
            int h = (int)this.ClientSize.Height; // высота окна

            int indexItem = Convert.ToInt32(comboBox1.Text);

            switch(indexItem)
            {
                case 1:
                    groupBox1.Location = new System.Drawing.Point(205, 85);
                    button1.Location = new System.Drawing.Point(225, 200);
                    groupBox1.Visible = true;
                    groupBox2.Visible = false;
                    groupBox3.Visible = false;
                    groupBox4.Visible = false;
                    groupBox5.Visible = false;
                    break;
                case 2:
                    groupBox1.Location = new System.Drawing.Point(110, 85);
                    groupBox2.Location = new System.Drawing.Point(295, 85);
                    button1.Location = new System.Drawing.Point(225, 200);
                    groupBox1.Visible = true;
                    groupBox2.Visible = true;
                    groupBox3.Visible = false;
                    groupBox4.Visible = false;
                    groupBox5.Visible = false;
                    break;
                case 3:
                    groupBox1.Location = new System.Drawing.Point(25, 85);
                    groupBox2.Location = new System.Drawing.Point(205, 85);
                    groupBox3.Location = new System.Drawing.Point(375, 85);
                    button1.Location = new System.Drawing.Point(225, 200);
                    groupBox1.Visible = true;
                    groupBox2.Visible = true;
                    groupBox3.Visible = true;
                    groupBox4.Visible = false;
                    groupBox5.Visible = false;
                    break;
                case 4:
                    groupBox1.Location = new System.Drawing.Point(25, 85);
                    groupBox2.Location = new System.Drawing.Point(205, 85);
                    groupBox3.Location = new System.Drawing.Point(375, 85);
                    button1.Location = new System.Drawing.Point(225, 300);
                    groupBox1.Visible = true;
                    groupBox2.Visible = true;
                    groupBox3.Visible = true;
                    groupBox4.Visible = true;
                    groupBox5.Visible = false;
                    break;
                case 5:
                    groupBox1.Location = new System.Drawing.Point(25, 85);
                    groupBox2.Location = new System.Drawing.Point(205, 85);
                    groupBox3.Location = new System.Drawing.Point(375, 85);
                    button1.Location = new System.Drawing.Point(225, 300);
                    groupBox1.Visible = true;
                    groupBox2.Visible = true;
                    groupBox3.Visible = true;
                    groupBox4.Visible = true;
                    groupBox5.Visible = true;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch(Convert.ToInt32(comboBox1.Text))
            {
                case 1:
                    Program.mainForm.textBox1.Text = textBox1.Text;
                    break;
                case 2:
                    Program.mainForm.textBox1.Text = textBox1.Text + "|" + textBox2.Text;
                    break;
                case 3:
                    Program.mainForm.textBox1.Text = textBox1.Text + "|" + textBox2.Text + "|" + textBox3.Text;
                    break;
                case 4:
                    Program.mainForm.textBox1.Text = textBox1.Text + "|" + textBox2.Text + "|" + textBox3.Text + "|" + textBox4.Text;
                    break;
                case 5:
                    Program.mainForm.textBox1.Text = textBox1.Text + "|" + textBox2.Text + "|" + textBox3.Text + "|" + textBox4.Text + "|" + textBox5.Text;
                    break;
            }
            Program.mainForm.countURL = Convert.ToInt32(comboBox1.Text);
            SetColor();
            Close();
        }

        private void SetColor()
        { 
            int[] indexColor = GetIndexComboBox();

            for(int i = 0; i < 5; i++)
            {
                if (indexColor[i] == -1) { SetColorSeries(i, i); }
                else 
                {
                    SetColorSeries(indexColor[i], i);
                }
            }

        }

        private int[] GetIndexComboBox()
        {
            int[] indexColor = new int[5];
            indexColor[0] = comboBox2.SelectedIndex;
            indexColor[1] = comboBox3.SelectedIndex;
            indexColor[2] = comboBox4.SelectedIndex;
            indexColor[3] = comboBox5.SelectedIndex;
            indexColor[4] = comboBox6.SelectedIndex;

            return indexColor;
        }

        // Получаем установленный цвет пользователем
        private void SetColorSeries(int indexColor, int indexSeries)              
        {
            switch(indexColor)
            {
                case 0:
                    Program.mainForm.chart1.Series[indexSeries].Color = Color.Gold;
                    break;
                case 1:
                    Program.mainForm.chart1.Series[indexSeries].Color = Color.Crimson;
                    break;
                case 2:
                    Program.mainForm.chart1.Series[indexSeries].Color = Color.DarkGray;
                    break;
                case 3:
                    Program.mainForm.chart1.Series[indexSeries].Color = Color.DeepSkyBlue;
                    break;
                case 4:
                    Program.mainForm.chart1.Series[indexSeries].Color = Color.Black;
                    break;
                default:
                    return;
            }
        }
    }
}
