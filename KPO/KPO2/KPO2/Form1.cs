using System.Security.Cryptography;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace KPO2
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


        // List<string> lst

        string N1(string str2)
        {
            char ch = 'w';
            char cv = 'x';
            int indexOfChar = str2.IndexOf(ch);
            int indexOfChar2 = str2.IndexOf(cv);
            if (indexOfChar < indexOfChar2)
            {

                RES.Text = "w ranshe";
            }
            else if (indexOfChar > indexOfChar2)
            {

                RES.Text = "x ranshe"; 
            }
            else
            {
                RES.Text = "net takih bykav";
            }
             str2= RES.Text;
            return str2;
        }
       
        string N2(string str2)
        {
            for(int i=0; i<str2.Length; i++)
            {
                if (i % 2 == 0 && i!=0)
                {
                    if (str2[i-1]=='a' || str2[i-1] == 'b')
                    {
                        str2 = str2.Replace(str2[i - 1],'c') ;
                       
                    }else str2 = str2.Replace(str2[i - 1],'a') ;    
                }
            }
            RES.Text = str2;
            return str2;
        }
        string N3(string str2)
        {
            string[] words =str2.Split  (new char[] { ' ' });
            int indexOfChar = str2.IndexOf(words[1]);
            str2=str2.Substring(0, indexOfChar) + str2.Substring(indexOfChar + words[1].Length);
            return str2;
        }

        string N4(string str2)
        {
       
            string s2 = "abcdifg";
            int result = string.Compare(str2, s2);
            if (result >= 0)
            {
                str2 = "yes";
            }
            else str2 = "ne sdelal k sozhaleniuy";
            return str2;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}