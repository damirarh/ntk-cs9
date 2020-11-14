namespace NtkCs9.Lib
{
    public class PersonImmutable
    {
        public PersonImmutable(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; }
        public string LastName { get; }
    }
}
