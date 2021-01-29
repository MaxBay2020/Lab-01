using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question02__Extension_Method
{
    public static class StringBuilderExtension
    {
        /// <summary>
        /// extension method of StringBuilder: calculate the number of words in a sentence entered by a user
        /// </summary>
        /// <param name="input">the number of words in a sentence</param>
        /// <returns></returns>
        public static int WordsCounter(this StringBuilder input)
        {
            char[] chs = { ' ' };

            string[] wordsArr = input.ToString().Split(chs, options:StringSplitOptions.RemoveEmptyEntries);
            return wordsArr.Length;
        }
    }
}
