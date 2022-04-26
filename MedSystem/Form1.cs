using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedSystem
{
    public partial class Form1 : Form
    {
        System.Object[] ItemObject = new System.Object[10];

        public Form1()
        {
            InitializeComponent();

        }

        int ball = 0;

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Мужской")
            {
                comboBox4.Items.Clear();
                comboBox4.Items.Insert(0, "95-105");
                comboBox4.Items.Insert(1, "106-116");
                comboBox4.Items.Insert(2, "117-126");
                comboBox4.Items.Insert(3, "127-137");
                comboBox4.Items.Insert(4, "138-148");
                comboBox4.Items.Insert(5, "149-159");
                comboBox4.Items.Insert(6, "160-170");
                comboBox4.Items.Insert(7, "171-181");
                comboBox4.Items.Insert(8, "182-191");
                comboBox4.Items.Insert(9, "192-202");
                comboBox4.Items.Insert(10, "203-213");
            }
            if (comboBox2.Text == "Женский")
            {
                comboBox4.Items.Clear();
                comboBox4.Items.Insert(0, "95-104");
                comboBox4.Items.Insert(1, "105-114");
                comboBox4.Items.Insert(2, "115-124");
                comboBox4.Items.Insert(3, "125-134");
                comboBox4.Items.Insert(4, "135-144");
                comboBox4.Items.Insert(5, "145-154");
                comboBox4.Items.Insert(6, "155-164");
                comboBox4.Items.Insert(7, "165-174");
                comboBox4.Items.Insert(8, "175-184");
                comboBox4.Items.Insert(9, "185-194");
                comboBox4.Items.Insert(10, "195-204");
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Возраст
            if (comboBox1.Text == "57-59")
                ball += 1;
            else if (comboBox1.Text == "60-62")
                ball += 2;
            else if (comboBox1.Text == "63-65")
                ball += 3;
            else if (comboBox1.Text == "66-68")
                ball += 4;
            else if (comboBox1.Text == "69-71")
                ball += 5;
            else if (comboBox1.Text == "72-74")
                ball += 6;
            else if (comboBox1.Text == "75-77")
                ball += 7;
            else if (comboBox1.Text == "78-80")
                ball += 8;
            else if (comboBox1.Text == "81-83")
                ball += 9;
            else if (comboBox1.Text == "84-86")
                ball += 10;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Холестерин
            if (comboBox3.Text == "<0,9" && comboBox2.Text == "Мужской")
                ball += 3;
            else if (comboBox3.Text == "<0,9" && comboBox2.Text == "Женский")
                ball += 5;
            else if (comboBox3.Text == "0,9-1,6" && comboBox2.Text == "Мужской")
                ball += 2;
            else if (comboBox3.Text == "0,9-1,6" && comboBox2.Text == "Женский")
                ball += 2;
            else if (comboBox3.Text == "1,17-1,29" && comboBox2.Text == "Мужской")
                ball += 1;
            else if (comboBox3.Text == ">1,56" && comboBox2.Text == "Женский")
                ball -= 2;
            else if (comboBox3.Text == ">1,56" && comboBox2.Text == "Мужской")
                ball -= 3;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Систолическое АД мужчины
            if (comboBox4.Text == "106-116")
                ball += 1;
            else if (comboBox4.Text == "117-126")
                ball += 2;
            else if (comboBox4.Text == "127-137")
                ball += 3;
            else if (comboBox4.Text == "138-148")
                ball += 4;
            else if (comboBox4.Text == "149-159")
                ball += 5;
            else if (comboBox4.Text == "160-170")
                ball += 6;
            else if (comboBox4.Text == "171-181")
                ball += 7;
            else if (comboBox4.Text == "182-191")
                ball += 8;
            else if (comboBox4.Text == "192-202")
                ball += 9;
            else if (comboBox4.Text == "203-213")
                ball += 10;

            //Систолическое АД женщины
            if (comboBox4.Text == "105-114")
                ball += 1;
            else if (comboBox4.Text == "115-124")
                ball += 2;
            else if (comboBox4.Text == "125-134")
                ball += 3;
            else if (comboBox4.Text == "135-144")
                ball += 4;
            else if (comboBox4.Text == "145-154")
                ball += 5;
            else if (comboBox4.Text == "155-164")
                ball += 6;
            else if (comboBox4.Text == "165-174")
                ball += 7;
            else if (comboBox4.Text == "175-184")
                ball += 8;
            else if (comboBox4.Text == "185-194")
                ball += 9;
            else if (comboBox4.Text == "195-204")
                ball += 10;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //Сахарный диабет
            if (checkBox1.Checked == true && comboBox2.Text == "Мужской")
                ball += 2;
            else if (checkBox1.Checked == true && comboBox2.Text == "Женский")
                ball += 3;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            //Курение
            if (checkBox2.Checked == true && comboBox2.Text == "Мужской")
                ball += 3;
            else if (checkBox2.Checked == true && comboBox2.Text == "Женский")
                ball += 3;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            //Атеросклеротическое заболевание
            if (checkBox3.Checked == true && comboBox2.Text == "Мужской")
                ball += 3;
            else if (checkBox3.Checked == true && comboBox2.Text == "Женский")
                ball += 2;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            //Гипертрофия левого желудочка
            if (checkBox4.Checked == true && comboBox2.Text == "Мужской")
                ball += 6;
            else if (checkBox4.Checked == true && comboBox2.Text == "Женский")
                ball += 4;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (ball <= 10 && comboBox2.Text == "Мужской")
            {
                label4.ForeColor = Color.Green;
                label4.Text = "низкий - менее 10%";
            }

            else if (ball >= 10 && ball <= 14 && comboBox2.Text == "Мужской")
            {
                label4.ForeColor = Color.Yellow;
                label4.Text = "промежуточный - 10-15%";
            }

            else if (ball >= 13 && ball <= 15 && comboBox2.Text == "Мужской")
            {
                label4.ForeColor = Color.Orange;
                label4.Text = "высокий - 16-20%";
            }

            else if (ball >= 16 && ball <= 100 && comboBox2.Text == "Мужской")
            {
                label4.ForeColor = Color.Red;
                label4.Text = "очень высокий - более 20%";
            }

            //Женский
             else if (ball <= 12 && comboBox2.Text == "Женский")
            {
                label4.ForeColor = Color.Green;
                label4.Text = "низкий - менее 10%";
            }

            else if (ball >= 13 && ball <= 14 && comboBox2.Text == "Женский")
            {
                label4.ForeColor = Color.Yellow;
                label4.Text = "промежуточный - 10-15%";
            }

            else if (ball >= 15 && ball <= 16 && comboBox2.Text == "Женский")
            {
                label4.ForeColor = Color.Orange;
                label4.Text = "высокий - 16-20%";
            }

            else if (ball >= 17 && ball <= 100 && comboBox2.Text == "Женский")
            {
                label4.ForeColor = Color.Red;
                label4.Text = "очень высокий - более 20%";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
