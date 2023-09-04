using System;

using R5T.T0132;


namespace R5T.L0057
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker
    {
#pragma warning disable IDE1006 // Naming Styles
        public L0053.IStringOperator _Platform => L0053.StringOperator.Instance;
#pragma warning restore IDE1006 // Naming Styles
    }
}
