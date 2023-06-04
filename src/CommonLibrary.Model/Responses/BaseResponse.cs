using CommonLibrary.Model.Errors;

namespace CommonLibrary.Model.Responses;

public class BaseResponse
{
    public Error Error { get; set; }
    public List<ValidationError> ValidationErrors { get; set; }

    public bool IsSuccess
    {
        get => Error == null || ValidationErrors == null;
    }

    public BaseResponse()
    {
        
    }

    public BaseResponse(Error error)
    {
        Error = error;
    }
    
    public BaseResponse(List<ValidationError> ValidationErrors)
    {
        ValidationErrors = ValidationErrors;
    }
}

public class BaseResponse<T> : BaseResponse
{
    public T Result { get; set; }

    public BaseResponse()
    {
    }

    public BaseResponse(T result)
    {
        Result = result;
    }
    
    public BaseResponse(Error error) : base(error)
    {

    }

    public BaseResponse(List<ValidationError> validationErrors) : base(validationErrors)
    {

    }
}