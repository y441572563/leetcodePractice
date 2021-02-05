public class Solution {
    public int DiagonalSum(int[][] mat) {
        int result = 0;
        int index = 0;
        Array.ForEach( mat, i => {
            if(index != i.Length - index - 1 ) {
                result += (i[index] + i[i.Length - index - 1]);
            }else{
                result += i[index];
            }
            
            index ++;
        });
                            
        return result;
    }
}