using System;


namespace R5T.L0057
{
    public class AssemblyFilePaths : IAssemblyFilePaths
    {
        #region Infrastructure

        public static IAssemblyFilePaths Instance { get; } = new AssemblyFilePaths();


        private AssemblyFilePaths()
        {
        }

        #endregion
    }
}
