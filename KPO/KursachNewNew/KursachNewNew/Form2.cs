using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursachNewNew
{
    public partial class Form2 : Form
    {
        string path = @"D:\GIT-Repository\SecondCoure\KPO\KursachNewNew\FilesForKursach\Name.txt";
        string pathscore = @"D:\GIT-Repository\SecondCoure\KPO\KursachNewNew\FilesForKursach\Score.txt";
        
        public Form2(string score)
        {
            InitializeComponent();
           
            string name = File.ReadAllText(path); 
            ShowName.Text += name ;
            string scr = score.ToString()+"\n" ;
            File.AppendAllText(pathscore, scr);
            string str1 = File.ReadAllText(pathscore);
            ShowScore.Text += str1;
            InputName.Visible = true;
        }
       
        
        public void button1_Click(object sender, EventArgs e)
        {
            ShowName.Text = " ";
            string name = InputName.Text+"\n";
            File.AppendAllText(path, name);
            string str = File.ReadAllText(path);
            ShowName.Text += str ;
            InputName.Text = "";
            InputName.Visible = false;
            
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

       
    }
}
