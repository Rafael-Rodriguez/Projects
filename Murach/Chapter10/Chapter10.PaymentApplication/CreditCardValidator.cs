using System.Text.RegularExpressions;

namespace Chapter10.PaymentApplication
{
    public class CreditCardValidator : ICreditCardValidator
    {
        private const string DEFAULT_CARD_NUMBER = "XXXX-XXXX-XXXX-XXXX";
        private string _pattern;

        public CreditCardValidator()
        {
            _pattern = @"[0-9]{4}-[0-9]{4}-[0-9]{4}-[0-9]{4}";
        }

        public CreditCardValidator(string pattern)
        {
            _pattern = pattern;
        }

        public bool ValidateNumber(string text)
        {
            if (text == "" || text == DEFAULT_CARD_NUMBER)
            {
                return false;
            }

            Regex regex = new Regex(_pattern);
            bool validNumberFormat = regex.IsMatch(text);
            
            return validNumberFormat;
        }
    }
}
