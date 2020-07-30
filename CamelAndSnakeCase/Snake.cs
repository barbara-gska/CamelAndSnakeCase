using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamelAndSnakeCase
{
    public static class Snake
    {
        public static string ToSnakeCase(string camel)
        {
            var result = "";

            foreach (var letter in camel)
            {
                if (char.IsUpper(letter))
                    result += "_" + char.ToLower(letter);
                else
                    result += letter;
            }

            return result;
        }
    }
}
