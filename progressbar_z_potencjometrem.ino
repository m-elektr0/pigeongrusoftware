

#include <Wire.h>
#include <Adafruit_SSD1306.h>
#include <Adafruit_GFX.h>

#define OLED_WIDTH 128
#define OLED_HEIGHT 32

#define OLED_ADDR   0x3C

Adafruit_SSD1306 display(OLED_WIDTH, OLED_HEIGHT);

	
int potentiometer = A0; //Assign to pin A0

void setup() {
  // put your setup code here, to run once:
  display.begin(SSD1306_SWITCHCAPVCC, OLED_ADDR);
  display.clearDisplay();

  display.setTextSize(2);
  display.setTextColor(WHITE);
  display.setCursor(0, 0);
  pinMode(potentiometer, INPUT); //Sets the pinmode to input

}

void loop() {
  // put your main code here, to run repeatedly:
  int sensor_value = analogRead(potentiometer); //Read the value from the potentiometer connected to the A0 pin
    int value = map(sensor_value, 0, 1023, 0, 128);
    display.clearDisplay();
    display.fillRect(0, 0, value, 64, WHITE);
    display.display();

}
