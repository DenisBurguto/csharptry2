/*
public class Solution
{
    public int[] RunningSum(int[] nums)
    {
        int length = nums.Length, sumPrefix = 0, index = 0;
        int[] array;
        array[0] = nums[0];
        while (index < length)
        {
            sumPrefix= sumPrefix + nums[index];
            nums[index] =sumPrefix;
            index++;
        }
    return array;

    }
}

public class Solution
{
    public int MaximumWealth(int[][] accounts)
    { 
        int sum = 0, max = 0;
        for (int i = 0; i < accounts.Length; i++)
        {
            
            for (int j = 0; j < accounts[i].Length; j++)
            {
                sum = sum + accounts[i][j];
            }
            if (sum > max) max = sum;
            sum = 
        }
    return max;
    }
    
}
/*
Добавление в список

List<string> people = new List<string> () { "Tom" };
 
people.Add("Bob"); // добавление элемента
// people = { "Tom", "Bob" };
 
people.AddRange(new[] { "Sam", "Alice" });   // добавляем массив
// people = { "Tom", "Bob", "Sam", "Alice" };
// также можно было бы добавить другой список
// people.AddRange(new List<string>(){ "Sam", "Alice" });
 
people.Insert(0, "Eugene"); // вставляем на первое место
// people = { "Eugene", "Tom", "Bob", "Sam", "Alice" };
 
people.InsertRange(1, new string[] {"Mike", "Kate"}); // вставляем массив с индекса 1
// people = { "Eugene", "Mike", "Kate", "Tom", "Bob", "Sam", "Alice" };
 
// также можно было бы добавить другой список
// people.InsertRange(1, new List<string>(){ "Mike", "Kate" });
</string></string>
*/
/*
public class Solution {
    public IList<string> FizzBuzz(int n)
    {
         
        List<string> Fb = new List<string>();

        int num =1;
        while(num <= n)
        {
            if(num%15==0) Fb.Add("FizzBuzz");
            else if(num%5==0) Fb.Add("Buzz");
            else if(num%3==0) Fb.Add("Fizz");
            else Fb.Add("num");
       
        }
        return Fb;
    }
}
*/
public class Solution
{
    public int NumberOfSteps(int num)
    {
        int count = 0;
        while (num != 0)
        {
            if (num % 2 == 0)
            {
                num = num / 2;
            }
            else num--;
            count++;
        }
        return count;
    }
}

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode MiddleNode(ListNode head) 
    {
        ListNode<middle> = head;
        ListNode end = head;
        while(end !=0 && end.next != 0)
        {
            middle = middle.next;
            end = end.next.next;
        }
        return middle;
    }
}