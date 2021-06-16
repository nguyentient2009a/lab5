using System;

namespace Part2
{
    public class AmountException : Exception
    {
        private string _pesonName;
        private string _message;

        public AmountException(string message, string pesonName) : base(message)
        {
            this._message = message;
            this._pesonName = pesonName;
        }

        private void PrintError()
        {
            Console.Error.WriteLine($"error: {_message}, name{_pesonName}");
        }
    }
}