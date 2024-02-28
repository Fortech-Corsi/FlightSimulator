namespace CompanyService;

public class FlottaApi
{
    public long IdFlotta { get; set; }
    public List<AereoApi> Aerei { get; set; }

    public FlottaApi(long idFlotta, List<AereoApi> aerei)
    {
        IdFlotta = idFlotta;
        Aerei = aerei;
    }

    public static FlottaApi FlottaApiFactory(long idFlotta, List<AereoApi> aerei)
    {
        return new FlottaApi(idFlotta, aerei);
    }
}
