
using NtkCs9.Lib;
using NUnit.Framework;

namespace NtkCs9.Tests
{
    public class RecordReferenceTests
    {
        [Test]
        public void ClassesAreReferenceTypes()
        {
            var person = new PersonMutable
            {
                FirstName = "Damir",
                LastName = "Arh",
            };

            var personReference = person;
            personReference.FirstName = "Damjan";

            Assert.That(person.FirstName, Is.EqualTo(personReference.FirstName));
        }

        [Test]
        public void StructsAreValueTypes()
        {
            var person = new PersonStructMutable
            {
                FirstName = "Damir",
                LastName = "Arh",
            };

            var personCopy = person;
            personCopy.FirstName = "Damjan";

            Assert.That(person.FirstName, Is.Not.EqualTo(personCopy.FirstName));
        }

        [Test]
        public void RecordsAreReferenceTypes()
        {
            var person = new PersonRecordMutable
            {
                FirstName = "Damir",
                LastName = "Arh",
            };

            var personReference = person;
            personReference.FirstName = "Damjan";
            
            Assert.That(person.FirstName, Is.EqualTo(personReference.FirstName));
        }
    }
}
