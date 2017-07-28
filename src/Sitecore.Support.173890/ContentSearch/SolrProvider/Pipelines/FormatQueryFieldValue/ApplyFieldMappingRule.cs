namespace Sitecore.Support.ContentSearch.SolrProvider.Pipelines.FormatQueryFieldValue
{
    using Sitecore.ContentSearch.Pipelines.FormatQueryFieldValue;
    public class ApplyFieldMappingRule : Sitecore.ContentSearch.SolrProvider.Pipelines.FormatQueryFieldValue.ApplyFieldMappingRule
    {
        protected override void FormatArgs(string schemaType, FormatQueryFieldValueArgs args)
        {
            string schemaTypeToLower = schemaType.ToLower();
            if (schemaTypeToLower == "datetime" || schemaTypeToLower == "tdate" || schemaTypeToLower == "date")
            {
                args.FieldValue = Escape(args.FieldValue, "", true, args.ExcludeEscapeCharacters);
                return;
            }
            base.FormatArgs(schemaType, args);
        }
    }
}