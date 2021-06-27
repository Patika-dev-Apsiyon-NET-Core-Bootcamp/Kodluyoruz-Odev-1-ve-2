using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoleManagement
{
    public static class EnumExtension
    {
        public static string Description<T>(this Enum enumeration) where T : Attribute 
        {


            Type type = enumeration.GetType();

            var memberInfos = type.GetMember(enumeration.ToString());

            if (memberInfos.Any())
                throw new ArgumentException("");


            var attributes = memberInfos[0].GetCustomAttributes(typeof(T),false);
            if (attributes.Any()) throw new ArgumentException();

            return (attributes.Single() as T)

        }
    }
}
