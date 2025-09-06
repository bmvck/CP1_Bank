using System.ComponentModel.DataAnnotations;

namespace CP1_Bank.Entities;

/// <summary>
/// Entidade que representa um cliente do banco
/// </summary>
public class Customer
{
    /// <summary>
    /// Identificador único do cliente (Chave Primária)
    /// </summary>
    [Key]
    public Guid CustomerId { get; set; } = Guid.NewGuid();

    /// <summary>
    /// Nome completo do cliente (obrigatório)
    /// </summary>
    [Required]
    [StringLength(150)]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// CPF do cliente (obrigatório e único)
    /// </summary>
    [Required]
    [StringLength(11)]
    public string CPF { get; set; } = string.Empty;

    /// <summary>
    /// Email do cliente (opcional)
    /// </summary>
    [EmailAddress]
    [StringLength(100)]
    public string? Email { get; set; }

    /// <summary>
    /// Telefone do cliente (opcional)
    /// </summary>
    [StringLength(20)]
    public string? Phone { get; set; }

    // Propriedades de navegação
    /// <summary>
    /// Lista de titularidades do cliente em contas
    /// Relacionamento N:N com Account via AccountHolder
    /// </summary>
    public virtual ICollection<AccountHolder> AccountHolders { get; set; } = new List<AccountHolder>();
}
