namespace InterfaceVsAbstract
{
    public class Person : IPerson
    {
        private string _name;
        private DateTime _dateOfBirth;
        public Person(string name, DateTime dateOfBirth)
        {
            _name = name;
            _dateOfBirth = dateOfBirth;
        }

        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string DateOfBirth { get => throw new NotImplementedException(); }

        public void Run(float distance, float pace)
        {
            throw new NotImplementedException();
        }

        public void Eat(DateTime startTIme, DateTime endTime)
        {
            throw new NotImplementedException();
        }
    }
}
