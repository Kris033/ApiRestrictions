namespace Walkiria.Restrictions.Interfaces.Dtos;

public class BaseResponse
{
    public BaseResponse(string? errorMessage = null)
    {
        ErrorMessage = errorMessage;
    }

    public bool IsSuccess => string.IsNullOrWhiteSpace(ErrorMessage);
    public string? ErrorMessage { get; set; }
}