namespace NtkCs9.Lib
{
    public class PersonFactory
    {
        public virtual PersonRecordImmutable Create(string firstName, string lastName)
        {
            return new() { FirstName = firstName, LastName = lastName };
        }
    }
}
