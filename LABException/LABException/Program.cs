namespace LABException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Circle r1 = new Circle(3);
                Console.WriteLine(r1.ToString());

            }
            catch(Exception ex) 
            {
                Console.WriteLine($"{ex.Message}");
            }
            try
            {
                Circle r2 = new Circle(-2);
                Console.WriteLine(r2.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            try
            {
                Circle r3 = new Circle(0);
                Console.WriteLine(r3.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
        }
    }
}
