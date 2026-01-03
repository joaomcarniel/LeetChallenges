public class DictionarySolution {
    public bool ContainsDuplicate(int[] nums) {
        Dictionary<int, int> dic = new();
        for(int i = 0; i < nums.Length; i++){
            if(dic.ContainsKey(nums[i])){
                return true;
            }
            dic.Add(nums[i], i);
        }
        return false;
    }
}

//Runtime: 8ms beats 91%
//Memory: 73.35 beats 51%



public class ListSolution {
    public bool ContainsDuplicate(int[] nums) {
        List<int> dic = new();
        for(int i = 0; i < nums.Length; i++){
            if(dic.Contains(nums[i])){
                return true;
            }
            dic.Add(nums[i]);
        }
        return false;
    }
}

//Runtime: 2524 beats 5%
//Memory: 58.30 beats 93%