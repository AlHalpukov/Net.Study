// Допустим, у нас есть сущность BankAccount и мы хотим защищенно менять баланс 

// Что здесь инкапсулируется:
// 1. Сокрытие состояния - _balance скрыто через private/
// 2. Ограничение изменения - баланс можно поменять только через методы
//      Deposit и Withdraw, нельзя, например, установить отрицательный баланс.
// 3. Контроль через поведение - любое изменение баланса проходит только через
//      бизнес-логику (валидация входных данных, проверка остатка,
//      логика правил (нельзя уйти в отрицательный остаток)).
// 4. Безопасный интерфейс (Programm.cs)

public class BankAccount
{
    // Поле скрыто полностью, снаружи доступ только через методы.
    private decimal _balance;

    public string Owner { get; }
    public string AccountNumber { get; }

    public BankAccount(string owner, string accountNumber, decimal initialBalance)
    {
        Owner = owner;
        AccountNumber = accountNumber;
        _balance = initialBalance;
    }

    // Публичные методы для изменения баланса
    public void Deposit(decimal amount)
    {
        if (amount < 0)
        {
            throw new ArgumentException("Amount must be positive.");
        }

        _balance += amount;
    }

    public void Withrdaw(decimal amount)
    {
        if (amount < 0)
        {
            throw new ArgumentException("Amount must be positive.");
        }

        if (amount > _balance)
        {
            throw new InvalidOperationException("Insufficient funds.");
        }

        _balance -= amount;
    }

    // Публичный метод только для чтения баланса - защищаем баланс от прямой записи

    public decimal GetBalance() => _balance;

}