using System.ComponentModel.DataAnnotations;

namespace CP1_Bank.Entities;

/// <summary>
/// Entidade que representa uma agência bancária
/// </summary>
public class Branch
{
    /// <summary>
    /// Identificador único da agência (Chave Primária)
    /// </summary>
    [Key]
    public Guid BranchId { get; set; } = Guid.NewGuid();

    /// <summary>
    /// Código da agência (obrigatório)
    /// </summary>
    [Required]
    [StringLength(10)]
    public string Code { get; set; } = string.Empty;

    /// <summary>
    /// Nome da agência (obrigatório)
    /// </summary>
    [Required]
    [StringLength(100)]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Endereço da agência (opcional)
    /// </summary>
    [StringLength(200)]
    public string? Address { get; set; }

    // Propriedades de navegação
    /// <summary>
    /// Lista de contas vinculadas a esta agência
    /// Relacionamento 1:N com Account
    /// </summary>
    public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();
}
