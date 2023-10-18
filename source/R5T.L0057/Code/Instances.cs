using System;


namespace R5T.L0057
{
    public static class Instances
    {
        public static IDocumentationXmlFilePathOperator DocumentationXmlFilePathOperator => L0057.DocumentationXmlFilePathOperator.Instance;
        public static IExecutablePathOperator ExecutablePathOperator => L0057.ExecutablePathOperator.Instance;
        public static IFileSystemOperator FileSystemOperator => L0057.FileSystemOperator.Instance;
        //public static F0040.IProjectPathsOperator ProjectPathsOperator => F0040.ProjectPathsOperator.Instance;
        public static IRuntimeEnvironmentOperator RuntimeEnvironmentOperator => L0057.RuntimeEnvironmentOperator.Instance;
    }
}