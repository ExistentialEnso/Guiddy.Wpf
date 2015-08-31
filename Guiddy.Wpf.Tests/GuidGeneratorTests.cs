using System;
using NUnit.Framework;

namespace Guiddy.Wpf.Tests
{
    [TestFixture]
    public class GuidGeneratorTests
    {
        [Test]
        public void If_Uppercase_True_Then_Result_Should_Be_All_Uppercase()
        {
            var hyphenated = GuidGenerator.Generate(true, true);
            var nonHyphenated = GuidGenerator.Generate(false, true);

            Assert.AreEqual(hyphenated, hyphenated.ToUpper());
            Assert.AreEqual(nonHyphenated, nonHyphenated.ToUpper());
        }

        [Test]
        public void If_Uppercase_False_Then_Result_Should_Be_All_Lowercase()
        {
            var hyphenated = GuidGenerator.Generate(true, false);
            var nonHyphenated = GuidGenerator.Generate(false, false);

            Assert.AreEqual(hyphenated, hyphenated.ToLower());
            Assert.AreEqual(nonHyphenated, nonHyphenated.ToLower());
        }

        [Test]
        public void If_Hyphens_False_Then_Result_Should_Not_Contain_Hyphens()
        {
            var uppercase = GuidGenerator.Generate(false, true);
            var lowercase = GuidGenerator.Generate(false, false);

            Assert.AreEqual(uppercase, uppercase.Replace("-", ""));
            Assert.AreEqual(lowercase, lowercase.Replace("-", ""));
        }

        [Test]
        public void If_Hyphens_True_Then_Result_Should_Contain_Hyphens()
        {
            var uppercase = GuidGenerator.Generate(true, true);
            var lowercase = GuidGenerator.Generate(true, false);

            Assert.AreNotEqual(uppercase, uppercase.Replace("-", ""));
            Assert.AreNotEqual(lowercase, lowercase.Replace("-", ""));
        }
    }
}
