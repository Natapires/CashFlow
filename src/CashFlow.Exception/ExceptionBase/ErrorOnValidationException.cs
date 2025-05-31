namespace CashFlow.Exception.ExceptionBase;

public class ErrorOnValidationException(List<string> errorMessages) : CashFlowException
{
    public List<string> Errors { get; set; } = errorMessages;
}