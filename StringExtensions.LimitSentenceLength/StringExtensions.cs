using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExtensions.LimitSentenceLength
{
    public static class StringExtensions
    {
        /// <summary>
        /// String extension method to limit the paragraph nicely, without chopping off the words
        /// </summary>
        /// <param name="paragraph">this paragraph</param>
        /// <param name="maximumLenght">maximum length</param>
        /// <returns></returns>
        public static string LimitSentenceLength(this string paragraph, int maximumLenght)
        {
            //null check
            if (paragraph == null) return null;

            //less than maximum length, return as it is
            if (paragraph.Length <= maximumLenght) return paragraph;

            //split the paragraph into indvidual words
            string[] words = paragraph.Split(' ');
            //initialize return variable
            string paragraphToReturn = string.Empty;

            //construct the return word 
            foreach (string word in words)
            {
                //check if adding 3 to current length and next word is more than maximum length. Constant 3 is for "..." at the end
                if ((paragraphToReturn.Length + word.Length + 3) > maximumLenght)
                {
                    //append "..."
                    paragraphToReturn = paragraphToReturn.Trim() + "...";
                    //exit foreach loop
                    break;
                }
                //add next word and continue
                paragraphToReturn += word + " ";
            }
            return paragraphToReturn;
        }


    }
}

