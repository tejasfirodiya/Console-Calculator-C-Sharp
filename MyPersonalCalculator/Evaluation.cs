class Evaluation
{
    public static int Eval(string str)
    {

        string[] strarr = str.Split(" ");

        int ans = int.Parse(strarr[0]);

        for (int i = 1; i < strarr.Length; i++)
        {
            if (strarr[i] == "+")
            {
                ans += int.Parse(strarr[i + 1]);
                i++;
            }
            else if (strarr[i] == "-")
            {
                ans -= int.Parse(strarr[i + 1]);
                i++;
            }
            else if (strarr[i] == "*")
            {
                ans *= int.Parse(strarr[i + 1]);
                i++;
            }
            else if (strarr[i] == "/")
            {
                ans /= int.Parse(strarr[i + 1]);
                i++;
            }
            else
            {
                ans = int.Parse(strarr[i]);
                i++;
            }
        }
        return ans;
    }
}