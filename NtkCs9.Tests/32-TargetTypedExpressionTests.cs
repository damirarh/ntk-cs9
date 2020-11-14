using NtkCs9.Lib;
using NUnit.Framework;
using System.Collections.Generic;

namespace NtkCs9.Tests
{
    public class TargetTypedExpressionTests
    {
        [Test]
        public void TargetTypedNewAssignment()
        {
            PersonPositionalRecord person = new("Damir", "Arh");

            Assert.That(person.GetType(), Is.EqualTo(typeof(PersonPositionalRecord)));
        }

        [Test]
        public void TargetTypedCollectionInitializer()
        {
            List<PersonPositionalRecord> persons = new() { new("John", "Doe"), new("Jane", "Doe") };

            Assert.That(persons.Count, Is.EqualTo(2));
        }

        [Test]
        public void TargetTypedArguments()
        {
            var person = new PersonPositionalRecord(new('a', 5), new('b', 3));

            Assert.That(person.FirstName, Is.EqualTo("aaaaa"));
            Assert.That(person.LastName, Is.EqualTo("bbb"));
        }

        [Test]
        public void TargetTypedReturnValue()
        {
            static PersonPositionalRecord getPerson()
            {
                return new("Damir", "Arh");
            }

            var person = getPerson();

            Assert.That(person.GetType(), Is.EqualTo(typeof(PersonPositionalRecord)));
        }

        [Test]
        public void TargetTypedConditionalExpression()
        {
            var input = string.Empty;

            int? length = string.IsNullOrEmpty(input) ? null : input.Length;

            Assert.That(length, Is.Null);
        }
    }
}
