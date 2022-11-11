using System.Runtime.ExceptionServices;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;
namespace KPO3
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            button1.Click += button1_Click;
        }

        string str2= " ";
        private void button1_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(comboBox2.SelectedItem);
            label1.Text = " ";
            str2 = " ";
            switch (comboBox1.SelectedItem)
            {
                case "ввести имя":
                    TABL[number] = AddName(TABL[number], Input.Text);
                    break;
                case "ввести должность":
                    TABL[number] = AddPos(TABL[number], Input.Text);
                    break;
                case "ввести год поступления на работу":
                    TABL[number] = AddYear(TABL[number], Input.Text);
                    break;
                case "вывести":
                    str2 += TABL[number].name + " | " + TABL[number].pos + " | " + TABL[number].year + " | ";
                    break;
                case "вывести все":
                    str2 += TABL[0].name + " | " + TABL[0].pos + " | " + TABL[0].year  +"\n";
                    str2 += TABL[1].name + " | " + TABL[1].pos + " | " + TABL[1].year  + "\n";
                    str2 += TABL[2].name + " | " + TABL[2].pos + " | " + TABL[2].year  + "\n";
                    str2 += TABL[3].name + " | " + TABL[3].pos + " | " + TABL[3].year  + "\n";
                    str2 += TABL[4].name + " | " + TABL[4].pos + " | " + TABL[4].year  + "\n";
                    str2 += TABL[5].name + " | " + TABL[5].pos + " | " + TABL[5].year  + "\n";
                    str2 += TABL[6].name + " | " + TABL[6].pos + " | " + TABL[6].year  + "\n";
                    str2 += TABL[7].name + " | " + TABL[7].pos + " | " + TABL[7].year  + "\n";
                    str2 += TABL[8].name + " | " + TABL[8].pos + " | " + TABL[8].year  + "\n";
                    str2 += TABL[9].name + " | " + TABL[9].pos + " | " + TABL[9].year + "\n";
                    break;
                case "найти по стажу работы":
                    int c = 0;
                    for (int i=0;i<10;i++) 
                    {
                        if (TABL[i].year > Convert.ToInt32(Input.Text))
                        {
                            str2 += TABL[i].name + "\n";
                            c++;
                        }
                    }
                    if (c == 0)
                    {
                        str2 += "нет людей с таким стажем";
                    }
                    break;
            }
            label1.Text=str2;
        }

        worker[] TABL = new worker[10];
      
        worker AddName(worker worker, string str)
        {
            worker.name = str;
            return worker;
        }

        worker AddPos(worker worker, string str)
        {
            worker.pos = str;
            return worker;
        }

        worker AddYear(worker worker, string str)
        {
            
            worker.year = Convert.ToInt32(str);
            return worker;
        }
    }
}
      