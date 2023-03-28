#include <GL/glut.h>
#include <cmath>

void display() {
    glClear(GL_COLOR_BUFFER_BIT);

    // V? d? th? c?a hàm y = sin(x)
    glColor3f(1.0, 0.0, 0.0);
    glBegin(GL_LINE_STRIP);
    for (float x = -10.0; x <= 10.0; x += 0.1) {
        glVertex2f(x, sin(x));
    }
    glEnd();

    // V? d? th? c?a hàm y = cos(x)
    glColor3f(0.0, 1.0, 0.0);
    glBegin(GL_LINE_STRIP);
    for (float x = -10.0; x <= 10.0; x += 0.1) {
        glVertex2f(x, cos(x));
    }
    glEnd();

    glFlush();
}

int main(int argc, char** argv) {
    glutInit(&argc, argv);
    glutInitDisplayMode(GLUT_SINGLE | GLUT_RGB);
    glutInitWindowSize(500, 500);
    glutInitWindowPosition(100, 100);
    glutCreateWindow("Do thi y=sin(x), y=cos(x)");
    glClearColor(1.0, 1.0, 1.0, 0.0);
    glutDisplayFunc(display);
    glutMainLoop();
    return 0;
}

