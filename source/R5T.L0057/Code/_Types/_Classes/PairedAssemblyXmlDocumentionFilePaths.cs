using System;
using System.Collections.Generic;

using R5T.T0142;
using R5T.T0172;


namespace R5T.N0000
{
    /// <summary>
    /// Provides assembly file path-documentation file path pairs, as well as the set of unpaired assembly file paths (assemblies without a complementary documentation file path).
    /// </summary>
    /// <remarks>
    /// This is useful as the output of an operation to get all assembly and documentation files in a directory, or in the directory of an assembly.
    /// </remarks>
    [DataTypeMarker]
    public class PairedAssemblyXmlDocumentionFilePaths
    {
        /// <summary>
        /// Assembly file-documentation file path pairs.
        /// </summary>
        public Dictionary<IAssemblyFilePath, IDocumentationXmlFilePath> PairedFilePaths { get; set; }

        /// <summary>
        /// Assembly file paths for assemblies without paired documentation file path pairs.
        /// </summary>
        public HashSet<IAssemblyFilePath> UnpairedAssemblyFilePaths { get; set; }
    }
}
