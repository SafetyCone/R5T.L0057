using System;


namespace R5T.L0057
{
    public class ReflectionOperator : IReflectionOperator
    {
        #region Infrastructure

        public static IReflectionOperator Instance { get; } = new ReflectionOperator();


        private ReflectionOperator()
        {
        }

        #endregion
    }
}
