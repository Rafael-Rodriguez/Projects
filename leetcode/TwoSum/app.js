/**
 * 
 * @param {number[]} nums 
 * @param {number} target 
 * @return {number[]}
 */
var FindIndicesOfTwoNumbersThatAddUpToTheTarget = function(nums, target)
{
    if(nums.length <= 0)
    {
        throw "Number array has zero length.";
    }

    if(nums.length == 1 && nums[0] != target)
    {
        throw "Number array has a length of one and item does not match target";
    }
    
    for(i = 0; i < nums.length - 1; ++i)
    {
        for(j = 1; j < nums.length; ++j)
        {
            if(nums[i] + nums[j] == target)
            {
                return [i, j];
            }
        }
    }

    throw "There are no two numbers in the array that equal to target";
};

var numbers = [3,2,4];
var target = 6;

try
{
    var result = FindIndicesOfTwoNumbersThatAddUpToTheTarget(numbers,target);
    console.log(result);
}
catch(err)
{
    console.log(err);
}


