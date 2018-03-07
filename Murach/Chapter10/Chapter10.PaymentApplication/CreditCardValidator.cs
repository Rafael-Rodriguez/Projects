using System.Text.RegularExpressions;

namespace Chapter10.PaymentApplication
{
    public class CreditCardValidator : ICreditCardValidator
    {
        private const string DEFAULT_CARD_NUMBER = "XXXX-XXXX-XXXX-XXXX";
        private const string PATTERN_DASH = @"\A[0-9]{4}-[0-9]{4}-[0-9]{4}-[0-9]{4}\Z";
        private const string PATTERN_NODASH = @"\A[0-9]{16}\Z";

        private string[] patterns;
        private string _currentPattern;

        public CreditCardValidator()
        {
            patterns = new string[] { PATTERN_DASH, PATTERN_NODASH };
            _currentPattern = patterns[0];
        }

        public CreditCardValidator(string pattern)
        {
            _currentPattern = pattern;
        }

        public bool ValidateNumber(string text)
        {
            if (text == "" || text == DEFAULT_CARD_NUMBER)
            {
                return false;
            }

            bool validNumberFormat = false;

            Regex regex = new Regex(_currentPattern);
            validNumberFormat = regex.IsMatch(text);
            
            if(validNumberFormat == false && patterns != null)
            {
                for(var patternIndex = 0; !validNumberFormat && patternIndex < patterns.Length; ++patternIndex)
                {
                    _currentPattern = patterns[patternIndex];

                    regex = new Regex(_currentPattern);

                    validNumberFormat = regex.IsMatch(text);
                }
            }


            return validNumberFormat;
        }
    }
}
