public class Solution {
    public bool IsPalindrome(int x) {
        char[] array = x.ToString().ToCharArray();
        Array.Reverse(array);
        string newArray = new string(array);
        return  newArray == x.ToString();
    }
}