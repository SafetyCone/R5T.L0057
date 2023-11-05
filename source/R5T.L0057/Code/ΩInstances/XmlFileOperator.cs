using System;


namespace R5T.L0057
{
    public class XmlFileOperator : IXmlFileOperator
    {
        #region Infrastructure

        public static IXmlFileOperator Instance { get; } = new XmlFileOperator();


        private XmlFileOperator()
        {
        }

        #endregion
    }
}
