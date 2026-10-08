public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] result  = new int[nums.Length];
        int allProduct = 1 ;
        int zeroCnt = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] == 0){
                zeroCnt++;
            }
            else{
                allProduct = allProduct * nums[i];
            }
        } 

        for(int i = 0; i < nums.Length; i++){
            if(zeroCnt >= 2){
                return new int[nums.Length];
            }
            else if(zeroCnt == 1){
                result[i] = nums[i] == 0 ? allProduct : 0;
            }
            else
                result[i] = allProduct / nums[i];
        }

        return result;
    }
}
