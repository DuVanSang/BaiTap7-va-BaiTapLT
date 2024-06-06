using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Chọn một bài tập để chạy (a, b, c, d, e, g, h, k, l, m):");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "a":
                BaiTapA();
                break;
            case "b":
                BaiTapB();
                break;
            case "c":
                BaiTapC();
                break;
            case "d":
                BaiTapD();
                break;
            case "e":
                BaiTapE();
                break;
            case "g":
                BaiTapG();
                break;
            case "h":
                BaiTapH();
                break;
            case "k":
                BaiTapK();
                break;
            case "l":
                BaiTapL();
                break;
            case "m":
                BaiTapM();
                break;
            default:
                Console.WriteLine("Lựa chọn không hợp lệ.");
                break;
        }
    }

    static void BaiTapA()
    {
        Console.Write("Nhập số nguyên không dấu thứ nhất: ");
        uint num1 = uint.Parse(Console.ReadLine());

        Console.Write("Nhập số nguyên không dấu thứ hai: ");
        uint num2 = uint.Parse(Console.ReadLine());

        uint sum = num1 + num2;
        Console.WriteLine("Tổng của hai số là: " + sum);
    }

    static void BaiTapB()
    {
        Console.Write("Nhập chiều dài của hình chữ nhật: ");
        ushort length = ushort.Parse(Console.ReadLine());

        Console.Write("Nhập chiều rộng của hình chữ nhật: ");
        ushort width = ushort.Parse(Console.ReadLine());

        ushort area = (ushort)(length * width);
        ushort perimeter = (ushort)(2 * (length + width));

        Console.WriteLine("Diện tích của hình chữ nhật là: " + area);
        Console.WriteLine("Chu vi của hình chữ nhật là: " + perimeter);
    }

    static void BaiTapC()
    {
        Console.Write("Nhập một số nguyên không dấu 4 byte: ");
        uint num = uint.Parse(Console.ReadLine());

        if (num % 2 == 0)
            Console.WriteLine("Số này là số chẵn.");
        else
            Console.WriteLine("Số này là số lẻ.");
    }

    static void BaiTapD()
    {
        Console.Write("Nhập số nguyên có dấu thứ nhất (1 byte): ");
        sbyte num1 = sbyte.Parse(Console.ReadLine());

        Console.Write("Nhập số nguyên có dấu thứ hai (1 byte): ");
        sbyte num2 = sbyte.Parse(Console.ReadLine());

        sbyte sum = (sbyte)(num1 + num2);
        Console.WriteLine("Tổng của hai số là: " + sum);
    }

    static void BaiTapE()
    {
        Console.Write("Nhập một số nguyên không dấu 4 byte: ");
        uint n = uint.Parse(Console.ReadLine());

        ulong sum = 0;
        for (uint i = 1; i <= n; i++)
        {
            sum += i;
        }

        Console.WriteLine("Tổng của các số từ 1 đến " + n + " là: " + sum);
    }

    static void BaiTapG()
    {
        Console.Write("Nhập chiều dài của hình chữ nhật: ");
        double length = double.Parse(Console.ReadLine());

        Console.Write("Nhập chiều rộng của hình chữ nhật: ");
        double width = double.Parse(Console.ReadLine());

        double area = length * width;
        double perimeter = 2 * (length + width);

        Console.WriteLine("Diện tích của hình chữ nhật là: " + area);
        Console.WriteLine("Chu vi của hình chữ nhật là: " + perimeter);
    }

    static void BaiTapH()
    {
        Console.Write("Nhập số thứ nhất: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Nhập số thứ hai: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.Write("Nhập số thứ ba: ");
        int num3 = int.Parse(Console.ReadLine());

        int max = num1;
        if (num2 > max)
            max = num2;
        if (num3 > max)
            max = num3;

        Console.WriteLine("Số lớn nhất là: " + max);
    }

    static void BaiTapK()
    {
        Console.Write("Nhập một số nguyên không âm: ");
        uint n = uint.Parse(Console.ReadLine());

        ulong factorial = 1;
        for (uint i = 1; i <= n; i++)
        {
            factorial *= i;
        }

        Console.WriteLine("Giai thừa của " + n + " là: " + factorial);
    }

    static void BaiTapL()
    {
        Console.Write("Nhập một số nguyên không âm: ");
        uint n = uint.Parse(Console.ReadLine());

        bool isPrime = n > 1;
        for (uint i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                isPrime = false;
                break;
            }
        }

        if (isPrime)
            Console.WriteLine(n + " là số nguyên tố.");
        else
            Console.WriteLine(n + " không phải là số nguyên tố.");
    }

    static void BaiTapM()
    {
        Console.Write("Nhập một số nguyên: ");
        int num = int.Parse(Console.ReadLine());

        int sum = 0;
        for (int i = 1; i < num; i++)
        {
            if (num % i == 0)
            {
                sum += i;
            }
        }

        if (sum == num)
            Console.WriteLine(num + " là số hoàn hảo.");
        else
            Console.WriteLine(num + " không phải là số hoàn hảo.");
    }
}

