public class Solution {
    public IList<string> response = new List<string>();
    public IList<string> GenerateParenthesis(int n) {
        if(n == 0 || n < 0) return new List<string>();
        if(n == 1) return new List<string>(){"()"};
        Backtracking(0, 0, n, new StringBuilder());
        return response;
    }

    public void Backtracking(int open, int close, int n, StringBuilder answer)
    {
        if(answer.Length == 2*n){
            response.Add(answer.ToString());
            answer.Append("");
            return;
        }
        if(open < n){
            answer.Append("(");
            Backtracking(open+1, close, n, answer);
            answer.Remove(answer.Length - 1, 1);
        }
        if(close < open){
            answer.Append(")");
            Backtracking(open, close+1, n, answer);
            answer.Remove(answer.Length - 1, 1);
        }
    }
}