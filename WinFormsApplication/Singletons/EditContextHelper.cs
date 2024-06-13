using System.Text.RegularExpressions;

namespace WinFormsApplication.Singletons
{
    public static class EditContextHelper
    {
        public static Func<bool> StringLength(Func<string> getter, int minLength, int maxLength)
        {
            return () => string.IsNullOrEmpty(getter()) == false && getter().Length > minLength && getter().Length < maxLength;
        }

        public static Func<bool> NumberCondition<T>(Func<T> getter, T min, T max) where T : IComparable
        {
            var value = getter();

            return () => value.CompareTo(min) >= 0 && value.CompareTo(max) <= 0;
        }

        public static Func<bool> NullableStringLengthCondition(Func<string> getter, int maxLength)
        {
            return () => string.IsNullOrEmpty(getter()) || getter().Length < maxLength;
        }

        private static Regex _emailRegex = new Regex("^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$", RegexOptions.Compiled);

        public static Func<bool> EmailCondition(Func<string> getter)
        {
            return () => _emailRegex.IsMatch(getter());
        }

        private static Regex _phoneRegex = new Regex("^[\\+]?[(]?[0-9]{3}[)]?[-\\s\\.]?[0-9]{3}[-\\s\\.]?[0-9]{4,6}$", RegexOptions.Compiled);

        public static Func<bool> PhoneCondition(Func<string> getter)
        {
            return () => _phoneRegex.IsMatch(getter());
        }
    }
}
