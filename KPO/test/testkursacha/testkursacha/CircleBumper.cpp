#include "CircleBumper.h"
#include <math.h>
#include <iostream>


struct Color
{
	float r;
	float g;
	float b;

};
Color cColor;
Vector c;
float radius;

float KICK_BACK = 11;

CircleBumper::CircleBumper(void)
{

}


CircleBumper::~CircleBumper(void)
{
}

CircleBumper::CircleBumper(int x, int y, int r)
{
	c = Vector(x, y);
	radius = r;
	cColor.r = 50;
	cColor.g = 50;
	cColor.b = 50;
}



void CircleBumper::Collide(Ball* b)
{
	Vector v = b->Speed;
	if (v.GetMagnitude() >= (b->Center.GetDistance(c) - (b->Radius + radius)))
	{
		Vector x = c - b->Center;
		Vector n = v.UnitVector();
		float d = n.DotProduct(x);
		if (d > 0)
		{
			float f = pow(x.GetMagnitude(), 2) - pow(d, 2);
			if (f < pow(b->Radius + radius, 2))
			{
				float t = pow(b->Radius + radius, 2) - f;
				if (t >= 0)
				{
					d = d - sqrt(t);
					if (v.GetMagnitude() >= d)
					{
						b->Speed = n;
						b->Speed.Multiply(d);
						b->Center.Add(b->Speed);

						Vector n = b->Center - c;
						n = n.UnitVector();
						n.Multiply(KICK_BACK);
						b->Speed = b->Speed + n;
						b->score += 100;

					}
				}

			}
		}
	}
}