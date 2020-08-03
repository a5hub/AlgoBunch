namespace LeetCode
{
    /// <summary> https://leetcode.com/problems/reverse-string </summary>
    /// <remarks> Fastest algorithm </remarks>
    public class ReverseStringTask
    {
        public static void ReverseString(char[] s)
        {
            var j = s.Length - 1;
            for (int i = 0; i < s.Length / 2; i++)
            {
                var tmp = s[i];
                s[i] = s[j];
                s[j] = tmp;
                j--;
            }
        }
    }
}

