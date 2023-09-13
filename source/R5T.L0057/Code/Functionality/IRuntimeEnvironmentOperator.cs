using System;

using R5T.T0132;


namespace R5T.L0057
{
    [FunctionalityMarker]
    public partial interface IRuntimeEnvironmentOperator : IFunctionalityMarker,
        L0056.IRuntimeEnvironmentOperator
    {
#pragma warning disable IDE1006 // Naming Styles
        public L0053.IRuntimeEnvironmentOperator _Platform => L0053.RuntimeEnvironmentOperator.Instance;
#pragma warning restore IDE1006 // Naming Styles
    }
}
