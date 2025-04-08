public class Solution {
    public void MoveZeroes(int[] nums) {
        List<int> numbers = new List<int>();
        numbers.AddRange(nums);

        int count = numbers.Count;

        for (int i = 0; i < count; i++)
        {
            if (numbers[i] == 0)
            {
                numbers.RemoveAt(i);
                numbers.Add(0);
            }
        }        
    }
}
