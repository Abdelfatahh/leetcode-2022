public class WordDictionary {

     TreeNode root;
    
    public WordDictionary() {
        this.root = new TreeNode();
    }
    
    public void AddWord(string word) {
        var current = this.root;
        
        for (var i = 0; i < word.Length; i++) {
            if (!current.nodes.ContainsKey(word[i])) {
                current.nodes.Add(word[i], new TreeNode());
            }
            
            current = current.nodes[word[i]];
        }
        
        if (!current.nodes.ContainsKey('$')) {
            current.nodes.Add('$', null);
        }
    }
    
    public bool Search(string word) {
        return Search(word, 0, this.root);
    }
    
    private bool Search(string word, int position, TreeNode tree) {
        if (position == word.Length) {
            return tree.nodes.ContainsKey('$');
        }
        
        int i;
        for (i = position; i < word.Length; i++) {
            if (word[i] == '.') {
                foreach (var k in tree.nodes.Keys) {
                    if (k == '$') {
                        continue;
                    }
                    
                    if (Search(word, i + 1, tree.nodes[k])) {
                        return true;
                    }
                }

                return false;
            }

            if (!tree.nodes.TryGetValue(word[i], out tree)) {
                return false;
            }
        }

        return tree.nodes.ContainsKey('$');
    }
    
    class TreeNode {
        public Dictionary<char, TreeNode> nodes = new Dictionary<char, TreeNode>();
    }
}

/**
 * Your WordDictionary object will be instantiated and called as such:
 * WordDictionary obj = new WordDictionary();
 * obj.AddWord(word);
 * bool param_2 = obj.Search(word);
 */