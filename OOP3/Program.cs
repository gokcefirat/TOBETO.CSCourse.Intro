
using OOP3;

IKrediManager ihtiyacKrediManager =new IhtiyacKrediManager();

//tasit-konut yada ihtiyac kredi manager demek yerine IKrediManager de veriyi getirir.

TasitKrediManager tasitKrediManager = new TasitKrediManager();

KonutKrediManager konutKrediManager = new KonutKrediManager();

ILoggerService databaseLoggerService = new DatabaseLoggerService();
ILoggerService fileLoggerService = new FileLoggerService();



BasvuruManager basvuruManager= new BasvuruManager();
basvuruManager.BasvuruYap(ihtiyacKrediManager, new DatabaseLoggerService());

List <IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager};

//basvuruManager.KrediOnBilgilendirmesiYap(krediler);