using Flunt.Notifications;
using OOP.Domain.Contracts;

namespace OOP.Domain.ValueObjects;
public class Name: Notifiable<Notification>
{
  public Name(string nome, string sobrenome)
  {
    Nome = nome;
    Sobrenome = sobrenome;

    AddNotifications(
      new NameContract(this)
    );
  }

  public string Nome { get; private set; }
  public string Sobrenome { get; private set; }
  
}