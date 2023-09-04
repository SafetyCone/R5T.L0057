using System;

using R5T.T0132;


namespace R5T.L0057
{
    [FunctionalityMarker]
    public partial interface IExecutablePathOperator : IFunctionalityMarker,
        L0056.IExecutablePathOperator
    {
#pragma warning disable IDE1006 // Naming Styles
        public L0053.IExecutablePathOperator _Platform => L0053.ExecutablePathOperator.Instance;
#pragma warning restore IDE1006 // Naming Styles
    }
}
