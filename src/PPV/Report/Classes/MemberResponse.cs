namespace Report.Classes
{
    public class MemberResponse
    {
        public MemberClassification Status { get; set; }
        public string Description { get; set; }
    }

    public enum MemberClassification
    {
        DidNot = 0,
        Weak = 1,
        Good = 2,
        Intense = 3
    }
}
