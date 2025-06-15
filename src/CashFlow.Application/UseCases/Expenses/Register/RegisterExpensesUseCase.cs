using CashFlow.Communication.Request;
using CashFlow.Communication.Responses;
using CashFlow.Domain.Entities;
using CashFlow.Exception.ExceptionBase;

namespace CashFlow.Application.UseCases.Expenses.Register;

public class RegisterExpensesUseCase
{
    public ResponseRegisteredExpenseJson Execute(RequestRegisterExpenseJson request)
    {
        Validate(request);

        var entity = new Expense
        {
            Amount = request.Amount,
            Date = request.Date,
            Description = request.Description,
            Title = request.Title,
            PaymentType = (Domain.Enums.PaymentType)request.PaymentType,
        };
        
        return new ResponseRegisteredExpenseJson();
    }

    private void Validate(RequestRegisterExpenseJson request) //Uma funcao auxiliar
    {
        var validator = new RegisterExpenseValidator();

        var result = validator.Validate(request);

        if (result.IsValid == false)
        {
            var errorMessages = result.Errors.Select(f => f.ErrorMessage).ToList();

            throw new ErrorOnValidationException(errorMessages);
        }
    }
}