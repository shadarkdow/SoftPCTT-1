namespace webapi.Models;

public class SiteProvider : BaseRepository
{
    public SiteProvider(DemoContext context) : base(context){ }

    MemberRepository member = null!;
    public MemberRepository Member => member ??= new MemberRepository(context);
}