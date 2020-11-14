using NtkCs9.Lib;
using NUnit.Framework;

namespace NtkCs9.Tests
{
    public class RecordInheritanceTests
    {
        [Test]
        public void RuntimeTypeEquality()
        {
            PersonRecordImmutable person = new PersonRecordImmutable
            {
                FirstName = "Damir",
                LastName = "Arh",
            };

            PersonRecordImmutable student = new StudentRecordImmutable
            {
                FirstName = "Damir",
                LastName = "Arh",
            };

            Assert.That(person, Is.Not.EqualTo(student));
        }

        [Test]
        public void RuntimeTypeWithExpression()
        {
            PersonRecordImmutable student = new StudentRecordImmutable
            {
                FirstName = "Damir",
                LastName = "Arh",
            };

            var newStudent = student with { FirstName = "Damjan" };

            Assert.That(newStudent.GetType(), Is.EqualTo(typeof(StudentRecordImmutable)));
        }
    }
}
