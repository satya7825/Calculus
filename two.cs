public class AccountUtility{
    public double CalculateInterest(){
        return Program.accountObj.Balance*Program.accountObj.InterestRate/100;
    }
}