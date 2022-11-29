#include "Spring.h"
#include <math.h>
#include <iostream>



using namespace std;

struct Color
{
	float r;
	float g;
	float b;

};

float currentY;
Color color;
float lastY;
float vy;

float const HOME_X = 360;
float const HOME_Y = 60;
float const WIDTH = 40;
float const HEIGHT = 20;
float const SPRING = .05;


Spring::Spring(void)
{
	color.r = 0.0;
	color.b = 155.0;
	color.g = 0.0;
	currentY = HOME_Y;
	Held = false;
	vy = 0;
}


Spring::~Spring(void)
{
}

void Spring::IsClicked(int mouseX, int mouseY)
{
	if (mouseX > HOME_X && mouseX < HOME_X + WIDTH)
	{
		if (mouseY < currentY && mouseY > currentY - HEIGHT)
		{
			Held = true;
		}
	}
}

void Spring::Update(int mouseY)
{
	lastY = currentY;
	if (Held)
	{
		vy = 0;
		currentY = mouseY;
	}
	else if (currentY < HOME_Y)
	{
		float dy = HOME_Y - currentY;
		float ay = dy * SPRING;
		vy += ay;
		currentY += vy;
	}
	else
	{
		currentY = HOME_Y;
		vy = 0;
	}
}

void Spring::Collide(Ball* b)
{
	if (b->Center.X > HOME_X && b->Center.X < HOME_X + WIDTH)
	{
		if (b->Center.Y < currentY + b->Radius)
		{
			b->Acceleration.Y = 0;
			b->Speed.Y = vy;
			b->Center.Y = currentY + b->Radius;
		}
	}

}