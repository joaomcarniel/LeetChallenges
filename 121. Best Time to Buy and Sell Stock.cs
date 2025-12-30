public class Solution {
    public int MaxProfit(int[] prices) {
        int response = 0;
        int min = prices[0];
        for(int i = 0; i < prices.Length; i++){
            if(prices[i] < min){
                min = prices[i];
            }
            else{
                int dif = prices[i] - min;
                if(dif > response){
                    response = dif;
                }
            }
        }
        return response;
    }
}