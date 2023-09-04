using System;

using R5T.T0132;


namespace R5T.L0057
{
    [FunctionalityMarker]
    public partial interface IFileStreamOperator : IFunctionalityMarker,
        L0056.IFileStreamOperator
    {
#pragma warning disable IDE1006 // Naming Styles
        public L0053.IFileStreamOperator _Platform => L0053.FileStreamOperator.Instance;
#pragma warning restore IDE1006 // Naming Styles
    }
}
