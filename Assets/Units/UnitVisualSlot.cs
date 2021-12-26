using System;
using UnityEngine;
using Visuals;

namespace Units
{
    [Serializable]
    public class UnitVisualSlot
    {
        [SerializeField] private UnitVisualSlotType type;
        public UnitVisualSlotType Type { get { return type; } }

        [SerializeField] private VarianceSpriteRenderer renderer;
        public VarianceSpriteRenderer Renderer { get { return renderer; } }
    }
}