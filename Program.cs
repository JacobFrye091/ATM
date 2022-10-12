using System;

public class cardHolder
{
    String cardNum;
    int pin;
    String firstName;
    String lastName;
    double balance;
    public cardHolder(string cardNum, int pin, string firstName, string lastName, double balance)
    {
        this.cardNum = cardNum;
        this.pin = pin;
        this.firstName = firstName;
        this.lastName = lastName;
        this.balance = balance;
    }
    public String geNum()
    {
        return cardNum;
    }
    public int getPin()
    {
        return pin;
    }
    public String getFirstName()
    {
        return firstName;
    }
    public String getLastName()
    {
        return lastName;
    }
    public double getBalance()
    {
        return balance;
    }
    public void setNum(String newCardNum)
    {
        cardNum = newCardNum;
    }
    public void setPin(int newPin)
    {
        pin = newPin;
    }
    public void setFirstName(String newFirstName)
    {
        firstName = newFirstName;
    }
    public void setLastName(String newLastName)
    {
        lastName = newLastName;
    }
    public void setBalance(double newBalance)
    {
        balance = newBalance;
    }
    public static void Main(String[] args)
    {
        void printOptions()
        {
            Console.WriteLine("Please choose from one of the following options...");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Deposit");
            Console.WriteLine("4. Deposit");
        }
        void deposit(cardHolder currentUser)
        {
            Console.WriteLine("How much $$ would you like to deposit? ");
            double deposit = Double.Parse(Console.ReadLine());
            currentUser.setBalance(deposit);
            Console.WriteLine($"Thank you for your $$. Your new balance is: {currentUser.getBalance()}");
        }
        void withdraw(cardHolder currentUser)
        {
            Console.WriteLine("How much $$ would you like to withdraw: ");
            double withdraw = Double.Parse(Console.ReadLine());
            //Check if the user has enough money
            if (currentUser.getBalance() > withdraw)
            {
                Console.WriteLine("Insufficient balance ;(");
            }
            else
            {
                currentUser.setBalance(currentUser.getBalance() - withdraw);
                Console.WriteLine("You are good to go. Thank you ;)");
            }
        }
        void balance(cardHolder currentUser)
        {
            Console.WriteLine("Current balance: "+currentUser.getBalance());
        }
        List<cardHolder> cardHolders = new List<cardHolder>();
    }
}
