using NtkCs9.Lib;
using NUnit.Framework;
using System.Text;

namespace NtkCs9.Tests
{
    public class GetEnumeratorExtensionMethodTests
    {
        [Test]
        public void ForeachSupportsGetEnumeratorExtensionMethod()
        {
            var stringBuilder = new StringBuilder("Sample");

            var count = 0;
            foreach (var c in stringBuilder)
            {
                count++;
            }

            Assert.That(count, Is.EqualTo(stringBuilder.Length));
        }
    }
}
