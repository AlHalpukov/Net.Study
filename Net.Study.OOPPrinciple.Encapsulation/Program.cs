Console.WriteLine("Hello, World!");

// 4. Безопасный интерфейс - снаружи код работает так

var account = new BankAccount("Alex", "US1234", 0);

account.Deposit(2200); // корректно
Console.WriteLine("Balance: " + account.GetBalance()); //  можно посмотреть баланс

account.Withrdaw(5000); // некорректно
Console.WriteLine("Balance: " + account.GetBalance());

//account._balance = 100_000; // ошибка, нет доступа к приватному полю.