using System.Security.Cryptography;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;
namespace KPO2YANA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += button1_Click;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string str = "";
            str = textBox1.Text;
            RES.Text = N4(str);
        }
        string N1(string str2)
        {
            int count = 0,anothercount=0,anotheranothercount=0;
            for (int i=0; i < str2.Length; i++)
            {
                if (str2[i] == '+')
                {
                    count++;
                }
                if (str2[i] == '-')
                {
                    anothercount++;
                }
                

            }
            for (int i = 0; i < str2.Length-1; i++)
            {
                if (str2[i + 1] == '0')
                {
                    anotheranothercount++;
                }
            }
            RES.Text +=Convert.ToString(count);
            RES.Text +=Convert.ToString(anothercount);
            RES.Text += Convert.ToString(anotheranothercount);

            str2 = RES.Text;
            return str2;
        }

        string N2(string str2)
        {

                Random r = new Random();
                for (int i = 3; i < str2.Length; i += 4)
                {
                    str2.Insert(i, " ");
                }   
                for (int i = 1; i < str2.Length; i += 4)
                {
                    do
                    {
                    str2[i] = (char)(r.Next(1073,1104));
                    }
                    while (str2[i] == str2[i - 1] || str2[i] == str2[i + 1]);
                }
                return str2;
        }
        string N3(string str2)
        {
            string s = "";
            Random r = new Random();
            for (int i = 0; i < 5; i++)
                s += (char)(r.Next(1073, 1104));
            str2 += s + "@gmail.com";
            return str2;
        }

        string N4(string str2)
        {
            int count = 0;
            for(int i = 0; i < str2.Length; i++)
            {
                 if (str2[i] == '(')
                 {
                    count++;
                 }
                 if (str2[i] == ')')
                 {
                    count++;
                 }
                if (str2[i] == '{')
                {
                    count++;
                }
                if (str2[i] == '}')
                {
                    count++;
                }
                if (str2[i] == '[')
                {
                    count++;
                }
                if (str2[i] == ']')
                {
                    count++;
                }
            }
            if (count % 2 == 0)
            {
                RES.Text = "vse scobki zakriti";
            }
            else RES.Text = "-1";
            str2 = RES.Text;
            return str2;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }









    }
}