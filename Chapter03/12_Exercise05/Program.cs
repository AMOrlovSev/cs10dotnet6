using static System.Console;

int x = 3;
int y = 2 + ++x;
WriteLine($"x: {x}, y: {y}");

int a = 3 << 2;
int b = 10 >> 1;
WriteLine($"a: {a}, b: {b}");

int c = 10 & 8; //8
int d = 10 | 7; //8+4+2+1
WriteLine($"c: {c}, d: {d}");