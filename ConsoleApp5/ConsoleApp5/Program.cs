// See https://aka.ms/new-onsole-template for more information
Console.WriteLine("Hello, World!");

Test1 tes = new Test1();

tes.isPalindrome("NITIN");

tes.isPrimeNumber(19);


public class Test1
{




    public bool isPalindrome(string param)
    {

        var data = param.ToCharArray();
        Array.Reverse(data);
        var join = string.Join("", data);

        if (param == join)
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    public bool isPrimeNumber(int num)
    {
        if (num < 1)
            return false;

        if (num == 2 || num == 3)
            return true;

        if (num > 2)
        {
            //if (num % 3 == 0)
            //    return true;

            //if (num % 5 == 0)
            //    return true;

            //if (num % 7 == 0)
            //    return true;

            //if (num % 11 == 0)
            //    return true;

        }

        return false;
    }

}