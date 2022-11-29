#include "Box.h"
#include <math.h>
#include <iostream>






struct Color
{
	float r;
	float g;
	float b;

};
Color bColor;
Box::Box(void)
{
}


Box::~Box(void)
{
}

Box::Box(float x, float y, float w, float h)
{
	topLeft = Vector(x, y);
	topRight = Vector(x + w, y);
	botLeft = Vector(x, y - h);
	botRight = Vector(x + w, y - h);
	bColor.r = 0;
	bColor.b = 50;
	bColor.g = 50;
}


void bounceBall(Ball* b, Vector y, Vector x)
{
	Vector d = y - x;
	Vector n1 = Vector(-d.Y, d.X);
	n1 = n1.UnitVector();
	d = y - b->Center;
	float distanceToLine = d.DotProduct(n1);
	if (distanceToLine > b->Radius || distanceToLine + b->Radius < b->Radius)
	{
		Vector nextLocation = b->Center + b->Speed;
		d = y - nextLocation;
		float nextDistanceToLine = d.DotProduct(n1);
		float time = (b->Radius - distanceToLine) / (nextDistanceToLine - distanceToLine);
		if (time > 0 && time <= 1.03)
		{
			Vector moveToLine = b->Speed;
			moveToLine.Multiply(time);
			moveToLine = b->Center + moveToLine;
			if (x.X == y.X)
			{
				if ((moveToLine.Y >= x.Y - b->Radius && moveToLine.Y <= y.Y + b->Radius) || (moveToLine.Y >= y.Y - b->Radius && moveToLine.Y <= x.Y + b->Radius))
				{
					b->Center = moveToLine;
					b->Speed.X = -b->Speed.X;
					b->score += 50;
				}
			}
			else if (x.Y == y.Y)
			{

				if ((moveToLine.X > x.X - b->Radius && moveToLine.X < y.X + b->Radius) || (moveToLine.X > y.X - b->Radius && moveToLine.X < x.X + b->Radius))
				{
					b->Center = moveToLine;
					b->Speed.Y = -b->Speed.Y;
					b->score += 50;

				}
			}
		}
	}
}

void Box::Collide(Ball* b)
{
	if (b->Center.X > topRight.X)
	{
		bounceBall(b, topRight, botRight);
	}
	if (b->Center.X < topLeft.X)
	{
		bounceBall(b, botLeft, topLeft);
	}
	if (b->Center.Y > topLeft.Y)
	{
		bounceBall(b, topLeft, topRight);
	}
	if (b->Center.Y < botLeft.Y)
	{
		bounceBall(b, botRight, botLeft);
	}
}



	