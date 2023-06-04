namespace CommonLibrary.Model.Errors;

public class ValidationError
{
    public ValidationError(string key, List<string> errors)
    {
        Key = key;
        Errors = errors;
    }

    public string Key { get; set; }

    public List<string> Errors { get; set; }
}