public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;

        Dictionary<char, int> dictionary = new();

        for (int i = 0; i < s.Length; i++) {
            dictionary.TryGetValue(s[i], out int count);
            dictionary[s[i]] = count + 1;
        }

        for (int i = 0; i < t.Length; i++) {
            if (!dictionary.TryGetValue(t[i], out int count) || count == 0)
                return false;

            dictionary[t[i]] = count - 1;
        }

        return true;
    }
}