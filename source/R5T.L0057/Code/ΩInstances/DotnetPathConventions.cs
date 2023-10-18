using System;


namespace R5T.L0057
{
    public class DotnetPathConventions : IDotnetPathConventions
    {
        #region Infrastructure

        public static IDotnetPathConventions Instance { get; } = new DotnetPathConventions();


        private DotnetPathConventions()
        {
        }

        #endregion
    }
}
