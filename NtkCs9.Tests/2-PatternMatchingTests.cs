using NtkCs9.Lib;
using NUnit.Framework;
using System;

namespace NtkCs9.Tests
{
    public class PatternMatchingTests
    {
        [Test]
        public void RelationalPatternsInSwitch()
        {
            var duration = TimeSpan.FromMinutes(60);

            var unit = duration.TotalMinutes switch
            {
                < 1 => "seconds",
                < 60 => "minutes",
                < 24 * 60 => "hours",
                _ => "days"
            };

            Assert.That(unit, Is.EqualTo("hours"));
        }

        [Test]
        public void LogicalAndRelationPatternInExpression()
        {
            var duration = TimeSpan.FromMinutes(30);

            var areMinutes = duration.TotalMinutes is >= 1 and < 60;

            Assert.That(areMinutes, Is.True);
        }

        [TestCase(null, true)]
        [TestCase("", true)]
        [TestCase("non-empty", false)]
        public void LogicalPatternWithParenthesesInIf(string input, bool result)
        {
            var nullOrEmpty = true;

            if (input is not (null or ""))
            {
                nullOrEmpty = false;
            }

            Assert.That(nullOrEmpty, Is.EqualTo(result));
        }

        [TestCase(null, false)]
        [TestCase("", false)]
        [TestCase("non-empty", true)]
        public void RelationalPropertyPattern(string input, bool result)
        {
            var nonEmpty = input is { Length: > 0 };

            Assert.That(nonEmpty, Is.EqualTo(result));
        }

        [Test]
        public void SimplifiedTypePatternInSwitch()
        {
            var person = new StudentRecordImmutable
            {
                FirstName = "Damir",
                LastName = "Arh",
            };

            var isStudent = person switch
            {
                StudentRecordImmutable => true,
                _ => false
            };

            Assert.That(isStudent, Is.True);
        }
    }
}
