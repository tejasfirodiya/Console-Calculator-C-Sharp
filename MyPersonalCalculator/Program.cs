/*
Assignment:
==========
Create a visual calculator.
It should look and work similar to the windows calculator
Implement the following buttons
%,   CE,   C,   back,
1/x  x2   s2x    /
7    8     9     x
4    5     6     -
1    2     3     +
+/-  0     .     =
Assume, your senior team has already coded some functionality like
Button class, DisplayText class, Calculator class &
MathsKeyHandler class.
Your assignment is to add code into the MathsKeyHandler class
to get the calculator working.
You may have to change some minor code in other classes if required.

Q. What entities are needed?
A. Calculator
B. DisplayBox
C. Button
d. MathsKeyHandler
*/

var calculator = new Calculator();
calculator.Start();