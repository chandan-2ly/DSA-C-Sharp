namespace Splitwise.UserDetails
{
    public class FriendBalance
    {
        public double Owe { get; set; }
        public double GetBack { get; set; }

        public double Balance
        {
            get
            {
                return GetBack - Owe;
            }
        }
    }
}