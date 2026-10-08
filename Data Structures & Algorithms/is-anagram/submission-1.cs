public class Solution {
    public bool IsAnagram(string s, string t) {

        if (s.Length == t.Length)
        {
            char[] sArray = s.ToCharArray();
            char[] tArray = t.ToCharArray();

            Array.Sort(sArray);
            Array.Sort(tArray);

            Console.WriteLine(sArray);
            Console.WriteLine(tArray);

            if (sArray.SequenceEqual(tArray))
                return true;
        } 
        return false;
    }
}
