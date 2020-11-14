using NtkCs9.Lib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NtkCs9.Tests
{
    public class LambdaTests
    {
        [Test]
        public void StaticLambda()
        {
            List<PersonPositionalRecord> persons = new() { new("John", "Doe"), new("Jane", "Doe") };

            var sorted = persons
                .OrderBy(static person => person.FirstName)
                .ToList();

            Assert.That(sorted[0].FirstName, Is.EqualTo("Jane"));
        }

        [Test]
        public void LambdaDiscards()
        {
            int[] numbers = Enumerable.Range(0, 10).ToArray();

            var rnd = new Random();
            var someNumbers = numbers.Where((_, _) => rnd.NextDouble() < 0.5).ToArray();

            Assert.That(someNumbers.Length, Is.LessThanOrEqualTo(10));
        }
    }
}
