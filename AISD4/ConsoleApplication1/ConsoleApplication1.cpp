#include <iostream>

bool PrintFragments(unsigned num, unsigned max, unsigned& nTry, unsigned lvl = 0);

bool PrintFragmentsImpl(unsigned num, unsigned n, unsigned max,
    unsigned& nTry, unsigned lvl)
{
    if (!n)
        return false;

    if (n > max)
        return PrintFragmentsImpl(num, n - 1, max, nTry, lvl);

    bool found = false;

    if (n == num)
    {
        if (!--nTry)
            found = true;
    }
    else if (PrintFragments(num - n, n, nTry, lvl + 1))
    {
        found = true;
    }

    if (found)
    {
        std::cout << n << " ";

        if (!lvl)
            std::cout << "\n";

        return true;
    }

    if (--n)
        return PrintFragmentsImpl(num, n, max, nTry, lvl);

    return false;
}

bool PrintFragments(unsigned num, unsigned max, unsigned& nTry, unsigned lvl)
{
    return PrintFragmentsImpl(num, num, max, nTry, lvl);
}

unsigned PrintNumFragmentsImpl(unsigned num, unsigned nTry)
{
    unsigned n = nTry;
    if (PrintFragments(num, num, n))
        return PrintNumFragmentsImpl(num, nTry + 1);
    else
        return nTry - 1;
}

void PrintNumFragmentsInfo(unsigned num)
{
    unsigned counter = PrintNumFragmentsImpl(num, 1);

    std::cout << "total amounts of fragments is : " << counter << "\n";
}

int main()
{
    unsigned num = 0;
    std::cin >> num;

    PrintNumFragmentsInfo(num);
}