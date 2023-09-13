using System;


namespace R5T.L0057
{
    public class RuntimeEnvironmentOperator : IRuntimeEnvironmentOperator
    {
        #region Infrastructure

        public static IRuntimeEnvironmentOperator Instance { get; } = new RuntimeEnvironmentOperator();


        private RuntimeEnvironmentOperator()
        {
        }

        #endregion
    }
}
