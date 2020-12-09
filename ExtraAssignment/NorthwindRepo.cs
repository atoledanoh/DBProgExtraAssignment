using System.Data;

namespace ExtraAssignment
{
    public interface NorthwindRepo
    {
        DataTable GetData(string sql);
        DataTable GetEmployees();
        DataTable GetOrders(int id);
    }
}
