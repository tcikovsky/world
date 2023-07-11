public class Person {
    public int Age;
    public double FoodAmount;
    public bool RelationshipStatus = false;
    
    public Person Partner = null!;
    public List<Person> Kids = new List<Person>();
    public _Gender Gender;
    public enum _Gender {
        male,
        female
    }
    
    public Person(_Gender gender, int age = 0, double food = 0) {
        Age = age;
        FoodAmount = food;
        _Gender Gender = gender; 
    }
    
    public void MakeFood() {
        FoodAmount = FoodAmount + 1.3;
    }
    
    public void LookForPartner(List<Person> men, List<Person> women) {
        RelationshipStatus = false;

        if (Gender == _Gender.male) {men.Add(this);}
        if (Gender == _Gender.female) {women.Add(this);}
    }

    public void RegisterPartner(Person partner) {
        RelationshipStatus = true;
        Partner = partner;         
    }

    public static Person._Gender PickGender() {
        Random rnd = new Random();
        int num = rnd.Next(2);
        if (num < 0.5) {return Person._Gender.male;} 
        else {return Person._Gender.female;}
    }
}