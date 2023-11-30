# UserDBTask3

TDD -dev
Av Kade23kt

Svårigheten i denna uppgiften kom först och främst från att jag för egen del valt att använda VS code istället för Visual Studio. Jag har använt bägge innan så redan testat och vet vad jag föredrar. Det var dock lite svårare att fixa
extensions till testerna samt Moq än vad det är för Visual Studio. Men google hjälpte mig. 
Den första programmerings utamningen kom när jag försökte att skapa ett sidoprojekt där jag gjorde en enkel kalkylator som många exemepel. Dock fick jag det inte att fungera då Moq krävde mer tillgång än den implicita Internal class som classes blir. 
Efter jag fått koll på moq och hur det funkar och lyckas lirka min hjärna kring vad det innebär att mocka upp en låtsas databas som egentligen struntar i vad funktionen gör egentligen så gick det superlätt och smidigt att skriva testerna.

Det känns som det flöt på mycket lättare efter man förstått Moq då det var lite koncepuellt och subjektivt att förstå vad det faktiskt innebär utan att ha ett bra konkret eller fysiskt exempel att jämföra med. 

Jag missförstod också först uppgiften eftersom jag inte förstod mocking och försökte istället göra en List av User i userManager för att kolla om metoderna i UserManager fungerade samt började lägga till och sköta användare i UserManager innan det till slut klickade.

I denna uppgiften använde jag mycket ChatGPT. Något jag inte gjort innan utan försökt hålla mig borta ifrån utan större anledning. Den hjälpte mycket med att förstå hur just mocking fungerar. 

Testerna känns bra och hoppas det kommer mer större uppgifter där det ingår lite testning eller testdriven utveckling även om det är svårt att exmaniera vilken ordning man skrev uppgifter / metoder i. 

Skall dock kommenteras att jag förtillfället skapat ett test per funktion men funderade om jag skulle delat upp det mer.
Exempelvis TestGetUser_ThatExists()
samt TestGetUser_ThatDoesNotExists()
Detta för att skapa mer klarhet i vad som går fel om något inte går igenom ett test men valde slutligen att ha ett test per metod denna gången då felmeddelandet ändå visar vart testet misslyckas.
Men kommer nog i framtiden på större projekt dela upp det mer för tydlighet och enkelhet. 
