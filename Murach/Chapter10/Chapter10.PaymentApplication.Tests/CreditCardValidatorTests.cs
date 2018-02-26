using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Chapter10.PaymentApplication.Tests
{
    [TestClass]
    public class CreditCardValidatorTests
    {
        [TestMethod]
        public void ValidateNumber_EmptyString_ReturnFalse()
        {
            var validator = new CreditCardValidator();

            bool result = validator.ValidateNumber(string.Empty);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValidateNumber_DefaultCardNumber_ReturnFalse()
        {
            var validator = new CreditCardValidator();
            string DEFAULT_CARD_NUMBER = "XXXX-XXXX-XXXX-XXXX";

            bool result = validator.ValidateNumber(DEFAULT_CARD_NUMBER);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValidateNumber_AllDash_ReturnFalse()
        {
            var validator = new CreditCardValidator();

            bool result = validator.ValidateNumber("----------------");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValidatorNumber_NumberOfLength1_ReturnFalse()
        {
            var validator = new CreditCardValidator();

            bool result = validator.ValidateNumber("1");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValidatorNumber_NumberOfLength2_ReturnFalse()
        {
            var validator = new CreditCardValidator();

            bool result = validator.ValidateNumber("12");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValidatorNumber_NumberOfLength3_ReturnFalse()
        {
            var validator = new CreditCardValidator();

            bool result = validator.ValidateNumber("123");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValidatorNumber_NumberOfLength4_ReturnFalse()
        {
            var validator = new CreditCardValidator();

            bool result = validator.ValidateNumber("1234");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValidatorNumber_NumberOfLength5_ReturnFalse()
        {
            var validator = new CreditCardValidator();

            bool result = validator.ValidateNumber("1234-");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValidatorNumber_NumberOfLength6_ReturnFalse()
        {
            var validator = new CreditCardValidator();

            bool result = validator.ValidateNumber("1234-1");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValidatorNumber_NumberOfLength7_ReturnFalse()
        {
            var validator = new CreditCardValidator();

            bool result = validator.ValidateNumber("1234-12");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValidatorNumber_NumberOfLength8_ReturnFalse()
        {
            var validator = new CreditCardValidator();

            bool result = validator.ValidateNumber("1234-123");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValidatorNumber_NumberOfLength9_ReturnFalse()
        {
            var validator = new CreditCardValidator();

            bool result = validator.ValidateNumber("1234-1234");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValidatorNumber_NumberOfLength10_ReturnFalse()
        {
            var validator = new CreditCardValidator();

            bool result = validator.ValidateNumber("1234-1234-");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValidatorNumber_NumberOfLength11_ReturnFalse()
        {
            var validator = new CreditCardValidator();

            bool result = validator.ValidateNumber("1234-1234-1");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValidatorNumber_NumberOfLength12_ReturnFalse()
        {
            var validator = new CreditCardValidator();

            bool result = validator.ValidateNumber("1234-1234-12");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValidatorNumber_NumberOfLength13_ReturnFalse()
        {
            var validator = new CreditCardValidator();

            bool result = validator.ValidateNumber("1234-1234-123");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValidatorNumber_NumberOfLength14_ReturnFalse()
        {
            var validator = new CreditCardValidator();

            bool result = validator.ValidateNumber("1234-1234-1234");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValidatorNumber_NumberOfLength15_ReturnFalse()
        {
            var validator = new CreditCardValidator();

            bool result = validator.ValidateNumber("1234-1234-1234-");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValidatorNumber_NumberOfLength16_ReturnFalse()
        {
            var validator = new CreditCardValidator();

            bool result = validator.ValidateNumber("1234-1234-1234-");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValidatorNumber_NumberOfLength17_ReturnFalse()
        {
            var validator = new CreditCardValidator();

            bool result = validator.ValidateNumber("1234-1234-1234-1");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValidatorNumber_NumberOfLength18_ReturnFalse()
        {
            var validator = new CreditCardValidator();

            bool result = validator.ValidateNumber("1234-1234-1234-12");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValidatorNumber_NumberOfLength19_ReturnFalse()
        {
            var validator = new CreditCardValidator();

            bool result = validator.ValidateNumber("1234-1234-1234-123");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValidatorNumber_NumberOfLength20_ReturnTrue()
        {
            var validator = new CreditCardValidator();

            bool result = validator.ValidateNumber("1234-1234-1234-1234");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ValidatorNumber_NumberOfLength21_ReturnFalse()
        {
            var validator = new CreditCardValidator();

            bool result = validator.ValidateNumber("1234-1234-1234-1234-");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValidatorNumber_NumberOfLength22_ReturnFalse()
        {
            var validator = new CreditCardValidator();

            bool result = validator.ValidateNumber("1234-1234-1234-1234-1");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValidatorNumber_NumberOfLength30_ReturnFalse()
        {
            var validator = new CreditCardValidator();

            bool result = validator.ValidateNumber("1234-1234-1234-1234-1234-1234");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValidatorNumber_LettersInNumber_ReturnFalse()
        {
            var validator = new CreditCardValidator();

            bool result = validator.ValidateNumber("1234-12B5-128A-1D0f");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValidatorNumber_NoDashes_ReturnTrue()
        {
            var validator = new CreditCardValidator();

            bool result = validator.ValidateNumber("1234123412341234");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ValidatorNumber_NoDashesButSomeLettersInNumber_ReturnFalse()
        {
            var validator = new CreditCardValidator();

            bool result = validator.ValidateNumber("1234123a1fd52939");

            Assert.IsFalse(result);
        }
    }
}
