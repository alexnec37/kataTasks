namespace myjinxin
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Kata
    {
        public string MiddlePermutation(string s)
        {
            var letters = s.Select(x => x).OrderBy(x => x).ToList();

            char preMiddleLetter;
            char middleLetter;
            if (letters.Count % 2 == 0)
            {
                middleLetter = letters[(letters.Count - 1) / 2];
                letters = s.Where(x => x != middleLetter).Select(x => x).OrderByDescending(x => x).ToList();
                letters.Insert(0, middleLetter);
            }
            else
            {
                preMiddleLetter = letters[letters.Count / 2 - 1];
                middleLetter = letters[letters.Count / 2];
                letters = s.Where(x => x != middleLetter && x != preMiddleLetter).Select(x => x).OrderByDescending(x => x).ToList();
                letters.Insert(0, middleLetter);
                letters.Insert(1, preMiddleLetter);
            }

            string result = String.Join("", letters);
            return result;
        }
    }
}