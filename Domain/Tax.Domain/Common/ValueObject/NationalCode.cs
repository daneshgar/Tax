using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tax.Domain.Common.ValueObject
{
    public class NationalCode : IEquatable<NationalCode>
    {
        public string Value { get; private set; }

        private NationalCode() { } // For EF

        public NationalCode(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("National code cannot be empty", nameof(value));

            if (!IsValid(value))
                throw new ArgumentException("Invalid national code format", nameof(value));

            Value = value.Trim();
        }

        private static bool IsValid(string nationalCode)
        {
            // Persian national code validation logic
            if (nationalCode.Length != 10) return false;
            if (!long.TryParse(nationalCode, out _)) return false;

            // Check digit validation for Iranian national codes
            var checkSum = 0;
            for (var i = 0; i < 9; i++)
            {
                checkSum += int.Parse(nationalCode[i].ToString()) * (10 - i);
            }

            var remainder = checkSum % 11;
            var checkDigit = remainder < 2 ? remainder : 11 - remainder;

            return checkDigit == int.Parse(nationalCode[9].ToString());
        }

        public bool Equals(NationalCode other) => other?.Value == Value;
        public override bool Equals(object obj) => obj is NationalCode code && Equals(code);
        public override int GetHashCode() => Value?.GetHashCode() ?? 0;
        public override string ToString() => Value;

        public static implicit operator string(NationalCode code) => code?.Value;
        public static implicit operator NationalCode(string value) => new NationalCode(value);
    }
}
