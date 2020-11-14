using NtkCs9.Lib;
using NUnit.Framework;
using System.Collections.Generic;

namespace NtkCs9.Tests
{
    public class RecordsMutableDangersTests
    {
        [Test]
        public void MutatingRecordsBreakCollections()
        {
            var person = new PersonRecordMutable
            {
                FirstName = "Damir",
                LastName = "Arh",
            };

            var set = new HashSet<PersonRecordMutable>();
            set.Add(person);

            Assert.That(set.Contains(person), Is.True);

            person.FirstName = "Damjan";

            Assert.That(set.Contains(person), Is.False);
        }

        [Test]
        public void MutatingClassesWorkWithCollections()
        {
            var person = new PersonMutable
            {
                FirstName = "Damir",
                LastName = "Arh",
            };

            var set = new HashSet<PersonMutable>();
            set.Add(person);

            Assert.That(set.Contains(person), Is.True);

            person.FirstName = "Damjan";

            Assert.That(set.Contains(person), Is.True);
        }
    }
}
