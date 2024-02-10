using Sofra.Service.Validation;

namespace Sofra.Service.Results
{
    public interface IResult
    {
        public ResultStatus ResultStatus { get; }
        public string? Message { get; }
        public Exception? Exception { get; }
        public IEnumerable<ValidationError> ValidationErrors { get; set; }
    }
}
