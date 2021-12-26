using UnityEngine;
using Visuals;

namespace Units
{
    [System.Serializable]
    public class GameUnitVisuals
    {
        [SerializeField] private UnitVisualSlot[] visualSlots;
        public UnitVisualSlot[] VisualSlots { get { return visualSlots; } }


        public void Set(UnitVisualSlotType type, VarianceSprite varianceSprite)
        {
            this.Set(type, varianceSprite, UnityEngine.Random.value);
        }
        public void Set(UnitVisualSlotType type, VarianceSprite varianceSprite, float colorIndex)
        {
            foreach (var visualSlot in this.VisualSlots)
            {
                if (visualSlot.Type == type)
                    visualSlot.Renderer.Set(varianceSprite, colorIndex);
            }
        }
    }
}