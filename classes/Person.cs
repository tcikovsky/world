public class Person {
    public int Age;
    public int Food;
    public bool RelationshipStatus = false;
    public bool relationshipStatus;
    public List<Person> Kids = new List<Person>();
    public int numberOfKids;
    public enum _Gender {
        male,
        female
    }
    
    public Person(_Gender gender, int age = 0, int food = 0) {
        Age = age;
        Food = food;
        _Gender Gender = gender; 
    }
    public static Person._Gender PickGender() {
        Random rnd = new Random();
        int num = rnd.Next(2);
        if (num < 0.5) {return Person._Gender.male;} 
        else {return Person._Gender.female;}
    }
}