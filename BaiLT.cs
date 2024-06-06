using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("Chọn chức năng để chạy (1: Kiểm tra tuổi học sinh, 2: Quản lý tài khoản ngân hàng):");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                CheckStudentEligibility();
                break;
            case "2":
                ManageBankAccount();
                break;
            default:
                Console.WriteLine("Lựa chọn không hợp lệ.");
                break;
        }
    }

    static void CheckStudentEligibility()
    {
        try
        {
            Console.Write("Nhập tuổi của học sinh: ");
            int age = int.Parse(Console.ReadLine());

            if (age < 18 || age > 25)
            {
                throw new AgeOutOfRangeException("Tuổi không phù hợp với tiêu chí nhập học.");
            }
            else
            {
                Console.WriteLine("Học sinh đủ điều kiện để nhập học.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Vui lòng nhập tuổi bằng số nguyên.");
        }
        catch (AgeOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    static void ManageBankAccount()
    {
        try
        {
            BankAccount account = new BankAccount();

            Console.WriteLine("Số dư ban đầu: " + account.Balance);

            Console.Write("Nhập số tiền muốn gửi: ");
            decimal depositAmount = decimal.Parse(Console.ReadLine());
            account.Deposit(depositAmount);

            Console.WriteLine("Số dư sau khi gửi: " + account.Balance);

            Console.Write("Nhập số tiền muốn rút: ");
            decimal withdrawAmount = decimal.Parse(Console.ReadLine());
            account.Withdraw(withdrawAmount);

            Console.WriteLine("Số dư sau khi rút: " + account.Balance);
        }
        catch (FormatException)
        {
            Console.WriteLine("Vui lòng nhập số tiền bằng số.");
        }
        catch (NegativeAmountException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (InsufficientFundsException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

class AgeOutOfRangeException : Exception
{
    public AgeOutOfRangeException(string message) : base(message)
    {
    }
}

class BankAccount
{
    public decimal Balance { get; private set; }

    public void Deposit(decimal amount)
    {
        if (amount < 0)
        {
            throw new NegativeAmountException("Số tiền gửi không thể là số âm.");
        }
        Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount < 0)
        {
            throw new NegativeAmountException("Số tiền rút không thể là số âm.");
        }
        if (Balance - amount < 0)
        {
            throw new InsufficientFundsException("Không đủ tiền để rút.");
        }
        Balance -= amount;
    }
}

class NegativeAmountException : Exception
{
    public NegativeAmountException(string message) : base(message)
    {
    }
}

class InsufficientFundsException : Exception
{
    public InsufficientFundsException(string message) : base(message)
    {
    }
}
