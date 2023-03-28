#include <GL/glut.h>
#include <math.h>

// Khai báo t?a d? P và Q
GLfloat P[3] = {1.0, 2.0, 0.0};
GLfloat Q[3] = {7.0, 14.0, 0.0};

// Góc quay ban d?u
GLfloat angle = 0.0;

// Hàm hi?n th? du?ng th?ng PQ và di?m P sau khi quay
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

// Hàm th?c hi?n phép quay PG quanh tr?c Oy m?t góc 30 d?
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

// Hàm x? lý các s? ki?n t? bàn phím
void keyboard(unsigned char key, int x, int y)
{
    switch(key)
    {
        case 'r':   // Phím r d? th?c hi?n phép quay
            rotate();
            break;
        case 27:    // Phím ESC d? thoát
            exit(0);
            break;
    }
}

// Hàm main
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
