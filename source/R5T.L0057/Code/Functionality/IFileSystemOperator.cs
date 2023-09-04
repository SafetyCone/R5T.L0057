using System;

using R5T.T0132;


namespace R5T.L0057
{
    [FunctionalityMarker]
    public partial interface IFileSystemOperator : IFunctionalityMarker,
        // Strongly-typed.
        L0056.IFileSystemOperator
    {
#pragma warning disable IDE1006 // Naming Styles
        // String-based (platform).
        public L0053.IFileSystemOperator _Platform => L0053.FileSystemOperator.Instance;
#pragma warning restore IDE1006 // Naming Styles
    }
}
