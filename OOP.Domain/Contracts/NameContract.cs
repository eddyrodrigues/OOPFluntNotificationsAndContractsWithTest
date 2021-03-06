using Flunt.Notifications;
using Flunt.Validations;
using OOP.Domain.ValueObjects;

namespace OOP.Domain.Contracts;

public class NameContract : Contract<Name> {

  public NameContract(Name name)
  {
    Requires()
      .IsLowerThan(name.Nome, 40, "Name.Nome", "Nome precisa ter ao menos 40 caracteres")
      .IsGreaterThan(name.Nome, 2, "Name.Nome", "Nome precisa ser maior que 0 caracteres")
      .IsNotNullOrEmpty(name.Nome, "Name.Nome", "nome não pode ser nulo")
      .IsNotNullOrEmpty(name.Sobrenome, "Name.Sobrenome", "sobrenome não pode ser nulo")
      .IsLowerThan(name.Sobrenome, 40, "Name.Nome", "Nome precisa ser maior que 0 caracteres")
      .IsGreaterThan(name.Sobrenome, 2, "Name.Nome", "Nome precisa ser maior que 0 caracteres");
  }
}