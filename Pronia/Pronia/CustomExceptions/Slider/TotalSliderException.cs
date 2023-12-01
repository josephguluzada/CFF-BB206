using System.Runtime.Serialization;

namespace Pronia.CustomExceptions.Slider
{
    public class TotalSliderException : Exception
    {
        public string PropertyName { get; set; }
        public TotalSliderException()
        {
        }

        public TotalSliderException(string propertyName,string? message) : base(message)
        {
            PropertyName = propertyName;
        }
    }
}
