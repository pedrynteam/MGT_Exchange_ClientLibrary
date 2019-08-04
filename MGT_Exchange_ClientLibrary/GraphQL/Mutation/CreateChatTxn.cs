using MGT_Exchange_ClientLibrary.GraphQL.MVC;
using MGT_Exchange_ClientLibrary.GraphQL.Resources;
using SAHB.GraphQLClient.FieldBuilder.Attributes;

namespace MGT_Exchange_ClientLibrary.GraphQL.Mutation
{

    // 1. Create Model: Input type is used for Mutation, it should be included if needed
    public class CreateChatTxn_Input
    {
        public chat chat { get; set; }
    }

    // 2. Create Model: Output type is used for Mutation, it should be included if needed
    public class CreateChatTxn_Output
    {
        public resultConfirmation resultConfirmation { get; set; }
        public chat chat { get; set; }
    }

    public class CreateChatTxn
    {
        [GraphQLArguments("input", "CreateChatTxn_Input!", "inputVar")]
        public CreateChatTxn_Output createChatTxn { get; set; } //  // This is (ReturnType) (QueryName)
    }

}
