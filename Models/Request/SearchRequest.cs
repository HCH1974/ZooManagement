namespace ZooManagement.Models.Request
{
    public class SearchRequest
    {
        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 10;
        public virtual string Filters => "";
    }

    public class AnimalSearchRequest : SearchRequest
    {
        public string? SpeciesName { get; set; }
        public string? Classification { get; set; }
        public override string Filters
        {
            get
            {
                var filters = "";

                if (SpeciesName != null)
                {
                    filters += $"&speciesName={SpeciesName}";
                }

                if (Classification != null)
                {
                    filters += $"Classification={Classification}";
                }
                return filters;
            }
        }
    }
}