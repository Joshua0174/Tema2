Single Responsability principle
Am spart clasa HotelReception in mai multe clase care se ocupa de un singur lucru (srp):  
 Logger, FileSource(returneaza continutul fisierului json), FactoryOrder(creeaza un obiect de tip Orderer),
 Oderer(este o clasa care se ocupa cu procesarea seriviciului/comenzii), OrderSerializer 
 Practic fiecare clasa are o singura responsabilate.

Open/Closed principle
Clasa Orderer are ca scop procesarea comenzilor. Aceasta este mostenita de clasele BreakFastOrderer, RoomOrderer, UnknownOrderer si ProductOrderer. 
Aceste clase se ocupa cu procesarea fiecarui tip de comanda. Aici apare si principiul open/close pentru ca aceste clasa Orderer este inchisa 
la modificari, insa poate fii extinsa in clasele derivate. 

Liskov Substitution Principle
Principiul Liskov este respectat pentru ca orice obiect de tipul claselor care extind clasa Orderer poate fi convertit la un obiect de baza.
In sine, fiecare comanda, indiferent de tipul ei, este o comanda. Acest principiu se intampla intre clasele HotelReception si OrderFactory(care returneaza
o comanda).


Interface segregation
Am folosit acest principiu implementand in toate clasele cate o interfata. Pentru logger este ILogger, pentru FileSource este IFileSource etc.
Asa am facut o separare clara intre clase, si ce trebuie sa faca fiecare.


Dependency Inversion 
Clasa HotelReception depinde de abstractizari ale claselor Logger, FileSource, IOrderSerializer, IOrderFactory. Practic in loc sa depinda de acestea, 
HotelReception depinde de interfetele implementate in acele clase.
