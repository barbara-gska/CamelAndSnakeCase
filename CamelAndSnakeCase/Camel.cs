using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamelAndSnakeCase
{
    public static class Camel
    {
        public static string ToCamelCase(string snake)
        {
            var words = snake.Split('_');
            var result = "";

            foreach (var item in words)
            {
                if (item == words[0])
                    result += item;

                else
                    result += char.ToUpper(item[0]) + item.Substring(1);
            }

            return result;
        }
    }
}
