#include<iostream>
#include<string>
#include<list>

#include <vector>
#include <functional>
#include <algorithm>
#include <tuple>
#include <stdexcept>
#include <memory>

using namespace std;

///////lex analiz
enum tok_names { ident, num, math };
string names[3];
struct token
{
	enum tok_names token_name;
	string token_names[3] = { "Ident", "Number", "Math" };
	string token_value;
};
list<token> lexeme_table;

token add_token(tok_names a, string b) {
	token tok;

	tok.token_name = a;
	tok.token_value = b;

	return tok;
}
list<token> lexer(string str)
{
	list<token> lexeme_table;

	int i = 0; int value = 0;
	while (i < str.size())
	{
		if (str[i] == '+') { lexeme_table.push_back(add_token(math, "+")); }
		if (str[i] == '-') { lexeme_table.push_back(add_token(math, "-")); }
		if (str[i] == '*') { lexeme_table.push_back(add_token(math, "*")); }
		if (str[i] == '/') { lexeme_table.push_back(add_token(math, "/")); }

		if ((str[i] >= 'a' and str[i] <= 'z') or (str[i] >= 'A' and str[i] <= 'Z')) {
			string var = "";
			while ((str[i] >= 'a' and str[i] <= 'z') or (str[i] >= 'A' and str[i] <= 'Z') or (str[i] >= '0' and str[i] <= '9'))
			{
				var += str[i];
				i++;
			}
			i--;
			lexeme_table.push_back(add_token(ident, var));
		}

		if ((str[i] >= '0' and str[i] <= '9')) {
			string number = "";
			while (str[i] >= '0' and str[i] <= '9')
			{
				number += str[i];
				i++;
			}
			i--;
			lexeme_table.push_back(add_token(num, number));
		}

		i++;
	}
	return lexeme_table;
}

////////tree
struct node
{
	token token;                           //Информационное поле
	node* l, * r;                        //Левая и Правая часть дерева
};
node* tree = NULL;                      //Объявляем переменную, тип которой структура Дерево



void pushTree(token token, node** t) //Add
{
	if ((*t) == NULL)                   //Если дерева не существует
	{
		(*t) = new node;                //Выделяем память
		(*t)->token = token;                 //Кладем в выделенное место аргумент a
		(*t)->l = (*t)->r = NULL;       //Очищаем память для следующего роста
		return;                         //Заложили семечко, выходим
	}
	//Дерево есть

	if (token.token_name != num and token.token_name != ident) {
		pushTree(token, &(*t)->r);
		return;
	}
	if ((token.token_name == num or token.token_name == ident) and (*t)->l == NULL) {
		pushTree(token, &(*t)->l);
		return;
	}
	else {
		pushTree(token, &(*t)->r);
		return;
	}
}

void printTriad(node** t, int u)
{
	//if ()
	if ((*t)->r->token.token_name == math)
	{
		printTriad(&(*t)->r, ++u);
		//int count = u;
		cout << u << ". ";
		//count--;

		cout << (*t)->token.token_value;
		cout << '(';
		//u++;
		if ((*t)->l->token.token_name != math) cout << u + 1 << '^' << ',' << (*t)->l->token.token_value;
		else cout << u + 1 << "^," << u << '^';
		cout << ')' << endl;
		//return;
		if ((*t)->l->token.token_name == math)
		{
			//u++;
			cout << u << ". ";

			cout << (*t)->l->token.token_value;
			cout << '(';
			cout << (*t)->l->r->token.token_value << ',' << (*t)->l->l->token.token_value;
			cout << ')' << endl;
		}
	}
	else
	{
		u++;
		//int count = u;
		cout << u << ". ";

		cout << (*t)->token.token_value;
		cout << '(';
		cout << (*t)->r->token.token_value << ',';
		cout << (*t)->l->token.token_value;
		cout << ')' << endl;
		return;
	}
}

static std::string ch_hor = "-", ch_ver = "|", ch_ddia = "/", ch_rddia = "\\", ch_udia = "\\", ch_ver_hor = "|-", ch_udia_hor = "\\-", ch_ddia_hor = "/-", ch_ver_spa = "| ";
void printTree(node const* t, std::string const& prefix = "", bool root = true, bool last = true) {
	std::cout << prefix << (root ? "" : (last ? ch_udia_hor : ch_ver_hor)) << (t ?(t->token.token_value) : "") << std::endl;
	if (!t || (!t->l && !t->r))
		return;
	std::vector<node*> v{ t->l, t->r };
	for (size_t i = 0; i < v.size(); ++i)
		printTree(v[i], prefix + (root ? "" : (last ? "  " : ch_ver_spa)), false, i + 1 >= v.size());
}


int main()
{
	token tok;
	string str = "A + B + 12 * 13 + C + D"; //A + B + 12 * 13 + C + D //1 * 2 + A
	list<token> lexeme_table = lexer(str);


	list<token> temp = lexeme_table;
	while (temp.empty() == 0) {
		tok = temp.front();
		cout << "<TOKEN_NAME:" << tok.token_names[tok.token_name] << ",\t" << "TOKEN_VALUE:" << tok.token_value << ">" << endl;
		temp.pop_front();
	}
	cout << endl;

	list<token> znak;
	list<token> identif;

	temp = lexeme_table;
	while (temp.size() > 0)
	{
		if (temp.front().token_name == num or temp.front().token_name == ident) {
			identif.push_back(temp.front());
			temp.pop_front();
		}
		else {
			znak.push_back(temp.front());
			temp.pop_front();
		}
	}

	node* sosna = NULL;

	while (znak.size() > 0 or identif.size() > 0)
	{
		if (znak.size() > 0)
		{
			pushTree(znak.front(), &sosna);
			znak.pop_front();
		}
		pushTree(identif.front(), &sosna);
		identif.pop_front();
	}

	printTree(sosna);
	cout << endl;
	printTriad(&sosna, 0);
}