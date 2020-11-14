using NtkCs9.Lib;
using NUnit.Framework;

namespace NtkCs9.Tests
{
    public class CovariantReturnValueTests
    {
        [Test]
        public void BaseClassMethodReturnsBaseType()
        {
            var factory = new PersonFactory();

            var person = factory.Create("Damir", "Arh");

            Assert.That(person.GetType(), Is.EqualTo(typeof(PersonRecordImmutable)));
        }

        [Test]
        public void DerivedClassMethodReturnsDerivedType()
        {
            var factory = new StudentFactory();

            var person = factory.Create("Damir", "Arh");

            Assert.That(person.GetType(), Is.EqualTo(typeof(StudentRecordImmutable)));
        }

        [Test]
        public void DerivedClassDoesntBreakPolymorphism()
        {
            PersonFactory factory = new StudentFactory();

            var person = factory.Create("Damir", "Arh");

            Assert.That(person.GetType(), Is.EqualTo(typeof(StudentRecordImmutable)));
        }
    }
}
