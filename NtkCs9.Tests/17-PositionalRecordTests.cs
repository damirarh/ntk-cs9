using NtkCs9.Lib;
using NUnit.Framework;

namespace NtkCs9.Tests
{
    public class PositionalRecordTests
    {
        [Test]
        public void PositionalRecordHasConstructor()
        {
            var person = new PersonPositionalRecord("Damir", "Arh");

            Assert.That(person.FirstName, Is.EqualTo("Damir"));
            Assert.That(person.LastName, Is.EqualTo("Arh"));
        }

        [Test]
        public void PositionalRecordHasInitOnlyProperties()
        {
            var person = new PersonPositionalRecord(string.Empty, string.Empty)
            {
                FirstName = "Damir",
                LastName = "Arh"
            };

            // doesn't compile
            //person.FirstName = "Damjan";

            Assert.That(person.FirstName, Is.EqualTo("Damir"));
            Assert.That(person.LastName, Is.EqualTo("Arh"));
        }

        [Test]
        public void PositionalRecordHasDeconstructor()
        {
            var person = new PersonPositionalRecord("Damir", "Arh");

            var (firstName, lastName) = person;

            Assert.That(firstName, Is.EqualTo("Damir"));
            Assert.That(lastName, Is.EqualTo("Arh"));
        }
    }
}
