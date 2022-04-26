using NUnit.Framework;

namespace Core.UnitTests
{
    [TestFixture]
    public class RegistrationTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void WhenFirstNameOrSurnameIsNotSupplied_ReturnFalse()
        {
            Assert.Fail();
        }

        [Test]
        public void WhenFirstNameOrSurnameIsNotBetween3and5Characters_ReturnFalse()
        {
            Assert.Fail();
        }

        [Test]
        public void WhenFirstNameOrSurnameIsBetween3and5Characters_ReturnTrue()
        {
            Assert.Fail();
        }

        [Test]
        public void WhenReferenceNumberIsValid_ReturnTrue()
        {
            Assert.Fail();
        }

        [Test]
        public void WhenReferenceNumberIsInvalid_ReturnFalse()
        {
            Assert.Fail();
        }

        [Test]
        public void WhenAgeIsLessThan18_ReturnFalse()
        {
            Assert.Fail();
        }

        [Test]
        public void WhenAgeIs18OrOver_ReturnTrue()
        {
            Assert.Fail();
        }

        [Test]
        public void WhenEmailAddressIsInvalid_ReturnFalse()
        {
            Assert.Fail();
        }

        [Test]
        public void WhenEmailAddressIsValid_ReturnFalse()
        {
            Assert.Fail();
        }

    }
}