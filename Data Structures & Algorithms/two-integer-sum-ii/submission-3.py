class Solution:
    def twoSum(self, numbers: List[int], target: int) -> List[int]:
        firstIndex  = 0
        secondIndex = 1
        
        
        while (True):
            missing = target - numbers[firstIndex]
            # print(missing)

            # Guard against index out of bounds
            if firstIndex == len(numbers) - 1:
                break

            # Binary search since the list is non-decreasing
            # Find from first index + 1 to end
            # Target number is missing value
            secondIndex = self.binarySearch(numbers, missing, firstIndex + 1, len(numbers) - 1)

            # if found, break the loop
            if secondIndex != -1:
                break

            # Update index
            firstIndex = firstIndex + 1
        
        return [firstIndex + 1, secondIndex + 1]
            
    
    def binarySearch(self, numbers: List[int], target: int, start: int, end: int) -> int:
        # print(target, start, end)
        while start <= end:
            mid = (start + end) // 2
            

            if numbers[mid] == target:
                return mid
            elif numbers[mid] < target:
                start = mid + 1
            else:
                end = mid - 1

        return -1
        