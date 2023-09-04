using System;

using R5T.T0131;


namespace R5T.L0057
{
    [ValuesMarker]
    public partial interface IFilePaths : IValuesMarker,
        L0056.IFilePaths
    {
#pragma warning disable IDE1006 // Naming Styles
        public L0053.IFilePaths _Platform => L0053.FilePaths.Instance;
#pragma warning restore IDE1006 // Naming Styles
    }
}
