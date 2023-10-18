using System;
using System.Reflection;

using R5T.T0132;
using R5T.T0172;
using R5T.T0179.Extensions;


namespace R5T.L0057
{
    [FunctionalityMarker]
    public partial interface IReflectionOperator : IFunctionalityMarker,
        L0061.IReflectionOperator
    {
        public void In_AssemblyContext(
            IAssemblyFilePath assemblyFilePath,
            IAssemblyFilePath[] dependencyAssemblyFilePaths,
            Action<Assembly> action)
        {
            var dependencyAssemblyFilePathValues = dependencyAssemblyFilePaths.Get_Values();

            this.In_AssemblyContext(
                assemblyFilePath.Value,
                dependencyAssemblyFilePathValues,
                action);
        }
    }
}
