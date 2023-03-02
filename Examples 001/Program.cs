
string AddBinary(string a, string b) {
      string result = String.Empty;
    int registry = 0;
    for (int i = a.Length - 1, j = b.Length - 1; i >= 0; i--, j--)
    {
        if (registry == 0)
        {
            if (a[i] == b[j] && b[j] == '0')
            {
                result = result.Insert(0, "0");
                registry = 0;
            }
            else if (a[i] == b[j] && b[j] == '1')
            {
                result = result.Insert(0, "0");
                registry = 1;
            }
            else
            {
                result = result.Insert(0, "1");
                registry = 0;

            }
        }
        else if (registry == 1)
        {
            if (a[i] == b[j] && b[j] == '0')
            {
                result = result.Insert(0, "1");
                registry = 0;
            }
            else if (a[i] == b[j] && b[j] == '1')
            {
                result = result.Insert(0, "1");
                registry = 1;
            }
            else
            {
                result = result.Insert(0, "0");
                registry = 1;

            }
        }
    }


    for (int j = b.Length - a.Length - 1; j >= 0; j--)
    {
        if (registry == 0)
        {
            result = result.Insert(0, b[j].ToString());
            registry = 0;
        }
        if (registry == 1)
        {

            if (b[j] == 0)
            {
                result = result.Insert(0, "1");
                registry = 0;
            }
            else
            {
                result = result.Insert(0, "0");
                registry = 1;
            }
        } 
    }
    if (registry == 1) result = result.Insert(0, "1");
        Console.WriteLine(result);

    return result;
    }
}