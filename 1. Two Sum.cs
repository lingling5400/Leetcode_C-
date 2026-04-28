// Solution 1
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        
        for(int i=0;i<nums.Length;i++){
            for(int j=i+1;j<nums.Length;j++){
                if(nums[i]+nums[j]==target){
                    return new int [] {i,j};
                }
            }
        }
        return new int[]{};
    }
}

// Solution 2
using System.Collections.Generic;

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary <int,int> dict= new Dictionary <int,int>();
        for(int i=0;i<nums.Length;i++){
            int other=target-nums[i];
            if(dict.ContainsKey(other)){
                return new int []{dict[other],i};
            }
            dict[nums[i]]=i;
        }
        return new int []{};
    }
}
