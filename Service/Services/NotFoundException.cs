using System.Runtime.Serialization;

namespace Service.Services
{
    [Serializable]
    internal class NotFoundException : Exception
    {
        public NotFoundException(string message) : base(message)
        {
        }


    }
}