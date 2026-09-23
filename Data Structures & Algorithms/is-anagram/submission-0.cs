public class Solution {
    public bool IsAnagram(string s, string t) {

        if (s.Length != t.Length)
            return false;

        Dictionary<char, int> truth = new();

        // Count how many times a letter appears in string S 
        // Store it in a dictionary 
        foreach(char c in s){
            if (truth.ContainsKey(c))
                truth[c] += 1;
            else
                truth[c] = 1;
        }

        // Using the dictionary as a source of truth, observe t to see if values match.
        foreach(char c in t){
            if (truth.ContainsKey(c)){
                truth[c] -= 1;

                if (truth[c] < 0)
                    return false;
            }
            else
                return false;
        }

        return true;
    }
}
