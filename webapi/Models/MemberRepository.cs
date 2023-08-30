namespace webapi.Models;

public class MemberRepository : BaseRepository
{
    public MemberRepository(DemoContext context) : base(context){}

    public List<Member> GetMembers(){
        return context.members.ToList();
    }
}