using System;
using System.Collections.Generic;
using System.Linq;

namespace ECDSa.Helper
{
    public sealed class ErrorMessage
    {
        public ErrorMessage()
        {
        }

        public ErrorMessage(string message)
        {
            Message = message;
        }

        public string Message { get; set; }
    }

    public class Result<TValue>
    {
        private TValue _value;
        private readonly List<ErrorMessage> _errorMessages;
        private readonly Exception _exception;

        private Result()
        {
            _errorMessages = new List<ErrorMessage>();
        }

        private Result(TValue result) : this()
        {
            _value = result;
        }

        private Result(Exception e) : this()
        {
            _exception = e;
            _errorMessages.Add(new ErrorMessage(e.Message));
        }

        private Result(ErrorMessage errorMessage) : this()
        {
            _errorMessages.Add(errorMessage);
        }

        private Result(List<ErrorMessage> errorsMessages) : this()
        {
            foreach (var errorMessage in errorsMessages)
            {
                _errorMessages.Add(errorMessage);
            }
        }

        public static implicit operator Result<TValue>(TValue value) => new Result<TValue>(value);
        public static implicit operator Result<TValue>(Exception e) => new Result<TValue>(e);
        public static implicit operator Result<TValue>(ErrorMessage errorMessage) => new Result<TValue>(errorMessage);
        public static implicit operator Result<TValue>(List<ErrorMessage> errorsMessages) => new Result<TValue>(errorsMessages);

        public TValue Value
        {
            get { return _value; }
            set { _value = value; }
        }

        public IReadOnlyCollection<ErrorMessage> ErrorMessages
        {
            get { return _errorMessages; }
        }

        public Exception Exception
        {
            get { return _exception; }
        }

        public bool IsError => ErrorMessages.Any();

        public Result<TValue> AddErrorMessage(string message)
        {
            _errorMessages.Add(new ErrorMessage(message));
            return this;
        }

        public Result<TValue> AddErrorMessages(IEnumerable<ErrorMessage> messages)
        {
            foreach (var message in messages)
            {
                _errorMessages.Add(message);
            }

            return this;
        }

        public Result<TValue> AddErrorMessages(IEnumerable<string> messages)
        {
            foreach (var message in messages.Select(o => new ErrorMessage(o)))
            {
                _errorMessages.Add(message);
            }

            return this;
        }

        public bool HasErrorMessage(string message)
        {
            return ErrorMessages.Select(o => o.Message).Contains(message);
        }
    }
}