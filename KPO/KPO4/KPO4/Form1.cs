namespace KPO4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
            label1.Text = "Vveddite pyth k faily";
            button1.Click += Button1_Click;
        }

        private void Button1_Click(object? sender, EventArgs e)
        {
            label2.Text = " ";
            string path = Path.Text;
            switch (comboBox1.SelectedItem) 
            {
                case "1":
                    Z1(path);
                    break;
                case "2":
                    Z2(path);
                    break;

            }
        }
        void Z1(string path) 
        {
            
            string[] str = File.ReadAllLines(path);
            string result = "";
            int[] a;
            bool perem = true;
            for (int i = 0; i < str.Length; i++)
            {
                a = str[i].Split(' ').Select(Int32.Parse).ToArray();
                for (int j = 0; j < a.Length; j++)
                {
                    for (int n = 0; n < a.Length - 1; n++)
                    {
                        if (a[n] > a[n + 1])
                        {
                            int tem = a[n];
                            a[n] = a[n + 1];
                            a[n + 1] = tem;
                        }
                    }
                }
                for (int check = 0; check < a.Length - 2; check++)
                {
                    if (a[check] - a[check + 1] == a[check + 1] - a[check + 2]) { }
                    else perem = false;
                }
                if (perem)
                {
                    for (int b = 0; b < a.Length; b++)
                    {
                        result += a[b] + " ";
                    }
                    result += "\n";
                }
                perem = true;
            }
            string path2 = path.Substring(0, path.Length - 4);
            path2 += "2.txt";
            File.AppendAllText(path2, result);
            label2.Text = result;

        }
        void Z2(string path)
        {
            string[] str = File.ReadAllLines(path);
            int index;
            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i][0] == 'Ê' || str[i][0] == 'Ñ')
                {
                    index = str[i].IndexOf(' ') + 1;
                    result += str[i].Substring(index);
                    result += "\n";
                }
            }
            string path2 = path.Substring(0, path.Length - 4);
            path2 += "2.txt";
            File.AppendAllText(path2, result);
            label2.Text = result;
        }

      
    }
}