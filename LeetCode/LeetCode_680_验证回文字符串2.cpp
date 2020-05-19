#include "stdth.h"

class Solution {
public:

    bool check(string &s, int left, int right)
    {
        if (left >= right)
            return true;
        while (left<right)
        {
            if (s[left]!=s[right])
            {
                return false;
            }
            ++left;
            --right;
        }
        return true;
    }

    bool validPalindrome(string s) {
        int left = 0;
        int right = s.size() - 1;
        while (left<right)
        {
            if (s[left] != s[right])
            {//�ж�Ӧ��ɾ���ĸ��ַ���
                return check(s, left, right - 1) || check(s, left + 1, right);
            }
            ++left;
            --right;
        }
        return true;
    }
};

void main()
{
    return;
}