namespace Parking_Lot.Models
{
    public class Floor
    {
        public int Id { get; }
        public Dictionary<VehicleType, Dictionary<int, Slot>> Slots { get; private set; }

        public Floor(int id, Dictionary<VehicleType, Dictionary<int, Slot>> slots)
        {
            Id = id;
            Slots = slots;
        }

        

        public void AddSlot(Slot slot)
        {
            if (Slots[slot.VehicleType] == null)
            {
                Slots[slot.VehicleType] = new Dictionary<int, Slot>();
            }
            Slots[slot.VehicleType][slot.Id] = slot;
        }

        public void RemoveSlot(int slotId)
        {
            var slot = Slots.Values.First(map => map.ContainsKey(slotId))[slotId];
            Slots[slot.VehicleType].Remove(slotId);
        }

    }
}