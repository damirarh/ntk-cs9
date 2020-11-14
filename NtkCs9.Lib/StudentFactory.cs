namespace NtkCs9.Lib
{
    public class StudentFactory : PersonFactory
    {
        public override StudentRecordImmutable Create(string firstName, string lastName)
        {
            return new() { FirstName = firstName, LastName = lastName };
        }
    }
}
