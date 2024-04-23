using System.Security.Principal;

public class Program{
    internal static Account accountObj=new Account();
    public static void Main(string[] args){
        string ano=Console.ReadLine();
        int bal=Convert.ToInt32(Console.ReadLine());
        int i=Convert.ToInt32(Console.ReadLine());

        accountObj.AccountNumber=ano;
        accountObj.Balance=bal;
        accountObj.InterestRate=i;
        AccountUtility ac =new AccountUtility();
        Console.WriteLine("Interest amount is " + ac.CalculateInterest());


    }
}
