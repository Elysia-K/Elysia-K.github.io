namespace Module1Lab;

class Program
{
    static void Main(string[] args)
    {
        //Create Main class
        Person person1 = new Person(1, "Ian", "Brooks", "Red", 30, true);
        Person person2 = new Person(2, "Gina", "James", "Green", 18, false);
        Person person3 = new Person(3, "Mike", "Briscoe", "Blue", 45, true);
        Person person4 = new Person(4, "Mary", "Beals", "Yellow", 28, true);

        //Display Gina's info
        Console.WriteLine(person2.DisplayPersonInfo());

        //Display all of Mike's info as a list
        Console.WriteLine(person3);

        //Change Ian's Favorite Colour and print his info
        Console.WriteLine(person1.ChangeFavoriteColour());

        //Display Mary's age after ten years
        person4.GetAgeInTenYears();

        //Add all the person object to a list
        List<Person> peopleList = new List<Person>
        {
            person1,
            person2,
            person3,
            person4
        };

        Relationship Sister = new()
        {
            RelationType = Relationship.RelationshipType.Sister
        };

        Sister.ShowRelationShip(person2, person4);

        Relationship Brother = new()
        {
            RelationType = Relationship.RelationshipType.Brother
        };

        Brother.ShowRelationShip(person1, person3);

        //calculate average age
        double averageAge = peopleList.Average(person => person.Age);

        //Display average age
        Console.WriteLine($"Average age is: {averageAge}");

        //find and display youngest person
        string youngPerson = peopleList.OrderBy(person => person.Age).First().FirstName;
        Console.WriteLine($"The youngest person is: {youngPerson}");

        //find and display oldest person
        string oldPerson = peopleList.OrderByDescending(person => person.Age).First().FirstName;
        Console.WriteLine($"The oldest person is: {oldPerson}");

        //find and display the person name start with M
        var nameM = new List<Person> { person1, person2, person3, person4 }
            .Where(person => person.FirstName.StartsWith("M")).ToList();

        if (nameM.Count == 0)
        {
            Console.WriteLine("Cannot find the person name start with M");
        }
        else
        {
            foreach (var personM in nameM)
            {
                Console.WriteLine(personM.ToString());
            }
        }

        //find and display the person likes Blue
        var favColourBlue = new List<Person> { person1, person2, person3, person4 }
            .Where(person => person.FavoriteColour.Contains("Blue")).ToList();

        if (favColourBlue.Count == 0)
        {
            Console.WriteLine("Cannot Find the person likes Blue");
        }
        else
        {
            foreach (var favorBlue in favColourBlue)
            {
                Console.WriteLine(favorBlue.ToString());
            }
        }


    }
}