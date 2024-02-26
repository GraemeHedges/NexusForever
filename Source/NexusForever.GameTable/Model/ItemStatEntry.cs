using NexusForever.GameTable.Static;

namespace NexusForever.GameTable.Model
{
    public class ItemStatEntry
    {
        public uint Id { get; set; }
        [GameTableFieldArray(5u)]
        public ItemStatType[] ItemStatTypeEnum { get; set; }
        [GameTableFieldArray(5u)]
        public uint[] ItemStatData { get; set; }
    }
}
