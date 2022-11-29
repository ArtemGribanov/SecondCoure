string path = @"D:\GIT-Repository\SecondCoure\ACTOS\OS\source.txt";

string str = "";
//str = File.ReadAllText(path);

double S;
S = Convert.ToDouble(args[0]);
//S = Convert.ToDouble(str);

File.Delete(path);

//S = double.Parse(Console.Read
//Line());

S = Math.Pow(S, 3);

string res = Convert.ToString(S);
File.WriteAllText(path, res);
//Console.WriteLine(S);


