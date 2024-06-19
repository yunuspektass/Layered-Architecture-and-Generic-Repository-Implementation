using Project.DAL.Context;

namespace Project.BLL.DesignPatterns.SingletonPattern;

public class DBTool
{
    DBTool(){}

    private static MyContext _dbInstance;

    public static MyContext DbInstance
    {
        get
        {
            if (_dbInstance == null)
                _dbInstance = new MyContext();
            return _dbInstance; 
        }
    }
}