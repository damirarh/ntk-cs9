using NtkCs9.Lib;
using NUnit.Framework;

namespace NtkCs9.Tests
{
    public class RecordWithExpressionTests
    {
        [Test]
        public void WithExpressionMutatesSelectedProperties()
        {
            var person = new PersonRecordImmutable
            {
                FirstName = "Damir",
                LastName = "Arh",
            };

            var newPerson = person with { FirstName = "Damjan" };

            Assert.That(person.FirstName, Is.Not.EqualTo(newPerson.FirstName));
            Assert.That(person.LastName, Is.EqualTo(newPerson.LastName));
        }
    }
}
