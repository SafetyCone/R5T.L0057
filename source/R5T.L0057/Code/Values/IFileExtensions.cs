using System;

using R5T.T0131;


namespace R5T.L0057
{
    [ValuesMarker]
    public partial interface IFileExtensions : IValuesMarker,
        L0056.IFileExtensions
    {
#pragma warning disable IDE1006 // Naming Styles
        public L0053.IFileExtensions _Platform => L0053.FileExtensions.Instance;
#pragma warning restore IDE1006 // Naming Styles
    }
}
