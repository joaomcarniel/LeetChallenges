public class Solution {
    public bool IsValid(string s) {
        Stack<char> pile = new();
        for(int i = 0; i < s.Length; i++){
            if(IsOpeningPair(s[i]))
            {
                pile.Push(s[i]);
                continue;
            }
            if(pile.Count == 0 || !isMatchingPair(pile.Pop(), s[i])){
                return false;
            }
        }
        return pile.Count == 0;
    }

    private bool isMatchingPair(char openingBracket, char closingBracket) {
        return (openingBracket == '(' && closingBracket == ')') || 
               (openingBracket == '{' && closingBracket == '}') || 
               (openingBracket == '[' && closingBracket == ']');
    }

    private bool IsOpeningPair(char bracket){
        return bracket == '(' || bracket == '[' || bracket == '{';
    }
}