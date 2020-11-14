using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace NtkCs9.Lib
{
    public static class StringBuilderExtensions
    {
        public static IEnumerator<char> GetEnumerator(this StringBuilder stringBuilder)
        {
            return stringBuilder.ToString().GetEnumerator();
        }
    }
}
