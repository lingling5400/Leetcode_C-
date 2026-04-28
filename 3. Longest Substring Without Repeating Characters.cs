using System.Collections.Generic;
public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int left=0;
        int ans=0;
        HashSet <char> seen=new HashSet <char>();

        for(int right=0 ; right < s.Length ; right++){
            while (seen.Contains(s[right])) {
                seen.Remove(s[left]);
                left++;
            }
            seen.Add(s[right]);
            ans=Math.Max(ans,right-left+1);
        }
        return ans;
    }
}
