using Pirates;
using System;
using System.Collections.Generic;
using Units;
using UnityEngine;

namespace GameControls
{
    [Serializable]
    public class PirateFactory
    {
        public GamePirate CreateRandom()
        {
            GamePirate pirate = GameObject.Instantiate(GameUnitAssets.Pirate);
            pirate.Visuals.Set(UnitVisualSlotType.Hat, PirateVisualAssets.Hat.Random());
            pirate.Visuals.Set(UnitVisualSlotType.Clothing, PirateVisualAssets.Clothing.Random());
            pirate.Visuals.Set(UnitVisualSlotType.Head, PirateVisualAssets.Head.Random());
            pirate.Visuals.Set(UnitVisualSlotType.Face, PirateVisualAssets.Face.Random());

            return pirate;
        }
    }
}