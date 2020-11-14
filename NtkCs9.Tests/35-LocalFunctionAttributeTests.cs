using NUnit.Framework;
using System;
using System.Diagnostics.CodeAnalysis;

namespace NtkCs9.Tests
{
    public class LocalFunctionAttributeTests
    {
        [Test]
        public void NullableAnnotationAttributeOnLocalFunction()
        {
            [return: MaybeNull]
            string getString(string? input)
            {
                return input;
            }

            var result = getString(null);
            Assert.That(() =>
            {
                var length = result.Length;
            }, Throws.InstanceOf<NullReferenceException>());
        }
    }
}
