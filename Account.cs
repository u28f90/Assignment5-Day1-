using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;



public class Account
{
    int id;
    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    String accountType;
    public string AccountType 
    { get { return accountType; } 
      set { accountType = value; } 
    }
    double balance;
    public double Balance { 
        get { return balance; } 
        set { balance = value; } 
    }

    public bool Withdraw(double amount)
    {
        if (amount < balance)
        {
            return true;
        }
        else { return false; }

    }
    public String GetDetails()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append($"Accound Id : {id} \n");
        sb.Append($"Account Type : {accountType} \n");
        sb.Append($"Balance : {balance} ");
        return sb.ToString();
    }




}