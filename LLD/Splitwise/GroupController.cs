namespace Splitwise
{
    public class GroupController
    {
        List<Group> Groups;

        public GroupController()
        {
            Groups = new List<Group>();
        }

        public List<Group> GetGroups() => Groups;

        public Group GetGroup(int id) => Groups.Find(x => x.Id == id);

        public void AddGroup(Group group)
        {
            Groups.Add(group);
        }
    }
}
