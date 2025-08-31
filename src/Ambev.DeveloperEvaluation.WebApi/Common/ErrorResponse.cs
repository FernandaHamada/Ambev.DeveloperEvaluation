

namespace Ambev.DeveloperEvaluation.Common
{
    public class ErrorResponse
    {
        public string Type { get; set; }
        public string Error { get; set; } = string.Empty;
        public object Detail { get; set; }

    }
}
