// Create a person
IPersonRepository rep1 = new PersonRepositoryRandom();
Person ps = rep1.GetPerson();
// Create a list of simple people
List<Person> lstps = rep1.GetPeople(100);