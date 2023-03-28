#include <iostream>
#include <cmath>
#include <GL/glut.h>

#define PI 3.14159265358979323846

// H�m t�nh to�n t?a d? c�c d?nh c?a ng�i sao
void calculateVertices(GLfloat vertices[][2], GLfloat centerX, GLfloat centerY, GLfloat radius)
{
    GLfloat angle = 72.0 * PI / 180.0;
    for(int i = 0; i < 5; i++)
    {
        vertices[i][0] = centerX + radius * cos(i * angle);
        vertices[i][1] = centerY + radius * sin(i * angle);
    }
}

// H�m v? ng�i sao v?i c�c d?nh d� t�nh to�n
void drawStar(GLfloat vertices[][2], GLfloat r, GLfloat g, GLfloat b)
{
    
    glBegin(GL_LINES);
    glColor3f(r, g, b);
    for(int i = 0; i < 5; i++)
    {
        glVertex2fv(vertices[i]);
        glVertex2fv(vertices[(i+2)%5]);
    }
    glEnd();
}

// H�m v?
void display()
{
    glClear(GL_COLOR_BUFFER_BIT);

    // T?a d? t�m ng�i sao
    GLfloat centerX = 200.0;
    GLfloat centerY = 200.0;

    // B�n k�nh ng�i sao
    GLfloat radius = 100.0;

    // M?ng ch?a t?a d? c�c d?nh
    GLfloat vertices[5][2];

    calculateVertices(vertices, centerX, centerY, radius);
    drawStar(vertices, 1.0, 0.0, 0.0);

    glFlush();
}

int main(int argc, char** argv)
{
    glutInit(&argc, argv);
    glutInitDisplayMode(GLUT_SINGLE | GLUT_RGB);
    glutInitWindowSize(400, 400);
    glutInitWindowPosition(100, 100);
    glutCreateWindow("Star");
    glutDisplayFunc(display);
    glClearColor(1.0, 1.0, 1.0, 1.0);
    gluOrtho2D(0.0, 400.0, 0.0, 400.0);
    glutMainLoop();
    return 0;
}

