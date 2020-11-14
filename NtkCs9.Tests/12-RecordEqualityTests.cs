using NtkCs9.Lib;
using NUnit.Framework;

namespace NtkCs9.Tests
{
    public class RecordEqualityTests
    {
        [Test]
        public void ClassesUseReferenceEquality()
        {
            var person1 = new PersonInitOnly
            {
                FirstName = "Damir",
                LastName = "Arh",
            };

            var person2 = new PersonInitOnly
            {
                FirstName = "Damir",
                LastName = "Arh",
            };

            Assert.That(person1, Is.Not.EqualTo(person2));
        }

        [Test]
        public void StructsUseValueEquality()
        {
            var person1 = new PersonStructImmutable
            {
                FirstName = "Damir",
                LastName = "Arh",
            };

            var person2 = new PersonStructImmutable
            {
                FirstName = "Damir",
                LastName = "Arh",
            };

            Assert.That(person1, Is.EqualTo(person2));
        }

        [Test]
        public void RecordsUseValueEquality()
        {
            var person1 = new PersonRecordImmutable
            {
                FirstName = "Damir",
                LastName = "Arh",
            };

            var person2 = new PersonRecordImmutable
            {
                FirstName = "Damir",
                LastName = "Arh",
            };

            Assert.That(person1, Is.EqualTo(person2));
        }
    }
}
