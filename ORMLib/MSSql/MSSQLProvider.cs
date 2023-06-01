namespace ORMLib.MSSql;

using ORMLib.Providers;
public class MSSqlProvider : IAccessProvider
{
    public Access Provide()
    => new SqlAccess();
}