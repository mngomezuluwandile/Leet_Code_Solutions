using System.Text;

public class Solution {
    public string DigitSum(string s, int k) {

        while (s.Length > k)
        {
            StringBuilder new_string_holder = new StringBuilder();

            for (int index = 0; index < s.Length; index = index + k)
            {
                int total_all = 0;
                int cap_group = Math.Min(index + k, s.Length);

                for (int j = index; j < cap_group; j++)
                {
                    total_all = total_all + s[j] - '0';
                }

                new_string_holder.Append(total_all);
            }

            s = new_string_holder.ToString();
        }

        return s;
    }
}