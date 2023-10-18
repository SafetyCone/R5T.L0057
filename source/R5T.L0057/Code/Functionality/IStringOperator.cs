using System;

using R5T.T0132;


namespace R5T.L0057
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker,
        // Is-a instead of has-a since all the string inputs are platform types.
        L0053.IStringOperator
    {

    }
}
