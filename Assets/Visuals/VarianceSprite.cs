using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Visuals
{
    [CreateAssetMenu(fileName = "NewVarianceSprite", menuName = "PH/Crew/Variance Sprite")]
    public class VarianceSprite : ScriptableObject
    {
        [SerializeField] private Sprite sprite;
        public Sprite Sprite { get { return sprite; } }

        [SerializeField] private Gradient colorRange;
        public Gradient ColorRange { get { return colorRange; } }
    }
}