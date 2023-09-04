using System;

using R5T.T0132;


namespace R5T.L0057
{
    [FunctionalityMarker]
    public partial interface IFileOperator : IFunctionalityMarker,
        L0056.IFileOperator
    {
#pragma warning disable IDE1006 // Naming Styles
        public L0053.IFileOperator _Platform => L0053.FileOperator.Instance;
#pragma warning restore IDE1006 // Naming Styles
    }
}
