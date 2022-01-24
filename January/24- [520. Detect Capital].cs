public class Solution {
    public bool DetectCapitalUse(string word) {
        int caps = 0; 
        
        for(int i = 0; i < word.Length; i++) {
            if(Char.IsUpper(word[i])){
                caps++;
            }
        }
        if( caps == word.Length || caps == 0) return true;
        
        return caps == 1 && Char.IsUpper(word[0]);
        
    }
}