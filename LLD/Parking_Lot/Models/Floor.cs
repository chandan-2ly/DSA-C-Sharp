namespace Parking_Lot.Models
{
    public class Floor
    {
        public int Id { get; }
        public List<Slot> Slots { get; private set; }

        public Floor(int id, List<Slot> slots)
        {
            Id = id;
            Slots = slots;
        }

        

        public void AddSlot(Slot slot)
        {
           Slots.Add(slot);
        }

        public void RemoveSlot(int slotId)
        {
           Slots.Remove(Slots[slotId]);
        }

    }
}