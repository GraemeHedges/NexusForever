namespace NexusForever.GameTable
{
    [AttributeUsage(AttributeTargets.Property)]
    public class GameTableFieldArrayAttribute : Attribute
    {
        public uint Length { get; }

        public GameTableFieldArrayAttribute(uint length)
        {
            Length = length;
        }
    }
}
