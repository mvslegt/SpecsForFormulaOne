namespace SpecsForFormulaOne.Mvc.Models
{
    public class Result<TResult>
    {
        /// <summary>
        /// Use this constructor on a succes result.
        /// This will set the object in a Not Failed state.
        /// </summary>
        /// <param name="value">The result returned by the called method.</param>
        public Result(TResult value)
        {
            Value = value;
        }

        /// <summary>
        /// Use this constructor when a error occured.
        /// This will set the object in the Failed state.
        /// </summary>
        /// <param name="errorMessage">The message of the failure.</param>
        public Result(string errorMessage)
        {
            ErrorMessage = errorMessage;
            Failed = true;
        }

        public string ErrorMessage { get; }

        public bool Failed { get; }

        public TResult Value { get; }
    }
}
