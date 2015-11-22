﻿namespace Croft.Core.Validation.Rules
{
    using System.Text.RegularExpressions;

    public class EmailValidationRule : ValidationRule
    {
        /// <summary>
        /// Gets the error message to display for the rule.
        /// </summary>
        public override string ErrorMessage => "Value is not a valid e-mail.";

        /// <summary>
        /// Validates an object value with this rule.
        /// </summary>
        /// <param name="value">
        /// The value to validate.
        /// </param>
        /// <returns>
        /// Returns a boolean value indicating whether the object was validated with the rule.
        /// </returns>
        public override bool IsValid(object value)
        {
            if (value == null)
            {
                return false;
            }

            var val = value.ToString();
            if (string.IsNullOrWhiteSpace(val))
            {
                return true;
            }

            const string EmailPattern =
                @"^([0-9a-zA-Z](?>[-.+\w]*[0-9a-zA-Z])*@(?>[0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$";

            var regex = new Regex(EmailPattern, RegexOptions.IgnoreCase);
            return regex.IsMatch(val);
        }
    }
}