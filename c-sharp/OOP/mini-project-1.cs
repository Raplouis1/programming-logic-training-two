//Exercise using all OOP concepts up to "exercise-4" file.

//======================================================

/*
Two people (Mary and John) want to put some money in their bank account.John opened a savings account to deposit his 300U$ and
Mary opened a checking account to deposit 500U$ and then, withdrew 100$ to buy a pair of shoes.
Each account have the following attributes and methods:

BankAccount //Class name

//Attributes (+public / # protected / - private)
+ account number
# type(checkings/savings)
- client name
- balance
- status(true->account is open / false->account is closed)

//Methods (in this example, all methods are public)
• open account (turns 'status' into true / chose checking ou savings / if chose checking += 50 / if chose savings +=150)
• close account (turns 'status' into false / can't have money in the account or have debits)
• deposit (status must be true)
• withdraw (status must be true / balance must be >= value)
• pay monthly fee (checkings=12 / savings=20)

• constructor new account (status = false, balance = 0)
• getters/setters

So, write a program to create and manage the clients' accounts.

//======================================================
*/
public class BankAccount
{
  public int accountNumber;
  protected string accountType;
  private string clientName;
  private decimal balance;
  private bool status;
  
  public void OpenAccount()
  {
    if(status == false)
    {
     status = true;     
     if(accountType == "checking")
     {
      balance += 50;      
     }else if(accountType == "savings"){
      balance += 150;
     }
      Console.WriteLine("Your account is now open.");
    }else{
     Console.WriteLine("Your account is already open.");
    }
  }
  
  public void CloseAccount()
  {
    if(status == true && balance == 0)
    {
      status = false;
      Console.WriteLine("Your account is now closed.");
    }else if(balance > 0){
     Console.WriteLine("Withdraw all your money before close your account.");
    }else if(balance < 0){
     Console.WriteLine("You have debits(negative account).Deposit money to finish you debits before close your account.");
    }
  }
  
  public void Deposit(decimal depositAmount)
  {
    if(status == true)
    {
      balance += depositAmount;
      Console.WriteLine("Your balance is: "+ balance);
    }else{
      Console.WriteLine("Open an account before deposit your money.");
    }      
  }
  
  public void Withdraw(decimal withdrawAmount)
  {
    if(status == true)
    {      
      if(withdrawAmount > 0 && withdrawAmount <= balance)
      {
        balance -= withdrawAmount;
        Console.WriteLine("Your balance is: "+ balance);
      }else if(status == false){
        Console.WriteLine("Open an account before deposit your money.");
      }else if(withdrawAmount > balance){
        Console.WriteLine("Not enough money in your account.");        
      }else{
        Console.WriteLine("Invalid amount.");
      }
    }
  }
  
  public void PayMonthlyFee()
  {
    if(status == true)
    {
     if(accountType == "checking")
     {
       balance -= 12;
     }else if(accountType == "savings"){
       balance -= 20;
     }
    }
  }   
    
  public BankAccount()
  {
    status = false;
    balance = 0;
  } 
  
  public string AccountType
  {
    get{return accountType;}
    set{accountType = value;}
  }    
  public string ClientName
  {
    get{return clientName;}
    set{clientName = value;}
  }
  public decimal Balance
  {
    get{return balance;}
    set{balance = value;}
  }
  public bool Status
  {
    get{return status;}
    set{status = value;}
  } 
  
}

//Main class

class Program
{
  static void Main(string[] args)
  {
    BankAccount b1 = new BankAccount();
    BankAccount b2 = new BankAccount();
    b1.clientName = "John";    
    b1.AccountNumber = 00001;
        
    Console.WriteLine("Welcome.");
    Console.WriteLine("Create the first client's account: ");
    Console.WriteLine("Write the client's name: ");
    b1.clientName = Console.ReadLine();
    Console.WriteLine("Write the client's number: ");
    b1.ClientNumber = Convert.ToInt32(Console.ReadLine());
    
    
    
    
  }  
}
