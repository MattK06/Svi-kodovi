#include <IRremote.h>


const int RECV_PIN = 7;
IRrecv irrecv(RECV_PIN);
decode_results results;

void setup() {
  Serial.begin(9600);
  irrecv.enableIRIn();
  irrecv.blink13(true);
  pinMode(5,OUTPUT);
}

void loop() {
  if (irrecv.decode(&results)){
    switch(results.value){
      
      case 0xFF30CF:
      analogWrite(5,20);
      break;

      case 0xFF18E7:
      analogWrite(5,60);
      break;

      case 0xFF7A85:
      analogWrite(5,150);
      break;

      case 0xFFA857:
      analogWrite(5,255);
      break;
    
      case 0xFFE01F:
      analogWrite(5,0);
      break;

    }
  
    Serial.println(results.value, HEX);
    irrecv.resume();
    }
}

