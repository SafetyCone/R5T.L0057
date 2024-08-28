using System;
using System.Linq;

using R5T.L0066.Extensions;
using R5T.N0000;
using R5T.T0132;
using R5T.T0172.Extensions;
using R5T.T0180;


namespace R5T.L0057
{
    [FunctionalityMarker]
    public partial interface IAssemblyFilePathOperator : IFunctionalityMarker,
        L0056.IAssemblyFilePathOperator
    {
        public PairedAssemblyXmlDocumentionFilePaths Get_PairedAssemblyXmlDocumentationFilePaths(
            IDirectoryPath directoryPath)
        {
            var assemblyFilePathsHash = Instances.FileSystemOperator.Enumerate_DllFilePaths(
                directoryPath)
                .Select(x => x.Value.ToAssemblyFilePath())
                .ToHashSet();

            // Get all documentation files (assuming all XML files are documentation files).
            var documentationXmlFilePathsHash = Instances.DocumentationXmlFilePathOperator.Get_DocumentationXmlFilePaths_AssumeAllXmls(
                directoryPath)
                .ToHashSet();

            var documentationXmlFilePathsByAssemblyFilePath = assemblyFilePathsHash
                .ToDictionary(
                    x => x,
                    x => Instances.DocumentationXmlFilePathOperator.Get_DocumentationFilePath_ForAssemblyFilePath(x));

            var pairedFilePaths = documentationXmlFilePathsByAssemblyFilePath
                .Where(x => documentationXmlFilePathsHash.Contains(x.Value))
                .To_Dictionary();

            var unpairedAssemblyFilePaths = documentationXmlFilePathsByAssemblyFilePath
                .Where(x => !documentationXmlFilePathsHash.Contains(x.Value))
                .Select(x => x.Key)
                .ToHashSet();

            var output = new PairedAssemblyXmlDocumentionFilePaths
            {
                PairedFilePaths = pairedFilePaths,
                UnpairedAssemblyFilePaths = unpairedAssemblyFilePaths,
            };

            return output;
        }
    }
}
