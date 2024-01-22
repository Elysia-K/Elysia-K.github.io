using System;
namespace Module1Lab
{
    public class Person
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FavoriteColour { get; set; }
        public int Age { get; set; }
        public bool IsWorking { get; set; }
        

        public Person(int personId, string firstName, string lastName, string favoriteColour, int age, bool isWorking)
        {
            this.PersonId = personId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FavoriteColour = favoriteColour;
            this.Age = age;
            this.IsWorking = isWorking;
        }

        public string DisplayPersonInfo()
        {

            return $"{PersonId}: {FirstName} {LastName}'s favorite colour is {FavoriteColour}" ;
        }

        public string ChangeFavoriteColour(string favoriteColour = "white")
        {
            string changeFavoriteColour = favoriteColour;
            return $"{PersonId}: {FirstName} {LastName}'s favorite colour is {favoriteColour}";
        }

        public void GetAgeInTenYears()
        {
            int getageinthenyears = this.Age + 10;
            Console.WriteLine($"{FirstName} {LastName}’s Age in 10 years is: {getageinthenyears}");

        }

        public override string ToString()
        {
            return $"PersonId: {this.PersonId}\n" +
                $"FirstName: {this.FirstName}\n" +
                $"LastName: {this.LastName}\n" +
                $"FavoriteColour: {this.FavoriteColour}\n" +
                $"Age: {this.Age}\n" +
                $"IsWorking: {this.IsWorking}";
        }


    }
}


