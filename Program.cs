//*****************************************************************************
//** 33. Search in Rotated Sorted Array  leetcode                            **
//** Simple loop to find where it was rotated, return -1 if not found  -Dan  **
//*****************************************************************************

int search(int* nums, int numsSize, int target) {
    for(int i = 0; i < numsSize; i++)
        if(nums[i]==target) return i;
    return -1;
}