#define _CRT_SECURE_NO_WARNINGS // _itoa's unsafe, i'm not letting this slip
#include "PinballMachine.h"
#include <iostream>
#include <math.h>
#include <GL/glut.h>
#include "Ball.h"
#include "Spring.h"
#include "TriangleBumper.h"
#include "CircleBumper.h"
#include "Vector.h"
#include "Peg.h"
#include "Flipper.h"
#include "Box.h"
#include "Target.h"
#include <windows.h>
#include <mmsystem.h>
struct Point
{
	int x;
	int y;
};

int window; 
int mouseX = 0;
int mouseY = 0;
int mouseClicking = 0;
bool aHeld;
bool dHeld;


#define PI 3.14159

int const NUM_TRIANGLES = 2;
TriangleBumper triangles[NUM_TRIANGLES];
int const NUM_BOXES = 6;
Box boxes[NUM_BOXES];
int const NUM_PEGS = 3;
Peg pegs[NUM_PEGS];
int const NUM_CIRC_BUMPERS = 3;
CircleBumper cBumpers[NUM_CIRC_BUMPERS];
Ball b;
Spring s;
Flipper leftFlipper(48,51,48,25,125,10,50,50);
Flipper rightFlipper(252,51,252,26,175,10,250,50);
Target t(150,250,10);


PinballMachine::PinballMachine(void)
{
}


PinballMachine::~PinballMachine(void)
{
}


void idle (void)
{
	glutPostRedisplay();
}

void keyboardDown(unsigned char key, int x, int y)
{
	if(key == 'a')
	{
		aHeld = true;
	}

	if(key == 'd')
	{
		dHeld = true;
	}
	if(key=='r')
	{
		b.SetBall();
	}
}

void keyboardUp(unsigned char key, int x, int y)
{
		if(key == 'a')
	{
		aHeld = false;
	}

	if(key == 'd')
	{
		dHeld = false;
	}
}

void mouseMovement(int x, int y) {
	mouseX = x;
	mouseY = y;
}

void mouseClicks(int buttonPressed, int state, int x, int y) {
	if(buttonPressed == GLUT_LEFT_BUTTON)
	{
		if(state == GLUT_DOWN)
		{
			mouseClicking = 1;
			//std::cout<<mouseClicking<<std::endl;
		}
		else
		{
			mouseClicking = 0;
			//std::cout<<mouseClicking<<std::endl;
		}
	}

}
void display(void)
{
	glutSetWindow(window);  

    glClear(GL_COLOR_BUFFER_BIT);

	int mY = (400 * (700 - mouseY)) / 700;
	int mX = 400 - ((400 * (700 - mouseX)) / 700);
	
	if(!b.BallActive)
	{
		b.SetBall();
	}

	if(mouseClicking == 1)
	{
		s.IsClicked(mX, mY);
	}
	else
	{
		s.Held = false;
	}

	s.Collide(&b);
	for(int i = 0; i < NUM_TRIANGLES; i++)
	{
		triangles[i].Collide(&b);
		triangles[i].Draw();
	}
	for(int j = 0; j < NUM_BOXES; j++)
	{
		boxes[j].Collide(&b);
		boxes[j].Draw();
	}
	for(int k = 0; k < NUM_PEGS; k++)
	{
		pegs[k].Collide(&b);
		pegs[k].Draw();
	}
	for(int o = 0; o < NUM_CIRC_BUMPERS; o++)
	{
		cBumpers[o].Collide(&b);
		cBumpers[o].Draw();
	}
	t.Collide(&b);
	leftFlipper.Update(aHeld, 'l');
	rightFlipper.Update(dHeld, 'r');
	leftFlipper.Collide(&b);
	rightFlipper.Collide(&b);
	b.Update();
	s.Update(mY);
	t.Update();


	s.Draw();
	b.Draw();
	leftFlipper.Draw();
	rightFlipper.Draw();
	t.Draw();
	
	char strScore[10];
	_itoa(b.score, strScore, 10);
	char strBallsLeft[3];
	_itoa(b.ballsLeft,strBallsLeft, 10);
	char score[7] = "Score:";
	char ballsLeft[12] = "Balls left:";
	char *c;
	glRasterPos3f(100, 100,0);
	for (c=strScore; *c != '\0'; c++) 
	{
		glutBitmapCharacter(GLUT_BITMAP_TIMES_ROMAN_24, *c);
	}
	glColor3f(50,0,0);
	char* d;
	glRasterPos3f(100, 75,0);
	for (d=strBallsLeft; *d != '\0'; d++) 
	{
		glutBitmapCharacter(GLUT_BITMAP_TIMES_ROMAN_24, *d);
	}
	char* e;
	glRasterPos3f(25, 100,0);
	for (e=score; *e != '\0'; e++) 
	{
		glutBitmapCharacter(GLUT_BITMAP_TIMES_ROMAN_24, *e);
	}
	char* f;
	glRasterPos3f(25, 75,0);
	for (f=ballsLeft; *f != '\0'; f++) 
	{
		glutBitmapCharacter(GLUT_BITMAP_TIMES_ROMAN_24, *f);
	}

    glutSwapBuffers();
}

void init (void) 
{

    glClearColor (0.402, 0.605, 1.0, 1.0);
	
    glMatrixMode(GL_PROJECTION);
    glLoadIdentity();
    glOrtho(0.0, 400.0, 0.0, 400.0, 0.0, 400.0);


	triangles[0] = TriangleBumper(300,400,400,400,400,300);
	triangles[1] = TriangleBumper(100,400,0,400,0,300);

	boxes[0] = Box(300,250,60,250);
	boxes[1] = Box(0,401,400,1);
	boxes[2] = Box(400,400,1,400);
	boxes[3] = Box(-1,400,1,400);
	boxes[4] = Box(0,50,50,50);
	boxes[5] = Box(250,50,50,50);
	
	pegs[0] = Peg(150,375,5);
	pegs[1] = Peg(200, 375,5);
	pegs[2] = Peg(250,375,5);

	cBumpers[0] = CircleBumper(175,200,10);
	cBumpers[1] = CircleBumper(125,200,10);
	cBumpers[2] = CircleBumper(150,300,10);
}

int main(int argc, char** argv)
{
	system("title Рекорды");
	PlaySound(L"Bellini-Samba-De-Janeiro-_megapesni.club_.wav", NULL, SND_ASYNC | SND_LOOP);
    glutInit(&argc, argv);

    glutInitDisplayMode (GLUT_DOUBLE | GLUT_RGB);

    glutInitWindowSize(700, 700); 

    glutInitWindowPosition(550, 50);

    window = glutCreateWindow ("Пинбол: Cкала объясняет"); 

    init();



    glutDisplayFunc(display); 


	glutPassiveMotionFunc(mouseMovement);  
	glutMotionFunc(mouseMovement); 
	glutMouseFunc(mouseClicks);  
	glutIdleFunc(idle); 
	glutKeyboardFunc(keyboardDown);
	glutKeyboardUpFunc(keyboardUp);

	
    glutMainLoop();
    return 0;   
}
