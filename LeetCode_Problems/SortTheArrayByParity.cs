// problem link
// https://leetcode.com/problems/sort-array-by-parity/description/


public class Solution {
    public int[] SortArrayByParity(int[] nums) {
        int n = nums.Length;
        int[] res = new int[n];
        int i = 0, j = n-1, k = 0;

        while(k < n){
            if(nums[k]%2 == 0){
                res[i] = nums[k];
                i++;
            }else{
                res[j] = nums[k];
                j--;
            }
            k++;
        }

        return res;
    }
}