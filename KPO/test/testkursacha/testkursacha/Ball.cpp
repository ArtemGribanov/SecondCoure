#include "Ball.h"
#include <math.h>
#include <iostream>

#include <vector>
#include <string>
#include <Windows.h>
#include <iomanip>
#include <algorithm>
struct Color
{
	float r;
	float g;
	float b;

};
std::string kkk;
Color c;
struct HIGHSCORE {
	std::string Name;
	int HS;
}ok;
HIGHSCORE* nok = &ok;
std::vector <HIGHSCORE> Lol;
bool comp(HIGHSCORE ENERGY1, HIGHSCORE ENERGY2) {
	return ENERGY1.HS > ENERGY2.HS;
}
float const GRAVITY = -0.002;
Ball::Ball(void)
{
	c.r = 128.0;
	c.b = 0.0;
	c.g = 0.0;
	Center = Vector(200, 100);
	Radius = 10;
	IsFalling = true;


	Speed = Vector(0, 0);
	Acceleration = Vector(0, 0);
	BallActive = false;
	score = 0;
	ballsLeft = 16;

}


Ball::~Ball(void)
{

}


void Ball::Update()
{
	if (IsFalling)
	{
		Acceleration.Y += GRAVITY / 2;
	}

	Speed.Add(Acceleration);
	Center.Add(Speed);
	if (Center.Y < 0 - Radius)
	{
		if (ballsLeft > 0)
		{
			SetBall();
		}
		else
		{
			ScOOre();
		}

	}
}
void Ball::ScOOre() {
	system("pause");
	std::cout << "ENTER YOUR INITIALS" << std::endl;
	std::cin >> kkk;
	while (kkk.length() > 32) {
		std::cout << "Too many symbols (more than 32), repeat the entering sequence" << std::endl;
		std::cin >> kkk;
	}
	nok->Name = kkk;
	nok->HS = score;
	Lol.push_back(ok);
	sort(Lol.begin(), Lol.end(), comp);
	system("cls");
	std::cout.setf(std::ios::left);
	std::cout.width(32);
	std::cout << "Name" << std::setw(32) << "Highscore" << std::endl;
	for (int i = 0; i < Lol.size(); i++) {
		if (i >= 10) {
			Lol.erase(Lol.begin() + i);
			break;
		}
		std::cout.setf(std::ios::left);
		std::cout.width(32);
		std::cout << Lol[i].Name << std::setw(32) << Lol[i].HS << std::endl; // printing and calculating ur HS
	}
	ballsLeft = 16;
	score = 0;
}
void Ball::SetBall()
{
	Speed = Vector(0, 0);
	Acceleration = Vector(0, 0);
	Center = Vector(380, 100);
	BallActive = true;
	if (ballsLeft == 0) {
		ScOOre();
	}
	ballsLeft--;
}