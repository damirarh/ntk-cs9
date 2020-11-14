using NtkCs9.Lib;
using NUnit.Framework;

namespace NtkCs9.Tests
{ 
    public class InitOnlyTests
    {
        [Test]
        public void CantMutateClassWithReadOnlyProperties()
        {
            var person = new PersonImmutable("Damir", "Arh");

            // doesn't compile
            // person.FirstName = "Damjan";
        }

        [Test]
        public void InitializersMakeClassMutable()
        {
            var person = new PersonMutable
            {
                FirstName = "Damir",
                LastName = "Arh",
            };

            person.FirstName = "Damjan";
        }

        [Test]
        public void InitOnlyPropertiesAllowImmutableClassWithInitializer()
        {
            var person = new PersonInitOnly
            {
                FirstName = "Damir",
                LastName = "Arh",
            };

            // doesn't compile
            // person.FirstName = "Damjan";
        }

    }
}