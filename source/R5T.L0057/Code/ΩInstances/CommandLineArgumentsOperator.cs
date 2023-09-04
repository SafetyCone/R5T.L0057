using System;


namespace R5T.L0057
{
    public class CommandLineArgumentsOperator : ICommandLineArgumentsOperator
    {
        #region Infrastructure

        public static ICommandLineArgumentsOperator Instance { get; } = new CommandLineArgumentsOperator();


        private CommandLineArgumentsOperator()
        {
        }

        #endregion
    }
}
