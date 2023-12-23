namespace InterfaceVsAbstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcom in InterfaceVsAbstract Demo");

            //*********** Interface ********
            //Rappel :
            //         * que de l'architecture, pas de comportement
            //         * on l'implémente, on ne l'hérite pas

            //Impossible d'instancier une interface
            //IPerson iperson = new IPerson(); //essayez de décommenter cette ligne ;)
            Person person = new Person("Jean-Paul", new DateTime());

            //Méthode imposée par l'interface, que nous avons due implémenter dans la classe person
            person.Run(5.5f, 10.00f);
            DateTime lunchStartTime = DateTime.Now;

            //Méthode spécifique qui ne fait pas partie de l'interface
            person.Eat(lunchStartTime, lunchStartTime.AddMinutes(30));

            //***********  Abstract ********
            //Rappel :
            //       * de l'architecture et aussi du comportement
            //       * on l'hérite

            //impossible d'instancier une classe abstraite 
            //Vehicle vehicle = new Vehicle();//essayez de décommenter cette ligne ;)
            Truck truck = new Truck();
            string branch = truck.Brand;//utilisation d'une méthode qui vient de la classe abstraite
            string model = truck.Model;
            truck.StartEngine();//appel à une méthode spécifique à Truck
            truck.StopEngine();//
        }
    }
}
