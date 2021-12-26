using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Visuals
{
    [System.Serializable]
    public class VarianceSpriteGroup
    {


        [SerializeField] private VarianceSprite[] sprites;
        public VarianceSprite[] Sprites { get { return sprites; } }

    }
}