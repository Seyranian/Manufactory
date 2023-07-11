using Manufactory;

Programmer p1 = new Programmer() { name = "Narek", age = 17, id = 2, phoneNumber = "12", email = "gmail", gender = 0, salary = 1000,position = "Programmer",section = new ItSection() { programmingLevel = ProgrammingLevel.junior} };
Director d1 = new Director() { name = "Andranik", age = 25, id = 1, phoneNumber = "45", email = "email", gender = 0, salary = 5000, position = "Director" };
Factory factory = new Factory(d1,p1);
HardWorker h1 = new HardWorker() { name = "Suren", age = 33, id = 3, phoneNumber = "55", email = "gmail", gender = 0, salary = 500, position = "Labor", section = new HardWorkerSection() { kindOfHardWork = KindsOfHardWork.pianoThrower } };
factory.AddNewEmployee(h1);
factory.GetEmploees();
