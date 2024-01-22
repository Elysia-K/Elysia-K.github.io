using System;
using System.Diagnostics;

namespace Module1Lab
{
    public class Relationship
    {
        public RelationshipType RelationType { get; set; }


        public enum RelationshipType
        {
            Sister, Brother, Mather, Father
        }



        public void ShowRelationShip(Person personA, Person personB)
        {
            string hood = "";

            switch (this.RelationType)
            {
                case RelationshipType.Sister:
                    hood = "Sisterhood";
                    break;
                case RelationshipType.Brother:
                    hood = "Brotherhood";
                    break;
            }
            Console.WriteLine($"Relationship between {personA.FirstName} and {personB.FirstName} is: {hood}");
            
        }
    }
}