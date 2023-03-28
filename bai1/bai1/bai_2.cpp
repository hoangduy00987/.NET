#include <GL/glut.h>
#include <math.h>

// Khai b�o t?a d? P v� Q
GLfloat P[3] = {1.0, 2.0, 0.0};
GLfloat Q[3] = {7.0, 14.0, 0.0};

// G�c quay ban d?u
GLfloat angle = 0.0;

// H�m hi?n th? du?ng th?ng PQ v� di?m P sau khi quay
void display()
{
    glClear(GL_COLOR_BUFFER_BIT);
    glLoadIdentity();
    gluLookAt(5.0, 5.0, 20.0, 5.0, 5.0, 0.0, 0.0, 1.0, 0.0);
    glColor3f(0.0, 0.0, 0.0);
    glBegin(GL_LINES);
        glVertex3f(P[0], P[1], P[2]);
        glVertex3f(Q[0], Q[1], Q[2]);
    glEnd();
    glColor3f(1.0, 0.0, 0.0);
    glPushMatrix();
    glRotatef(angle, 0.0, 1.0, 0.0);
    glBegin(GL_POINTS);
        glVertex3fv(P);
    glEnd();
    glPopMatrix();
    glFlush();
}

// H�m th?c hi?n ph�p quay PG quanh tr?c Oy m?t g�c 30 d?
void rotate()
{
    angle += 30.0;
    if (angle >= 360.0)
        angle -= 360.0;
    GLfloat cos_a = cos(angle * M_PI / 180.0);
    GLfloat sin_a = sin(angle * M_PI / 180.0);
    GLfloat x = P[0];
    GLfloat z = P[2];
    P[0] = x * cos_a - z * sin_a;
    P[2] = x * sin_a + z * cos_a;
    glutPostRedisplay();
}

// H�m x? l� c�c s? ki?n t? b�n ph�m
void keyboard(unsigned char key, int x, int y)
{
    switch(key)
    {
        case 'r':   // Ph�m r d? th?c hi?n ph�p quay
            rotate();
            break;
        case 27:    // Ph�m ESC d? tho�t
            exit(0);
            break;
    }
}

// H�m main
int main(int argc, char** argv)
{
    glutInit(&argc, argv);
    glutInitDisplayMode(GLUT_SINGLE | GLUT_RGB);
    glutInitWindowSize(400, 400);
    glutCreateWindow("Line PQ");
    glutDisplayFunc(display);
    glutKeyboardFunc(keyboard);
    glMatrixMode(GL_PROJECTION);
    glLoadIdentity();
    gluPerspective(60.0, 1.0, 1.0, 100.0);
    glMatrixMode(GL_MODELVIEW);
    glClearColor(1.0, 1.0, 1.0, 0.0);
glEnable(GL_DEPTH_TEST);
glutMainLoop();
return 0;
}
