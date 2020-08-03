import java.util.HashMap;
import java.util.Map;

class TwoSum {
    public int[] twoSumCalc(int[] nums, int target) {
        Map<Integer, Integer> map = new HashMap<>();
        for (int i = 0; i < nums.length; i++) {
            map.put(nums[i], i);
        }
        for (int i = 0; i < nums.length; i++) {
            int complement = target - nums[i];
            if (map.containsKey(complement) && map.get(complement) != i) {
                return new int[] { i, map.get(complement) };
            }
        }
        throw new IllegalArgumentException("No two sum solution");
    }
}

class Program
{
    public static void main ( String [] arguments )
    {
        var obj = new TwoSum();
        var arr = new int[]{3, 3};
        var result = obj.twoSumCalc(arr, 6);
        System.out.println("Hello, world");
    }
}
