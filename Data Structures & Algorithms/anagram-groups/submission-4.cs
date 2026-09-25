public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        
        
        /*
        What does each answer have in common? They're anagrams
        Same letters, same length

        Brute force method:

        - Read the first word, check all other values if they match the first word.
        - Store them into a list
        - Append them to the output list
        - Return

        Why is this not efficient?
        Time complexity: O(N^2) We have to loop through the array again for each word at worst
        if none of them are anagrams.

        What would be a better way?
        First need to recognize the vulnerability -> The fact that we have to check each one at a time.

        Is it possible if we read the information beforehand and observe a second time.
        This would bring it to O(2N) ideally.

        What if we pre-analyzed all possible anagrams.
        Then on the second loop, if they fall into that category, drop in to that list.

        How would we do this?

        Requirements: 
            - We need to break down what an anagram is into code
            - We need to break down how to store that data
            - We need to know how to compare that data.

        One thing we know about how we interpret an anagram is that it can be unique
        
        act =/= pots because the structure is different 
        act == cat because they use the same stuff.

        This means that if we homogenize all the answers, they will be the same!

        sort act and cat => act 2x

        We can use that as an identifier and the structure of choice will be a HashSet 
        

        How to compare the data?
        If cat => act, we can see that because act is already in there, we can store this value with it. That means instead of a HashSet, actually, we should use a Dictionary. 
        
        */

        Dictionary<string, List<string>> dict = new();

        foreach(string s in strs){
            char[] c = s.ToCharArray();
            Array.Sort(c); 
            string sorted = new string(c);

            if (dict.ContainsKey(sorted)){
                dict[sorted].Add(s);
            }
            else{
                dict[sorted] = new() { s };
            }
        }

        return dict.Values.ToList();
    }
}
