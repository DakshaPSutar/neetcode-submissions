public class Solution {
    public bool hasDuplicate(int[] nums) {
        /*
        bool isDuplicate = false;
        //nums.Distinct();
        for(int i=0; i<nums.Length; i++){
            for(int j=i; j<nums.Length; j++){
                if(i != j && nums[i] == nums[j]){
                    isDuplicate = true; 
                    break;
                }
            }
        }
        return isDuplicate;
        */

        Array.Sort(nums);
        for(int i=1; i<nums.Length; i++){
            if(nums[i] == nums[i-1]){
                return true;
            }
        }
        return false;
    }
}