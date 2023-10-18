using System;


namespace R5T.L0057
{
    public class PublishConventionOperator : IPublishConventionOperator
    {
        #region Infrastructure

        public static IPublishConventionOperator Instance { get; } = new PublishConventionOperator();


        private PublishConventionOperator()
        {
        }

        #endregion
    }
}
