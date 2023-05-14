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

namespace DrzavnaMaturaPetar
{
    public partial class Form2 : Form
    {
        Form1 f1;
        public Form2(Form1 frm1)
        {
            InitializeComponent();
            this.f1 = frm1;
            string skola = f1.comboBox1.Text;
            if (skola.Contains("гимназија")) { comboBox1.Items.Clear(); comboBox1.Items.Add("ОПШТА"); }
            if (skola.Contains("Музичка") || skola.Contains("Балетска") || skola.Contains("арт"))
            {
                comboBox1.Items.Clear(); comboBox1.Items.Add("УМЕТНИЧКА");
            }
            if (!skola.Contains("Музичка") && !skola.Contains("Балетска") && !skola.Contains("арт") && skola.Contains("школа"))
            {
                comboBox1.Items.Clear(); comboBox1.Items.Add("СТРУЧНА");
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string skola = f1.comboBox1.Text;
            string odeljenje = f1.comboBox2.Text;
            if (textBox1.Text != "" && textBox2.Text != "" && comboBox1.Text != "ТИП МАТУРЕ" && comboBox2.Text != "1. предмет" && comboBox3.Text != "2. предмет" && comboBox4.Text != "3. предмет" && comboBox4.Text != "Изаберите област")
            {
                listBox1.Items.Add(string.Format("{0}, 4-{1}, {2}, {3}, {4} матура, {5}, {6}, {7}", skola, odeljenje, textBox1.Text, textBox2.Text, comboBox1.Text, comboBox2.Text, comboBox3.Text, comboBox4.Text));
                StreamWriter writer = new StreamWriter("podaci.txt", true);
                writer.WriteLine(string.Format("{0}, 4-{1}, {2}, {3}, {4} матура, {5}, {6}, {7};", skola, odeljenje, textBox1.Text, textBox2.Text, comboBox1.Text, comboBox2.Text, comboBox3.Text, comboBox4.Text));
                writer.Close();
                if (checkBox1.Checked == false)
                {
                    comboBox2.Text = "1. предмет"; comboBox3.Text = "2. предмет"; comboBox4.Text = "3. предмет"; comboBox5.Text = "Област 3. предмета";
                }
                textBox1.Text = ""; textBox2.Text = "";
            }
            else
            {
                MessageBox.Show("Neki podatak je nepravilno ili nije unesen.", "Unakazices neko dete");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe", "podaci.txt");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show(); 
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "ОПШТА")
            {
                comboBox5.Text = "3. предмет";
                comboBox5.Items.Add("Биологија");
                comboBox5.Items.Add("Географија");
                comboBox5.Items.Add("Енглески језик");
                comboBox5.Items.Add("Историја");
                comboBox5.Items.Add("Италијански језик");
                comboBox5.Items.Add("Немачки језик");
                comboBox5.Items.Add("Руски језик");
                comboBox5.Items.Add("Српски као нематерњи језик");
                comboBox5.Items.Add("Физика");
                comboBox5.Items.Add("Француски језик");
                comboBox5.Items.Add("Хемија");
                comboBox5.Items.Add("Шпански језик");
            }
            if (comboBox1.Text == "СТРУЧНА") comboBox5.Visible = true; else { comboBox5.Visible = false; }
            if (comboBox1.Text == "УМЕТНИЧКА")
            {
                comboBox4.Items.Clear();
                string skola = f1.comboBox1.Text;
                if (skola.Contains("Музичка"))
                {
                    comboBox4.Items.Add("Солфеђо");
                    comboBox4.Items.Add("Хармонија");
                }
                else { comboBox4.Items.Add("Не полаже 3. предмет"); }
            }
            if (comboBox1.Text == "СТРУЧНА")
            {
                comboBox4.Items.Clear(); comboBox5.Text = "Изаберите област";
                comboBox4.Size = new System.Drawing.Size(213, 35);
                comboBox5.Items.Clear();
                comboBox5.Items.Add("ПОЉОПРИВРЕДА, ПРОИЗВОДЊА И ПРЕРАДА ХРАНЕ");
                comboBox5.Items.Add("ШУМАРСТВО И ОБРАДА ДРВЕТА");
                comboBox5.Items.Add("ГЕОЛОГИЈА, РУДАРСТВО И МЕТАЛУРГИЈА");
                comboBox5.Items.Add("МАШИНСТВО И ОБРАДА МЕТАЛА");
                comboBox5.Items.Add("ЕЛЕКТРОТЕХНИКА");
                comboBox5.Items.Add("ТЕКСТИЛСТВО И КОЖАРСТВО");
                comboBox5.Items.Add("ГЕОДЕЗИЈА И ГРАЂЕВИНАРСТВО");
                comboBox5.Items.Add("САОБРАЋАЈ");
                comboBox5.Items.Add("ТРГОВИНА, УГОСТИТЕЉСТВО И ТУРИЗАМ");
                comboBox5.Items.Add("ЕКОНОМИЈА, ПРАВО И АДМИНИСТРАЦИЈА");
                comboBox5.Items.Add("ЗДРАВСТВО И СОЦИЈАЛНА ЗАШТИТА");
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox5.Text == "ПОЉОПРИВРЕДА, ПРОИЗВОДЊА И ПРЕРАДА ХРАНЕ")
            {
                comboBox4.Items.Clear();
                comboBox4.Items.Add("Зоотехничар");
                comboBox4.Items.Add("Техничар за биотехнологију");
                comboBox4.Items.Add("Техничар за биотехнологију");
                comboBox4.Items.Add("Техничар хортикултуре");
            }
            if (comboBox5.Text == "ШУМАРСТВО И ОБРАДА ДРВЕТА")
            {
                comboBox4.Items.Clear();
                comboBox4.Items.Add("Техничар за пејзажну архитектуру");
                comboBox4.Items.Add("Шумарски техничар");
            }
            if (comboBox5.Text == "ГЕОЛОГИЈА, РУДАРСТВО И МЕТАЛУРГИЈА")
            {
                comboBox4.Items.Clear();
                comboBox4.Items.Add("Геолошки техничар за геотехнику и хидрогеологију");
                comboBox4.Items.Add("Геолошки техничар за истраживање минералних сировина");
                comboBox4.Items.Add("Рударски техничар");
                comboBox4.Items.Add("Рударски техничар за припрему минералних сировина");
            }
            if (comboBox5.Text == "МАШИНСТВО И ОБРАДА МЕТАЛА")
            {
                comboBox4.Items.Clear();
                comboBox4.Items.Add("Бродомашински техничар");
                comboBox4.Items.Add("Машински техничар за компјутерско конструисање");
                comboBox4.Items.Add("Машински техничар мерне и регулационе технике");
                comboBox4.Items.Add("Машински техничар моторних возила");
                comboBox4.Items.Add("Техничар грејања и климатизације");
                comboBox4.Items.Add("Техничар за компјутерско управљање (CNC) машина");
                comboBox4.Items.Add("Техничар за роботику");
                comboBox4.Items.Add("Техничар машинске енергетике");
                comboBox4.Items.Add("Техничар оптике");
            }
            if (comboBox5.Text == "ЕЛЕКТРОТЕХНИКА")
            {
                comboBox4.Items.Clear();
                comboBox4.Items.Add("Електротехничар аутоматике");
                comboBox4.Items.Add("Електротехничар електромоторних погона");
                comboBox4.Items.Add("Електротехничар електронике");
                comboBox4.Items.Add("Електротехничар енергетике");
                comboBox4.Items.Add("Електротехничар за термичке и расхладне уређаје");
                comboBox4.Items.Add("Електротехничар информационих технологија");
                comboBox4.Items.Add("Електротехничар рачунара");
                comboBox4.Items.Add("Електротехничар процесног управљања");
            }
            if (comboBox5.Text == "ХЕМИЈА, НЕМЕТАЛИ И ГРАФИЧАРСТВО")
            {
                comboBox4.Items.Clear();
                comboBox4.Items.Add("Техничар графичке дорадее");
                comboBox4.Items.Add("Техничар за заштиту животне средине");
                comboBox4.Items.Add("Техничар за индустријску фармацеутску технологију");
                comboBox4.Items.Add("Техничар штампе");
                comboBox4.Items.Add("Фотограф");
                comboBox4.Items.Add("Хемијски лаборант");
                comboBox4.Items.Add("Хемијско-технолошки техничар");
            }
            if (comboBox5.Text == "ТЕКСТИЛСТВО И КОЖАРСТВО")
            {
                comboBox4.Items.Clear();
                comboBox4.Items.Add("Текстилни техничар");
            }
            if (comboBox5.Text == "ГЕОДЕЗИЈА И ГРАЂЕВИНАРСТВО")
            {
                comboBox4.Items.Clear();
                comboBox4.Items.Add("Грађевински техничар за лабораторијска испитивања");
                comboBox4.Items.Add("Грађевински техничар за хидроградњу");
                comboBox4.Items.Add("Извођач инсталатерских и завршних грађевинских радова");
            }
            if (comboBox5.Text == "САОБРАЋАЈ")
            {
                comboBox4.Items.Clear();
                comboBox4.Items.Add("Наутички техничар – речни смер");
                comboBox4.Items.Add("Саобраћајно-транспортни техничар");
                comboBox4.Items.Add("Техничар вуче");
                comboBox4.Items.Add("Техничар ПТТ саобраћаја");
                comboBox4.Items.Add("Техничар унутрашњег транспорта");
                comboBox4.Items.Add("Транспортни комерцијалиста");
            }
            if (comboBox5.Text == "ТРГОВИНА, УГОСТИТЕЉСТВО И ТУРИЗАМ")
            {
                comboBox4.Items.Clear();
                comboBox4.Items.Add("Аранжер у трговини");
                comboBox4.Items.Add("Трговински техничар");
                comboBox4.Items.Add("Кулинарски техничар");
                comboBox4.Items.Add("Угоститељски техничар");
            }
            if (comboBox5.Text == "ЕКОНОМИЈА, ПРАВО И АДМИНИСТРАЦИЈА")
            {
                comboBox4.Items.Clear();
                comboBox4.Items.Add("Економски техничар");
                comboBox4.Items.Add("Финансијски техничар");
                comboBox4.Items.Add("Царински техничар");
            }
            if (comboBox5.Text == "ТРГОВИНА, УГОСТИТЕЉСТВО И ТУРИЗАМ")
            {
                comboBox4.Items.Clear();
                comboBox4.Items.Add("Гинеколошко-акушерска сестра");
                comboBox4.Items.Add("Зубни техничар");
                comboBox4.Items.Add("Медицинска сестра – васпитач");
                comboBox4.Items.Add("Педијатријска сестра – техничар");
                comboBox4.Items.Add("Санитарно-еколошки техничар");
            }
            if (comboBox5.Text == "ЛИЧНЕ УСЛУГЕ")
            {
                comboBox4.Items.Clear();
                comboBox4.Items.Add("ТСценски маскер и власуљар");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
