using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone


Smartphone nokia = new Nokia("11111", "Nokia12", "8888888", 256);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Smartphone iphone = new Iphone("2222", "Ihone 15", "000000", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");