
#include <SPI.h>
#include <MFRC522.h>

#define DEVICE "RFID Scanner\0"

#define ID "SCN_ID"
#define TYPE "SCN_TYP"
#define RESPONSE "SCN_ACK\0"
#define SCAN_CMD "SCN_GET"
#define INVALID "INVALID_CMD - "
#define MAX_CMD_LEN 25
#define NULL_TERM '\0'

#define ATTEMPTS 100

#define SS_PIN 10
#define RST_PIN 5

#define MAX_UID_LEN 10

MFRC522 reader(SS_PIN,RST_PIN);

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  SPI.begin();
  reader.PCD_Init();
}

void loop() {
  // put your main code here, to run repeatedly:
  if(Serial.available()){    
    process_cmd();
    Serial.flush();
    while(Serial.available()){
      Serial.read();

    }
    
  }
  delay(10);
}

void process_cmd(){
 String Input = Serial.readStringUntil('\0');
  if(Input.equals(ID)){
  respond();
  
  }
  else if (Input.equals(TYPE)){
    print_type();
  }
  else if (Input.equals(SCAN_CMD)){
  scan_code();
  
  }
  else{  

  err(Input);
  
  }

  
}
void print_type(){
  Serial.write((DEVICE));
}
void respond(){
  Serial.write(RESPONSE);
  
}
void err(String cmd){

  
  String invalidstr = String(INVALID);
  String nullstr = String(NULL_TERM);

  invalidstr.concat(cmd);
  invalidstr.concat(nullstr);

  Serial.println(invalidstr);
  

}
void scan_code(){
  for(int i =0; i< ATTEMPTS; i++){

    if (reader.PICC_IsNewCardPresent()) {
      if (reader.PICC_ReadCardSerial()) {
        MFRC522::PICC_Type piccType = reader.PICC_GetType(reader.uid.sak);

        String uid_out="";

        
        for (int j = 0; j < reader.uid.size; j++) {
          uid_out.concat(String(reader.uid.uidByte[j],HEX));           
           
          
          
        }
        
        uid_out.concat(NULL_TERM);
       
        Serial.print(uid_out);
              
       

        reader.PICC_HaltA(); 
        reader.PCD_StopCrypto1(); 

        break;
      }
    
    }
    delay(10);
  }


}

