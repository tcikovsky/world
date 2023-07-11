Console.WriteLine("Hello, World!");

double POPULATION_GROWTH_PER_ANNUM = 1.1;
int START_POPULATION = 2;
double population = START_POPULATION;
List<Person> citizens = new List<Person>();

double amountOfFood;

List<Person> bachelors = new List<Person>();
List<Person> bachelorettes = new List<Person>();
List<Relationship> relationships = new List<Relationship>();


// THE LOOP OF LIFE
for (int year = 0; population <= 1000; year++) {
	
	amountOfFood = 0;
	foreach (Person citizen in citizens) {
		//* ADD FOOD
		amountOfFood = amountOfFood + citizen.FoodAmount;
		if (citizen.Age >= 18) {
			citizen.MakeFood();
		}

		//* REGISTER BACHELORS 
		if (citizen.RelationshipStatus == false && citizen.Age >= 18) {
			citizen.LookForPartner(bachelors, bachelorettes);
		}
	}
	
	//* MAKE COUPLES
	int min = Math.Min(bachelors.Count, bachelorettes.Count);
	for (int i = 0; i < min; i++) {
		bachelors[i].RegisterPartner(bachelorettes[i]);
		bachelorettes[i].RegisterPartner(bachelors[i]);
		relationships.Add(new Relationship(bachelors[i], bachelorettes[i]));
	}
	
	//* ADD CITIZENS
	if (population == 2) {
		citizens.Add(new Person(Person._Gender.male, 18));
		citizens.Add(new Person(Person._Gender.female, 18));
	}
	foreach (Relationship couple in relationships) {
		if (couple.isPregnant == true) {couple.giveBirth();}
		if (couple.togetherFoodAmount >= 9 && couple.isPregnant == false) {couple.getPregnant();}
	}
	
	

	population = Math.Floor((double)START_POPULATION * (double)Math.Pow(POPULATION_GROWTH_PER_ANNUM, year));

	Console.WriteLine("YEAR: " + year.ToString() + ", POPULATION: " + population.ToString());
}