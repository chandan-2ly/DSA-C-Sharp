using System.Diagnostics.CodeAnalysis;

namespace Splitwise.UserDetails
{
    public class UserComparable : IEqualityComparer<User>
    {
        public bool Equals(User? x, User? y)
        {
            return x?.Id == y?.Id;
        }

        public int GetHashCode([DisallowNull] User obj)
        {
            return obj.Id.GetHashCode();
        }
    }
}