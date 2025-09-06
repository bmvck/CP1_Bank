using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CP1_Bank.Models;

namespace CP1_Bank.Entities;

/// <summary>
/// Entidade que representa uma transação bancária
/// </summary>
public class Transaction
{
    /// <summary>
    /// Identificador único da transação (Chave Primária)
    /// </summary>
    [Key]
    public Guid TransactionId { get; set; } = Guid.NewGuid();

    /// <summary>
    /// Identificador da conta (Chave Estrangeira - obrigatório)
    /// </summary>
    [Required]
    public Guid AccountId { get; set; }

    /// <summary>
    /// Tipo da transação (obrigatório)
    /// </summary>
    [Required]
    public TransactionType Type { get; set; }

    /// <summary>
    /// Valor da transação (obrigatório)
    /// </summary>
    [Required]
    [Column(TypeName = "decimal(18,2)")]
    public decimal Amount { get; set; }

    /// <summary>
    /// Data e hora da transação (obrigatório)
    /// </summary>
    [Required]
    public DateTime PerformedAt { get; set; } = DateTime.UtcNow;

    /// <summary>
    /// Descrição da transação (opcional)
    /// </summary>
    [StringLength(200)]
    public string? Description { get; set; }

    // Propriedades de navegação
    /// <summary>
    /// Conta à qual a transação pertence
    /// Relacionamento N:1 com Account
    /// </summary>
    [ForeignKey(nameof(AccountId))]
    public virtual Account Account { get; set; } = null!;
}
