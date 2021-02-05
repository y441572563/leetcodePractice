/**
 * @param {number[]} nums
 * @return {number}
 */
var findLHS = function(nums) {
        var longest = [];
        var temp = [];

        nums.forEach(n=> {
            temp = nums.filter(o=> o=== n || o === n+1);
            if(temp.length > longest.length && temp.filter(i => i != temp[0]).length != 0){
                longest = temp
            }
        });
    
        return longest.length;
        
};