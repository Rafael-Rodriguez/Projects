using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ProgrammingTest
{
    public class Solution
    {
        public const int ERROR_NO_VALID_SUBSTRING_FOUND = -1;
        public int solution(string s)
        {
            if(!ContainsAtLeastOneUpperCaseCharacter(s))
            {
                return ERROR_NO_VALID_SUBSTRING_FOUND;
            }

            var substrings = FindValidSubstrings(s);

            var maxSubstringLength = FindMaxSubstringLength(substrings);

            return maxSubstringLength;
        }

        private int FindMaxSubstringLength(IEnumerable<string> substrings)
        {
            if(substrings.Count() == 0)
            {
                return ERROR_NO_VALID_SUBSTRING_FOUND;
            }

            return substrings
                .Select(subString => subString.Length)
                .Max();
        }

        private IEnumerable<string> FindValidSubstrings(string s)
        {
            string[] nonNumericSubStrings = Regex.Split(s, @"\d");

            var substrings = GetAllUppercaseSubStrings(nonNumericSubStrings);
            
            return substrings;
        }

        private IEnumerable<string> GetAllUppercaseSubStrings(string[] nonNumericSubStrings)
        {
            return nonNumericSubStrings.Where(
                    substring => !string.IsNullOrEmpty(substring) &&
                    char.IsUpper(substring[0])).ToList();
        }

        private bool ContainsAtLeastOneUpperCaseCharacter(string s)
        {
            if(s.Any(c => char.IsUpper(c)))
            {
                return true;
            }

            return false;
        }
    }
}
