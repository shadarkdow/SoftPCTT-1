namespace webapi.Models;

public class BaseRepository 
{
    protected DemoContext context;

    public BaseRepository(DemoContext context) => this.context = context;
}