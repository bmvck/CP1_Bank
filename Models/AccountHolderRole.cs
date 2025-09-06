namespace CP1_Bank.Models;

/// <summary>
/// Enum que representa o papel do titular na conta
/// </summary>
public enum AccountHolderRole
{
    /// <summary>
    /// Titular principal da conta
    /// </summary>
    Primary = 1,
    
    /// <summary>
    /// Titular conjunto da conta
    /// </summary>
    Joint = 2
}
