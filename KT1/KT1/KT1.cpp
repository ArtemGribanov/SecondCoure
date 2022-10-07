#include <iostream>
#include <string>
using namespace std;
int main()
{
    setlocale(LC_ALL, "Russian");
    int pos = 0, n, a = 0, j, c = 0, b = 0;
    string s, mas[100];
    getline(cin, s);
    n = s.length();
    for (int i = 0; i < n; i++)
    {
        if (i == s.find("for", pos))
        {
            if (mas[a].empty() == false)
            {
                a++;
            }
            mas[a] += "Ключевое слово: for";
            pos = i;
            i++;
            a++;

        }
        else
            if (i == s.find("do", pos))
            {
                if (mas[a].empty() == false)
                {
                    a++;
                }
                mas[a] += "Ключевое слово: do";
                pos = i;
                i += 3;
                a++;
            }
            else
                if (i == s.find("then", pos))
                {
                    if (mas[a].empty() == false)
                    {
                        a++;
                    }
                    mas[a] += "Ключевое слово: then";
                    pos = i;
                    i += 3;
                    a++;
                }
                else

                    if (i == s.find(";", pos))
                    {
                        if (mas[a].empty() == false)
                        {
                            a++;
                        }
                        mas[a] += "Разделительный знак: ;";
                        pos = i;
                        a++;
                    }
                    else

                        if (i == s.find("<", pos))
                        {
                            if (mas[a].empty() == false)
                            {
                                a++;
                            }
                            mas[a] += "Знак сравнения: <";
                            pos = i;
                            a++;
                        }
                        else
                            if (i == s.find(">", pos))
                            {
                                if (mas[a].empty() == false)
                                {
                                    a++;
                                }
                                mas[a] += "Знак сравнения: >";
                                pos = i;
                                a++;
                            }
                            else
                                if (i == s.find("=", pos))
                                {
                                    if (mas[a].empty() == false)
                                    {
                                        a++;
                                    }
                                    mas[a] += "Знак сравнения: =";
                                    pos = i;
                                    a++;
                                }
                                else

                                    if (i == s.find(":=", pos))
                                    {
                                        if (mas[a].empty() == false)
                                        {
                                            a++;
                                        }
                                        mas[a] += "Знак присваивания: :=";
                                        pos = i;
                                        i += 1;
                                        a++;
                                    }
                                    else
                                        if (s[i] >= '0' && s[i] <= '9')
                                        {
                                            if (mas[a].empty() == false)
                                            {
                                                a++;
                                            }
                                            c = 0;
                                            char m[100] = "";
                                            j = i;
                                            while (s[j] >= '0' && s[j] <= '9')
                                            {
                                                m[b] = s[j];
                                                b++;
                                                j++;
                                                if (s[j] == '.')
                                                {
                                                    c++;
                                                    m[b] = s[j];
                                                    b++;
                                                    j++;
                                                }
                                                if (s[j] == 'E' && s[j + 1] == '+' && s[j + 2] >= '0' && s[j + 2] <= '9')
                                                {
                                                    c++;
                                                    m[b] = s[j];
                                                    b++;
                                                    j++;
                                                    m[b] = s[j];
                                                    b++;
                                                    j++;
                                                }
                                            }

                                            if (c > 0)
                                            {
                                                mas[a] += "Десятичное число: ";
                                                for (int h = 0; h < j - 3; h++)
                                                {
                                                    mas[a] += m[h];
                                                }
                                                i = j - 1;
                                                a++;
                                            }
                                            else
                                            {
                                                if (s[j] == 'E' && s[j + 1] == '+')
                                                {
                                                    m[b] = s[j];
                                                    b++;
                                                    j++;
                                                    m[b] = s[j];
                                                    b++;
                                                    j++;
                                                }
                                                mas[a] += "Идентификатор: ";
                                                for (int h = 0; h < j; h++)
                                                {
                                                    mas[a] += m[h];
                                                }
                                                i = j - 1;
                                                a++;
                                            }
                                        }
                                        else
                                        {
                                            if (mas[a].empty() == true)
                                            {
                                                mas[a] += "Идентификатор: ";
                                            }
                                            mas[a] += s[i];

                                        }
    }
    for (int i = 0; i < a; i++)
    {
        cout << mas[i] << endl;
    }
    return 0;
}
