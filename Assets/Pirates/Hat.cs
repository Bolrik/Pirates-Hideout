using UnityEngine;
using Visuals;

namespace Pirates
{
    public class Hat
    {
        [SerializeField] private Sprite sprite;
        public Sprite Sprite { get { return sprite; } private set { sprite = value; } }

        [SerializeField] private Color color;
        public Color Color { get { return color; } private set { color = value; } }

        public Hat(VarianceSprite hatVarianceSprite)
        {
            this.Sprite = hatVarianceSprite.Sprite;
            this.Color = hatVarianceSprite.ColorRange.Evaluate(Random.value);
        }
    }
}