using System;

using R5T.T0132;


namespace R5T.L0057
{
    [FunctionalityMarker]
    public partial interface IAssemblyOperator : IFunctionalityMarker,
        L0056.IAssemblyOperator
    {
#pragma warning disable IDE1006 // Naming Styles
        public L0053.IAssemblyOperator _Platform => L0053.AssemblyOperator.Instance;
#pragma warning restore IDE1006 // Naming Styles
    }
}
