using System;

public static class Anagrams
{
    public static bool IsAnagram(string word1, string word2)
    {
        if (word1.Length != word2.Length)
        {
            return false;
        }

        char[] chars1 = word1.ToCharArray();
        char[] chars2 = word2.ToCharArray();

        Array.Sort(chars1);
        Array.Sort(chars2);

        for (int i = 0; i < chars1.Length; i++)
        {
            if (chars1[i] != chars2[i])
            {
                return false;
            }
        }

        return true;
    }
}
