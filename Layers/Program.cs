using Layers.Models;

Product product = new RefinedProduct();
Product product2 = new UnrefinedProduct();



GoldAccount account = new GoldAccount(11);

Console.WriteLine(account.ReturnThree());


Account newAccount = new Account(23);

Account secondAccount = new GoldAccount(45);
var tempo = (secondAccount as GoldAccount).Title;

Account thirdAccount = new PremierGoldAccount(9);

List<Account> accounts = new List<Account>();
accounts.Add(secondAccount);
accounts.Add(thirdAccount);

foreach(Account account1 in accounts)
{
    if (account1 is PremierGoldAccount)
    {
        Console.WriteLine((account1 as PremierGoldAccount).Treat);
    }
    else if (account1 is GoldAccount) 
    {
        Console.WriteLine((account1 as GoldAccount).Title);
    }

}
Console.WriteLine();
Account fifthAccount = new Account(9);
accounts.Add(fifthAccount);

foreach (Account account1 in accounts)
{
    Console.WriteLine(account1.ReturnAge());

}
Console.WriteLine();

PremierGoldAccount fourthAccount = new PremierGoldAccount(9);
Console.WriteLine(fourthAccount.ValueCustomer());
Console.WriteLine((thirdAccount as PremierGoldAccount).ValueCustomer());
Console.Read();



