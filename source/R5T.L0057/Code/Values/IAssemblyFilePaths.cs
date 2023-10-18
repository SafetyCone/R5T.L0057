using System;

using R5T.T0131;
using R5T.T0172;

namespace R5T.L0057
{
    [ValuesMarker]
    public partial interface IAssemblyFilePaths : IValuesMarker
    {
        /// <inheritdoc cref="L0056.IRuntimeEnvironmentOperator.Get_CurrentlyExecutingRuntime_CoreAssemblyFilePath"/>
        public IAssemblyFilePath Core => Instances.RuntimeEnvironmentOperator.Get_CurrentlyExecutingRuntime_CoreAssemblyFilePath();

        /// <summary>
        /// Gets the path of the currently executing assembly.
        /// </summary>
        public IAssemblyFilePath Executable => Instances.ExecutablePathOperator.Get_ExecutableFilePath();
    }
}
