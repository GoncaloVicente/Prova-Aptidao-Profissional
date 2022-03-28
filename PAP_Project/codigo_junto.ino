#include <Servo.h> 
Servo myservo;  

void setup () {

Serial.begin(9600);  
myservo.attach(9);
myservo.attach(10);
pinMode (13, OUTPUT);
}

void loop(){

//###########SERVO###########
while (Serial.available() == 0); // do nothing if nothing sent
int val = Serial.read() - '0'; // deduct ascii value of '0' to find numeric value of sent number


if (val == 1)
{
  myservo.write(180);
}
else if (val == 2)
{
  myservo.write(-180);  //rotates the servo 90 degrees (right)
} 
  Serial.flush(); // clear serial port

//###########SERVO###########
while (Serial.available() == 0); // do nothing if nothing sent
int val1 = Serial.read() - '0'; // deduct ascii value of '0' to find numeric value of sent number


if (val1 == 3)
{
  myservo.write(0);
}
else if (val1 == 4)
{
  myservo.write(360);  //rotates the servo 90 degrees (right)
} 
  Serial.flush(); // clear serial port


//######LED######
while (Serial.available() == 0); // do nothing if nothing sent
int val2 = Serial.read() - '0'; // deduct ascii value of '0' to find numeric value of sent number


if (val2 == 5)
{

digitalWrite (13, HIGH); 
}
else if (val2 == 6)
{
digitalWrite (13, LOW); 
}
}

