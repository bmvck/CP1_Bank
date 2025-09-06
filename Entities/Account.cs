using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CP1_Bank.Models;

namespace CP1_Bank.Entities;

/// <summary>
/// Entidade que representa uma conta bancária
/// </summary>
public class Account
{
    /// <summary>
    /// Identificador único da conta (Chave Primária)
    /// </summary>
    [Key]
    public Guid AccountId { get; set; } = Guid.NewGuid();

    /// <summary>
    /// Identificador da agência (Chave Estrangeira - obrigatório)
    /// </summary>
    [Required]
    public Guid BranchId { get; set; }

    /// <summary>
    /// Número da conta (obrigatório e único)
    /// </summary>
    [Required]
    [StringLength(20)]
    public string Number { get; set; } = string.Empty;

    /// <summary>
    /// Tipo da conta (obrigatório)
    /// </summary>
    [Required]
    public AccountType Type { get; set; }

    /// <summary>
    /// Data de abertura da conta (obrigatório)
    /// </summary>
    [Required]
    public DateTime OpenedAt { get; set; } = DateTime.UtcNow;

    /// <summary>
    /// Status atual da conta (obrigatório)
    /// </summary>
    [Required]
    public AccountStatus Status { get; set; } = AccountStatus.Active;

    // Propriedades de navegação
    /// <summary>
    /// Agência à qual a conta pertence
    /// Relacionamento N:1 com Branch
    /// </summary>
    [ForeignKey(nameof(BranchId))]
    public virtual Branch Branch { get; set; } = null!;

    /// <summary>
    /// Lista de transações da conta
    /// Relacionamento 1:N com Transaction
    /// </summary>
    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();

    /// <summary>
    /// Lista de titulares da conta
    /// Relacionamento 1:N com AccountHolder
    /// </summary>
    public virtual ICollection<AccountHolder> AccountHolders { get; set; } = new List<AccountHolder>();
}
