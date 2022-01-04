public class Solution {
    public int BitwiseComplement(int n) {
        // converting from integer to binary
		string binaryNumber = Convert.ToString(n, 2);
		char[] wordArray = binaryNumber.ToCharArray();
		for(int i = 0; i < wordArray.Length; i++){
				if(wordArray[i] == '0')
					wordArray[i] = '1';
				else {
					wordArray[i] = '0';
				}
		}
		string flippedResult = new String(wordArray);
		int finalResult = Convert.ToInt32(flippedResult , 2); 
        return finalResult;
    }
}