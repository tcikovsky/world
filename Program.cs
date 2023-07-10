Console.WriteLine("Hello, World!");

double POPULATION_GROWTH_PER_ANNUM = 1.1;
int START_POPULATION = 2;

int amountOfFood = 0;
double population = START_POPULATION;
int maxPopulation = START_POPULATION;
List<Person> citizens = new List<Person>();

// THE LOOP OF LIFE
for (int year = 0; population <= maxPopulation; year++) {
	if (population == 2) {
		citizens.Add(new Person(Person._Gender.male, 18));
		citizens.Add(new Person(Person._Gender.female, 18));
	}
	
	for (int personNum = 0; personNum < population - citizens.Count; personNum++) {
		Person person = new Person(Person.PickGender(), 18);
		citizens.Add(person);
	}

	population = Math.Floor((double)START_POPULATION * (double)Math.Pow(POPULATION_GROWTH_PER_ANNUM, year));

	Console.WriteLine("YEAR: " + year.ToString() + ", POPULATION: " + population.ToString());
}