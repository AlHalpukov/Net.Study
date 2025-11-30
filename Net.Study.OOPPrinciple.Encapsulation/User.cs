
namespace Net.Study.OOPPrinciple.Encapsulation;

// Более современный подход с использованием свойств и приватного сеттера

// Преимущества:
// - Name можно читать везде (public get)
// - менять можно только через метод, где выполняется валидация (private set и метод)

internal class User
{
    public string Name { get; private set; }

    public User(string name)
    {
        SetName(name);
    }

    public void SetName(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentException("Name can't be empty.");
        }

        Name = name;
    }
}
