using FinancialFlowManager.Domain.Core.Domain;

namespace FinancialFlowManager.Domain.Entities
{
    public class TypeFinancialAccount: Entity
    {
        public TypeFinancialAccount(string typeName,
                                    string descriptionType)
        {
            TypeName = typeName;
            DescriptionType = descriptionType;
        }

        public string TypeName { get; private set; }
        public string DescriptionType { get; private set; }

        public virtual ICollection<FinancialAccount> FinancialAccount { get; set; }
    }
}
