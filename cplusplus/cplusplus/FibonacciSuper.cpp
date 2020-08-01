#include <iostream>
#include <vector>

long long int calc_fibonacci_last_digit(int n, std::vector<long long int>& nums)
{
    if (n <= 1)
        return n;
    if (nums[n - 1] != 0 && nums[n - 2] != 0)
    {
        return nums[n - 1] + nums[n - 2];
    }

    nums[n - 1] = calc_fibonacci_last_digit(n - 1, nums);
    nums[n - 2] = calc_fibonacci_last_digit(n - 2, nums);

    return nums[n - 1] + nums[n - 2];
}

long long int get_fibonacci_last_digit(int n)
{
    std::vector<long long int> array (n);
    for (int i = 0; i < n; i++) {
        array[i] = (rand() % n) + 1;
    }
   // return array[n - 1];
   return calc_fibonacci_last_digit(n, array);
}

int main() {
    while (true)
    {
        int n;
        std::cin >> n;
        std::cout << get_fibonacci_last_digit(n) << '\n';
    }
}
