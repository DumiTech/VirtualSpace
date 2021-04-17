namespace API.Errors
{
    public class ApiException   // generate constructor => takes our properties and populates them inside the constructor
    {
        public ApiException(int statusCode, string message = null, string details = null) // giving initial value to message & details
        {
            StatusCode = statusCode;
            Message = message;
            Details = details;
        }

        public int StatusCode { get; set; }

        public string Message { get; set; }

        public string Details { get; set; }
        
    }
}