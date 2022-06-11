using Flunt.Notifications;
using OOP.Domain.ValueObjects;

namespace OOP.Domain.Entities;
public class Usuario : Notifiable<Notification>
{
  public Name Name { get; private set; }
  
  public Usuario(Name nome)
  {
    Name = nome;

    AddNotifications(
      Name
    );
  }
}
