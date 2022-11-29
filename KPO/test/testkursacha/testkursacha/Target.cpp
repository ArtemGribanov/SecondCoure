#include "Target.h"
#include <math.h>
#include <iostream>

struct Color
{
	float r;
	float g;
	float b;

};
Color tOutColor;
Color tInColor;

int wait;

Target::Target(void)
{
}


Target::~Target(void)
{
}

Target::Target(int x, int y, int r)
{
	place = Vector(x, y);
	rad = r;
	tInColor.r = 50;
	tInColor.g = 50;
	tInColor.b = 50;
	tOutColor.r = 0;
	tOutColor.g = 0;
	tOutColor.b = 0;

	wait = 0;
}

void Target::Collide(Ball* b)
{
	Vector v = b->Speed;
	if (v.GetMagnitude() >= (b->Center.GetDistance(place) - (b->Radius + rad)))
	{
		Vector x = place - b->Center;
		Vector n = v.UnitVector();
		float d = n.DotProduct(x);
		if (d > 0)
		{
			float f = pow(x.GetMagnitude(), 2) - pow(d, 2);
			if (f < pow(b->Radius + rad, 2))
			{

				float t = pow(b->Radius + rad, 2) - f;
				if (t >= 0)
				{
					d = d - sqrt(t);
					if (v.GetMagnitude() >= d)
					{
						wait = 120;
						b->score += 1000;
					}
				}

			}
		}
	}
}

void Target::Update()
{
	if (wait > 0)
	{
		if (wait % 10 == 0)
		{
			Color temp = tInColor;
			tInColor = tOutColor;
			tOutColor = temp;
		}
		wait--;
	}
	else
	{
		tInColor.r = 50;
		tInColor.g = 50;
		tInColor.b = 50;
		tOutColor.r = 0;
		tOutColor.g = 0;
		tOutColor.b = 0;
	}
}