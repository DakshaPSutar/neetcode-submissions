public class Solution {
    public bool IsAnagram(string s, string t) {
        char[] sArray = s.ToLower().ToCharArray();
        char[] tArray = t.ToLower().ToCharArray();

        Array.Sort(sArray);
        Array.Sort(tArray);

        if (sArray.SequenceEqual(tArray))
            return true; 
        return false;
    }
}
