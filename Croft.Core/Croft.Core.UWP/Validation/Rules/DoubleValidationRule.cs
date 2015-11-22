﻿namespace Croft.Core.Validation.Rules
{
    public class DoubleValidationRule : ValidationRule
    {
        /// <summary>
        /// Gets the error message to display for the rule.
        /// </summary>
        public override string ErrorMessage => "Value is not a valid number.";

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

            double val;
            return double.TryParse(value.ToString(), out val);
        }
    }
}