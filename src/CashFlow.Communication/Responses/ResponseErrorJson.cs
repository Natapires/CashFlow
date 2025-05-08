namespace CashFlow.Communication.Responses;

public class ResponseErrorJson
{
    public List<string> ErrorMessage { get; set; } //Com esses codigo abaixos, estou inicializando a lista já com a mensagem de erro

    public ResponseErrorJson(string errorMessage) //Com esse construtor, estamos obrigando a passar um parâmetro 
    {
        ErrorMessage = [errorMessage];
    }

    public ResponseErrorJson(List<string> errorMessage) //aqui estou recebendo uma lista de mensagem.
    {
        ErrorMessage = errorMessage;
    }
}