using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CP1_Bank.Models;

namespace CP1_Bank.Entities;

/// <summary>
/// Entidade que representa a titularidade de uma conta (tabela de associação N:N)
/// </summary>
public class AccountHolder
{
    /// <summary>
    /// Identificador da conta (Chave Primária Composta)
    /// </summary>
    [Key]
    [Column(Order = 0)]
    public Guid AccountId { get; set; }

    /// <summary>
    /// Identificador do cliente (Chave Primária Composta)
    /// </summary>
    [Key]
    [Column(Order = 1)]
    public Guid CustomerId { get; set; }

    /// <summary>
    /// Papel do titular na conta (obrigatório)
    /// </summary>
    [Required]
    public AccountHolderRole Role { get; set; }

    /// <summary>
    /// Data desde quando é titular (opcional)
    /// </summary>
    public DateTime? Since { get; set; }

    // Propriedades de navegação
    /// <summary>
    /// Conta à qual o cliente é titular
    /// Relacionamento N:1 com Account
    /// </summary>
    [ForeignKey(nameof(AccountId))]
    public virtual Account Account { get; set; } = null!;

    /// <summary>
    /// Cliente que é titular da conta
    /// Relacionamento N:1 com Customer
    /// </summary>
    [ForeignKey(nameof(CustomerId))]
    public virtual Customer Customer { get; set; } = null!;
}
