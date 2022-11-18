using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IZ3_4
{
    public partial class Form1 : Form
    {

        int i1 = -1;
        int i2 = -1;
        int i3 = -1;
        int i4 = -1;


        int q = 1;
        string[] arr;
        string[] arr2;
        public Form1()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            start.Visible = false;
            checkedListBox1.Visible = true;
            label1.Visible = true;
            choiced.Visible = true;
            label1.Text = "Амплуа (позиция) игрока?";
            string[] arr = {"Связующий", "Либеро", "Доигровщик", "Блокирующий", "Диагональный"}; 
            checkedListBox1.Items.AddRange(arr);
            
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (q)
            {
                case 1:
                    i1 = checkedListBox1.SelectedIndex;
                    q++;
                    break;
                case 2:
                    i2 = checkedListBox1.SelectedIndex;
                    q++;
                    break;
                case 3:
                    i3 = checkedListBox1.SelectedIndex;
                    q++;
                    break;
                case 4:
                    i4 = checkedListBox1.SelectedIndex;
                    q++;
                    break;
            }
                
            switch (i1)
            {
                case 0: 
                    label1.Text = "Рост связующего?";
                    string[] arr2 = { "190+", "180-190" };
                    checkedListBox1.Items.Clear();
                    checkedListBox1.Items.AddRange(arr2);

                    switch (i2)
                    {
                        case 0: 
                            label1.Text = "Связующий должен уметь пасовать взлет?";
                            arr2 = new string[2] { "да", "нет" };
                            checkedListBox1.Items.Clear();
                            checkedListBox1.Items.AddRange(arr2);

                            switch (i3)
                            {
                                case 0: 
                                    label1.Text = "Связующий должен иметь опыть игры в чемпионатах мира?";
                                    arr2 = new string[2] { "да", "нет" };
                                    checkedListBox1.Items.Clear();
                                    checkedListBox1.Items.AddRange(arr2);
                                    switch (i4)
                                    {
                                        case 0: 
                                            label1.Text = "Никола Грбич";
                                            checkedListBox1.Visible = false;
                                            pictureBox2.Visible = true;
                                            pictureBox2.Image = Image.FromFile("C:\\Users\\1234\\Desktop\\скрины\\грбич.png");
                                            break;
                                             
                                        case 1: 
                                            label1.Text = "Павел Загумный";
                                            checkedListBox1.Visible = false;
                                            pictureBox2.Visible = true;
                                            pictureBox2.Image = Image.FromFile("C:\\Users\\1234\\Desktop\\скрины\\загумный.png");
                                            break;
                                    }
                                    break;

                                case 1: 
                                    label1.Text = "Связующий должен иметь опыть игры в чемпионатах мира?";
                                    arr2 = new string[2] { "да", "нет" };
                                    checkedListBox1.Items.Clear();
                                    checkedListBox1.Items.AddRange(arr2);
                                    switch (i4)
                                    {
                                        case 0:
                                            label1.Text = "Вадим Хамутцких";
                                            checkedListBox1.Visible = false;
                                            pictureBox2.Visible = true;
                                            pictureBox2.Image = Image.FromFile("C:\\Users\\1234\\Desktop\\скрины\\хамутцких.png");
                                            break;

                                        case 1:
                                            label1.Text = "Сергей Гранкин";
                                            checkedListBox1.Visible = false;
                                            pictureBox2.Visible = true;
                                            pictureBox2.Image = Image.FromFile("C:\\Users\\1234\\Desktop\\скрины\\гранкин.png");
                                            break;

                                    }

                                    break;

                            }
                        break;

                        case 1: 
                            label1.Text = "У связующего должен быть высокий прыжок?";
                            arr2 = new string[2] { "да", "нет" };
                            checkedListBox1.Items.Clear();
                            checkedListBox1.Items.AddRange(arr2);
                            switch (i3)
                            {
                                case 0: 
                                    label1.Text = "Высота прыжка?";
                                    arr2 = new string[2] { "90+", "80-90" };
                                    checkedListBox1.Items.Clear();
                                    checkedListBox1.Items.AddRange(arr2);
                                    switch (i4)
                                    {
                                        case 0: 
                                            label1.Text = "Александр Щербаков";
                                            checkedListBox1.Visible = false;
                                            pictureBox2.Visible = true;
                                            pictureBox2.Image = Image.FromFile("C:\\Users\\1234\\Desktop\\скрины\\а. щербаков.png");
                                            break;

                                        case 1: 
                                            label1.Text = "Александр Бутько";
                                            checkedListBox1.Visible = false;
                                            pictureBox2.Visible = true;
                                            pictureBox2.Image = Image.FromFile("C:\\Users\\1234\\Desktop\\скрины\\бутько.png");
                                            break;
                                    }
                                    break;

                                case 1: 
                                    label1.Text = "Связующий должен уметь пасовать взлет?";
                                    arr2 = new string[2] { "да", "нет" };
                                    checkedListBox1.Items.Clear();
                                    checkedListBox1.Items.AddRange(arr2);
                                    switch (i4)
                                    {
                                        case 0:
                                            label1.Text = "Ллой Болл";
                                            checkedListBox1.Visible = false;
                                            pictureBox2.Visible = true;
                                            pictureBox2.Image = Image.FromFile("C:\\Users\\1234\\Desktop\\скрины\\болл.png");
                                            break;

                                        case 1:
                                            label1.Text = "Симоне Джанелли";
                                            checkedListBox1.Visible = false;
                                            pictureBox2.Visible = true;
                                            pictureBox2.Image = Image.FromFile("C:\\Users\\1234\\Desktop\\скрины\\джанелли.png");
                                            break;
                                    }
                                    break;
                            }
                            break;
                    }
                
                    break;

                case 1: 
                    label1.Text = "Рост либеро?";
                    arr2 = new string[2] { "180+", "170-180" };
                    checkedListBox1.Items.Clear();
                    checkedListBox1.Items.AddRange(arr2);

                    switch (i2)
                    {
                        case 0: 
                            label1.Text = "Либеро должен уметь пасовать с задней линии??";
                            arr2 = new string[2] { "да", "нет" };
                            checkedListBox1.Items.Clear();
                            checkedListBox1.Items.AddRange(arr2);

                            switch (i3)
                            {
                                case 0: 
                                    label1.Text = "Артем Ермаков";
                                    checkedListBox1.Visible = false;
                                    pictureBox2.Visible = true;
                                    pictureBox2.Image = Image.FromFile("C:\\Users\\1234\\Desktop\\скрины\\ермаков.png");
                                    break;

                                case 1: 
                                    label1.Text = "Сергей Мелкозеров";
                                    checkedListBox1.Visible = false;
                                    pictureBox2.Visible = true;
                                    pictureBox2.Image = Image.FromFile("C:\\Users\\1234\\Desktop\\скрины\\мелкозеров.png");
                                    break;

                            }
                            break;

                        case 1: 
                            label1.Text = "Либеро должен уметь подавать с прыжка?";
                            arr2 = new string[2] { "да", "нет" };
                            checkedListBox1.Items.Clear();
                            checkedListBox1.Items.AddRange(arr2);
                            switch (i3)
                            {
                                case 0: 
                                    label1.Text = "Владимир Шишкин";
                                    pictureBox2.Visible = true;
                                    pictureBox2.Image = Image.FromFile("C:\\Users\\1234\\Desktop\\скрины\\шишкин.png");
                                    checkedListBox1.Visible = false;
                                    break;

                                case 1: 
                                    label1.Text = "Евгений Андреев";
                                    checkedListBox1.Visible = false;
                                    pictureBox2.Visible = true;
                                    pictureBox2.Image = Image.FromFile("C:\\Users\\1234\\Desktop\\скрины\\андреев.png");
                                    break;
                            }
                            break;
                    }
                    break;


                case 2: 
                    label1.Text = "Рост доигровщика?";
                    arr2 = new string[2] { "195+", "185-195" };
                    checkedListBox1.Items.Clear();
                    checkedListBox1.Items.AddRange(arr2);

                    switch (i2)
                    {
                        case 0:
                            label1.Text = "Доигровщик должен владеть хорошим приемом?";
                            arr2 = new string[2] { "да", "нет" };
                            checkedListBox1.Items.Clear();
                            checkedListBox1.Items.AddRange(arr2);

                            switch (i3)
                            {
                                case 0:
                                    label1.Text = "Высота прыжка?";
                                    arr2 = new string[2] { "90+", "80-90" };
                                    checkedListBox1.Items.Clear();
                                    checkedListBox1.Items.AddRange(arr2);
                                    switch (i4)
                                    {
                                        case 0: 
                                            label1.Text = "Евгений Сивожелез";
                                            pictureBox2.Visible = true;
                                            pictureBox2.Image = Image.FromFile("C:\\Users\\1234\\Desktop\\скрины\\сивожелез.png");
                                            checkedListBox1.Visible = false;
                                            break;

                                        case 1: 
                                            label1.Text = "Иван Зайцев";
                                            checkedListBox1.Visible = false;
                                            pictureBox2.Visible = true;
                                            pictureBox2.Image = Image.FromFile("C:\\Users\\1234\\Desktop\\скрины\\зайцев.png");
                                            break;
                                    }
                                    break;

                                case 1: 
                                    label1.Text = "Доигровщик должен уметь подавать силовую подачу? ";
                                    arr2 = new string[2] { "да", "нет" };
                                    checkedListBox1.Items.Clear();
                                    checkedListBox1.Items.AddRange(arr2);
                                    switch (i4)
                                    {
                                        case 0:
                                            label1.Text = "Дмитрий Волков";
                                            checkedListBox1.Visible = false;
                                            pictureBox2.Visible = true;
                                            pictureBox2.Image = Image.FromFile("C:\\Users\\1234\\Desktop\\скрины\\волков.png");
                                            break;

                                        case 1:
                                            label1.Text = "Егор Клюка";
                                            checkedListBox1.Visible = false;
                                            pictureBox2.Visible = true;
                                            pictureBox2.Image = Image.FromFile("C:\\Users\\1234\\Desktop\\скрины\\клюка.png");
                                            break;
                                    }
                                    break;
                            }
                            break;

                        case 1: 
                            label1.Text = "Доигровщик должен уметь атаковать из аута?";
                            arr2 = new string[2] { "да", "нет" };
                            checkedListBox1.Items.Clear();
                            checkedListBox1.Items.AddRange(arr2);
                            switch (i3)
                            {
                                case 0: 
                                    label1.Text = "Ярослав Подлесных";
                                    pictureBox2.Visible = true;
                                    pictureBox2.Image = Image.FromFile("C:\\Users\\1234\\Desktop\\скрины\\подлесных.png");
                                    checkedListBox1.Visible = false;
                                    break;

                                case 1: 
                                    label1.Text = "Алексей Родичев";
                                    checkedListBox1.Visible = false;
                                    pictureBox2.Visible = true;
                                    pictureBox2.Image = Image.FromFile("C:\\Users\\1234\\Desktop\\скрины\\родичев.png");
                                    break;
                            }
                            break;
                    }
                    break;

                case 3: 
                    label1.Text = "Рост блокирующего?";
                    arr2 = new string[2] { "200+", "190-200" };
                    checkedListBox1.Items.Clear();
                    checkedListBox1.Items.AddRange(arr2);

                    switch (i2)
                    {
                        case 0: 
                            label1.Text = "Блокирующий должен уметь хорошо бить 1-ый темп?";
                            arr2 = new string[2] { "да", "нет" };
                            checkedListBox1.Items.Clear();
                            checkedListBox1.Items.AddRange(arr2);

                            switch (i3)
                            {
                                case 0: 
                                    label1.Text = "Руслан Ханилов";
                                    checkedListBox1.Visible = false;
                                    pictureBox2.Visible = true;
                                    pictureBox2.Image = Image.FromFile("C:\\Users\\1234\\Desktop\\скрины\\ханилов.png");
                                    break;

                                case 1: 
                                    label1.Text = "Алексей Самойленко";
                                    checkedListBox1.Visible = false;
                                    pictureBox2.Visible = true;
                                    pictureBox2.Image = Image.FromFile("C:\\Users\\1234\\Desktop\\скрины\\самойленко.png");
                                    break;

                            }
                            break;

                        case 1: 
                            label1.Text = "У блокирующего должен быть высокий прыжок?";
                            arr2 = new string[2] { "да", "нет" };
                            checkedListBox1.Items.Clear();
                            checkedListBox1.Items.AddRange(arr2);
                            switch (i3)
                            {
                                case 0: 
                                    label1.Text = "Высота прыжка?";
                                    arr2 = new string[2] { "90+", "80-90" };
                                    checkedListBox1.Items.Clear();
                                    checkedListBox1.Items.AddRange(arr2);
                                    switch (i4)
                                    {
                                        case 0: 
                                            label1.Text = "Михаил Щербаков";
                                            checkedListBox1.Visible = false;
                                            pictureBox2.Visible = true;
                                            pictureBox2.Image = Image.FromFile("C:\\Users\\1234\\Desktop\\скрины\\м. Щербаков.png");
                                            break;

                                        case 1: 
                                            label1.Text = "Алексей Сафонов";
                                            checkedListBox1.Visible = false;
                                            pictureBox2.Visible = true;
                                            pictureBox2.Image = Image.FromFile("C:\\Users\\1234\\Desktop\\скрины\\сафонов.png");
                                            break;
                                    }
                                    break;

                                case 1: 
                                    label1.Text = "Блокирующий должен уметь обыгрывать блок?";
                                    arr2 = new string[2] { "да", "нет" };
                                    checkedListBox1.Items.Clear();
                                    checkedListBox1.Items.AddRange(arr2);
                                    switch (i4)
                                    {
                                        case 0:
                                            label1.Text = "Илья Власов";
                                            checkedListBox1.Visible = false;
                                            pictureBox2.Visible = true;
                                            pictureBox2.Image = Image.FromFile("C:\\Users\\1234\\Desktop\\скрины\\власов.png");
                                            break;

                                        case 1:
                                            label1.Text = "Артем Смоляр";
                                            checkedListBox1.Visible = false;
                                            pictureBox2.Visible = true;
                                            pictureBox2.Image = Image.FromFile("C:\\Users\\1234\\Desktop\\скрины\\смоляр.png");
                                            break;
                                    }
                                    break;
                            }
                            break;
                    }
                    break;


                case 4: 
                    label1.Text = "Рост диагонального?";
                    arr2 = new string[2] { "190+", "180-190" };
                    checkedListBox1.Items.Clear();
                    checkedListBox1.Items.AddRange(arr2);

                    switch (i2)
                    {
                        case 0: 
                            label1.Text = "Диагональный должен умеит подавать подачу-планер?";
                            arr2 = new string[2] { "да", "нет" };
                            checkedListBox1.Items.Clear();
                            checkedListBox1.Items.AddRange(arr2);

                            switch (i3)
                            {
                                case 0: 
                                    label1.Text = "Андрей Ащев";
                                    checkedListBox1.Visible = false;
                                    pictureBox2.Visible = true;
                                    pictureBox2.Image = Image.FromFile("C:\\Users\\1234\\Desktop\\скрины\\ащев.png");
                                    break;

                                case 1: 
                                    label1.Text = "Дмитрий Щербинин";
                                    checkedListBox1.Visible = false;
                                    pictureBox2.Visible = true;
                                    pictureBox2.Image = Image.FromFile("C:\\Users\\1234\\Desktop\\скрины\\щербинин.png");
                                    break;

                            }
                            break;

                        case 1: 
                            label1.Text = "У диагонального должен быть высокий прыжок?";
                            arr2 = new string[2] { "да", "нет" };
                            checkedListBox1.Items.Clear();
                            checkedListBox1.Items.AddRange(arr2);
                            switch (i3)
                            {
                                case 0: 
                                    label1.Text = "Высота прыжка?";
                                    arr2 = new string[2] { "90+", "80-90" };
                                    checkedListBox1.Items.Clear();
                                    checkedListBox1.Items.AddRange(arr2);
                                    switch (i4)
                                    {
                                        case 0:
                                            label1.Text = "Сергей Савин";
                                            checkedListBox1.Visible = false;
                                            pictureBox2.Visible = true;
                                            pictureBox2.Image = Image.FromFile("C:\\Users\\1234\\Desktop\\скрины\\савин.png");
                                            break;

                                        case 1: 
                                            label1.Text = "Максим Михайлов";
                                            checkedListBox1.Visible = false;
                                            pictureBox2.Visible = true;
                                            pictureBox2.Image = Image.FromFile("C:\\Users\\1234\\Desktop\\скрины\\михайлов.png");
                                            break;
                                    }
                                    break;

                                case 1: // прыжок нет
                                    label1.Text = "Дигональный должен уметь участвовать в приеме?";
                                    arr2 = new string[2] { "да", "нет" };
                                    checkedListBox1.Items.Clear();
                                    checkedListBox1.Items.AddRange(arr2);
                                    switch (i4)
                                    {
                                        case 0:
                                            label1.Text = "Маркус Нильсон";
                                            checkedListBox1.Visible = false;
                                            pictureBox2.Visible = true;
                                            pictureBox2.Image = Image.FromFile("C:\\Users\\1234\\Desktop\\скрины\\нильсон.png");
                                            break;

                                        case 1:
                                            label1.Text = "Сергей Тютлин";
                                            checkedListBox1.Visible = false;
                                            pictureBox2.Visible = true;
                                            pictureBox2.Image = Image.FromFile("C:\\Users\\1234\\Desktop\\скрины\\тютлин.png");
                                            break;
                                    }
                                    break;
                            }
                            break;
                    }
                    break;
            }   
        }

        private void choiced_Click(object sender, EventArgs e)
        {
            i1 = -1;
            i2 = -1;
            i3 = -1;
            i4 = -1;
            q = 1;
            start.Visible = false;
            checkedListBox1.Visible = true;
            label1.Visible = true;
            choiced.Visible = true;
            label1.Text = "Амплуа (позиция) игрока?";
            string[] arr = { "Связующий", "Либеро", "Доигровщик", "Блокирующий", "Диагональный" };
            checkedListBox1.Items.Clear();
            checkedListBox1.Items.AddRange(arr);
            pictureBox2.Visible = false;
        }
    }
}
