namespace CP1_Bank.Models;

/// <summary>
/// Enum que representa os tipos de transação bancária
/// </summary>
public enum TransactionType
{
    /// <summary>
    /// Transação de crédito (entrada de dinheiro)
    /// </summary>
    Credit = 1,
    
    /// <summary>
    /// Transação de débito (saída de dinheiro)
    /// </summary>
    Debit = 2
}
