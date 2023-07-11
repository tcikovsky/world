public class Relationship {
    public Person Man;
    public Person Woman;
    public List<Person> Kids = new List<Person>();
    public double togetherFoodAmount;
    public bool isPregnant = false;
    
    public Relationship(Person man, Person woman, List<Person> kids=null!) {
        Man = man;
        Woman = woman;
        Kids = kids;
        togetherFoodAmount = Man.FoodAmount + Woman.FoodAmount;
    }
    
    public void CalculateFood() { togetherFoodAmount = Man.FoodAmount + Woman.FoodAmount; }
    
    public void getPregnant() { isPregnant = true; }
    
    public void giveBirth() {
        isPregnant = false;
        Kids.Add(new Person(Person.PickGender()));
        //TODO: WORK OUT HOW FOOD WORKS WITH KIDS
    }
}