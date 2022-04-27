using Core.Dtos;
using FluentValidation.TestHelper;
using NUnit.Framework;

namespace Core.UnitTests
{
    [TestFixture]
    public class RegistrationTests
    {
        private RegistrationDetailValidator _validator;

        [SetUp]
        public void Setup()
        {
            _validator = new RegistrationDetailValidator();
        }

        [TestCase("", "")]
        [TestCase("", "Smith")]
        public void WhenFirstNameIsEmpty_ReturnFalse(string firstName, string surname)
        {
            const string validEmailAddress = "test@test.com";
            const string validPolicyReferenceNumber = "XX-999999";

            var model = new RegistrationDetailDto
            {
                FirstName = firstName,
                Surname = surname,
                DOB = System.DateTime.MinValue,
                Email = validEmailAddress,
                PolicyReferenceNumber = validPolicyReferenceNumber
            };

            var result = _validator.TestValidate(model);

            result.ShouldHaveValidationErrorFor(customer => customer.FirstName);
        }

        [TestCase("", "")]
        [TestCase("John", "")]
        public void WhenSurnameIsEmpty_ReturnFalse(string firstName, string surname)
        {
            const string validEmailAddress = "test@test.com";
            const string validPolicyReferenceNumber = "XX-999999";

            var model = new RegistrationDetailDto
            {
                FirstName = firstName,
                Surname = surname,
                DOB = System.DateTime.MinValue,
                Email = validEmailAddress,
                PolicyReferenceNumber = validPolicyReferenceNumber
            };

            var result = _validator.TestValidate(model);

            result.ShouldHaveValidationErrorFor(customer => customer.Surname);
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

        [TestCase("XX-999999")]
        public void WhenReferenceNumberIsValid_ReturnTrue(string policyReferenceNumber)
        {
            const string validEmailAddress = "test@test.com";

            var model = new RegistrationDetailDto
            {
                FirstName = "John",
                Surname = "Smith",
                DOB = System.DateTime.MinValue,
                Email = validEmailAddress,
                PolicyReferenceNumber = policyReferenceNumber
            };

            var result = _validator.TestValidate(model);

            result.ShouldNotHaveValidationErrorFor(customer => customer.PolicyReferenceNumber);
        }

        [TestCase("xx-99999")]
        [TestCase("xx-999999")]
        [TestCase("XX-99s999")]
        [TestCase("XX-9999999")]
        [TestCase("XX9999999")]
        [TestCase("99-999999")]
        [TestCase("")]
        public void WhenReferenceNumberIsInvalid_ReturnFalse(string policyReferenceNumber)
        {
            const string validEmailAddress = "test@test.com";

            var model = new RegistrationDetailDto
            {
                FirstName = "John",
                Surname = "Smith",
                DOB = System.DateTime.MinValue,
                Email = validEmailAddress,
                PolicyReferenceNumber = policyReferenceNumber
            };

            var result = _validator.TestValidate(model);

            result.ShouldHaveValidationErrorFor(customer => customer.PolicyReferenceNumber);
        }

        [Test]
        [TestCase(2020, 1, 1)]
        public void WhenAgeIsLessThan18_ReturnFalse(int year, int month, int day)
        {
            const string validEmailAddress = "test@test.com";
            const string validPolicyReferenceNumber = "XX-999999";

            var model = new RegistrationDetailDto
            {
                FirstName = "John",
                Surname = "Smith",
                DOB = new System.DateTime(year, month, day),
                Email = validEmailAddress,
                PolicyReferenceNumber = validPolicyReferenceNumber
            };

            var result = _validator.TestValidate(model);

            result.ShouldHaveValidationErrorFor(customer => customer.DOB);
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