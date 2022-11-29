#include "Peg.h"
#include <math.h>
#include <iostream>



struct Color
{
	float r;
	float g;
	float b;

};
Color pColor;


Peg::Peg(void)
{
}


Peg::~Peg(void)
{
}


Peg::Peg(int x, int y, int ra)
{
	position = Vector(x, y);
	r = ra;
	pColor.r = 0;
	pColor.g = 0;
	pColor.b = 50;
}




void Peg::Collide(Ball* b)
{
	Vector v = b->Speed;

	if (v.GetMagnitude() >= (b->Center.GetDistance(position) - (b->Radius + r)))
	{
		Vector x = position - b->Center;
		Vector n = v.UnitVector();
		float d = n.DotProduct(x);
		if (d > 0)
		{
			float f = pow(x.GetMagnitude(), 2) - pow(d, 2);
			if (f < pow(b->Radius + r, 2))
			{

				float t = pow(b->Radius + r, 2) - f;
				if (t >= 0)
				{
					d = d - sqrt(t);
					if (v.GetMagnitude() >= d)
					{
						b->Speed = n;
						b->Speed.Multiply(d);
						b->Center.Add(b->Speed);

						x.Multiply(-1);
						x = x.UnitVector();
						b->Speed = b->Speed + x;

						b->score += 500;
					}
				}

			}
		}
	}
}
