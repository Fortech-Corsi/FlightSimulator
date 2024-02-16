using Microsoft.EntityFrameworkCore;

namespace CompanyService;

public class FlightSimulatorDBContext : DbContext
{
    public FlightSimulatorDBContext(DbContextOptions<FlightSimulatorDBContext> options) : base(options)
    {

    }
}
