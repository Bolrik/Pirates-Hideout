using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Units
{
    public class GameUnit<UnitType> : MonoBehaviour
    {
        [SerializeField] private GameUnitVisuals visuals;
        public GameUnitVisuals Visuals { get { return visuals; } private set { visuals = value; } }

        public Unit Unit { get; private set; }
    }
}