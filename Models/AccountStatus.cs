namespace CP1_Bank.Models;

/// <summary>
/// Enum que representa os status possíveis de uma conta bancária
/// </summary>
public enum AccountStatus
{
    /// <summary>
    /// Conta ativa e operacional
    /// </summary>
    Active = 1,
    
    /// <summary>
    /// Conta bloqueada temporariamente
    /// </summary>
    Blocked = 2,
    
    /// <summary>
    /// Conta encerrada
    /// </summary>
    Closed = 3
}
