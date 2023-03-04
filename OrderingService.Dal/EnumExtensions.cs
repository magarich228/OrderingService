using System.ComponentModel;
using System.Reflection;

namespace OrderingService.Dal
{
    public static class EnumExtensions
    {
        public static string? GetDescription<T>(this T enumerationValue)
        where T : struct
        {
            Type type = enumerationValue.GetType();
            if (!type.IsEnum)
            {
                throw new ArgumentException("EnumerationValue must be of Enum type", "enumerationValue");
            }

            var strValue = enumerationValue.ToString() ?? string.Empty;

            MemberInfo[] memberInfo = type.GetMember(strValue);
            if (memberInfo != null && memberInfo.Length > 0)
            {
                object[] attrs = memberInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);

                if (attrs != null && attrs.Length > 0)
                {
                    return ((DescriptionAttribute)attrs[0]).Description;
                }
            }

            return strValue;
        }
    }
}
