#include "Vector.h"
#include <math.h>


Vector::Vector(void)
{
	X = 0;
	Y = 0;
}


Vector::~Vector(void)
{
}

Vector::Vector(float x, float y)
{
	X = x;
	Y = y;
}


float Vector::GetMagnitude()
{
	return sqrt(pow(X, 2) + pow(Y, 2));
}

void Vector::Add(Vector v)
{
	X += v.X;
	Y += v.Y;
}
void Vector::Subtract(Vector v)
{
	X -= v.X;
	Y -= v.Y;
}

void Vector::Multiply(float f)
{
	X *= f;
	Y *= f;
}

void Vector::Divide(float f)
{
	X /= f;
	Y /= f;
}

float Vector::DotProduct(Vector v)
{
	return (X * v.X) + (Y * v.Y);
}

Vector Vector::Project(Vector v)
{
	Vector p(X, Y);
	p.Divide(GetMagnitude());
	p.Multiply(DotProduct(v) / GetMagnitude());

	return p;
}

Vector Vector::UnitVector()
{
	Vector p(X, Y);
	p.Divide(GetMagnitude());
	return p;
}

Vector Vector::operator+(Vector v)
{
	return Vector(X + v.X, Y + v.Y);
}

Vector Vector::operator-(Vector v)
{
	return Vector(X - v.X, Y - v.Y);
}

float Vector::GetDistance(Vector v)
{
	return sqrt(pow((X - v.X), 2) + pow((Y - v.Y), 2));
}

void Vector::Rotate(Vector o, float s, float c)
{
	X = (c * (X - o.X)) - (s * (Y - o.Y)) + o.X;
	Y = (s * (X - o.X)) + (c * (Y - o.Y)) + o.Y;
}