using System;
using System.Globalization;
using System.Windows.Controls;

namespace DataApplication
{

    public class StringRangeValidationRule : ValidationRule
    {
        private int minimumLength = -1;
        private int maximumLength = -1;
        private string errorMessage;

        public int MinimumLength
        {
            get { return minimumLength; }
            set { minimumLength = value; }
        }

        public int MaximumLength
        {
            get { return maximumLength; }
            set { maximumLength = value; }
        }

        public string ErrorMessage
        {
            get { return errorMessage; }
            set { errorMessage = value; }
        }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string inputString = (value ?? string.Empty).ToString();
            if (inputString.Length < MinimumLength || (MaximumLength > 0 && inputString.Length > MaximumLength))
                return new ValidationResult(false, this.ErrorMessage);
            return new ValidationResult(true, null);
        }
    }

}
