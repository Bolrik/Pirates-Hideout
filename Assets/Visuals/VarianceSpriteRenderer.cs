using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Visuals
{
    [RequireComponent(typeof(SpriteRenderer))]
    public class VarianceSpriteRenderer : MonoBehaviour
    {
        [SerializeField] private SpriteRenderer spriteRenderer;
        public SpriteRenderer SpriteRenderer { get { return spriteRenderer; } }

        public float ColorIndex { get; private set; }

        public VarianceSprite VarianceSprite { get; private set; }


        public void Set(VarianceSprite varianceSprite)
        {
            this.Set(varianceSprite, Random.value);
        }

        public void Set(VarianceSprite varianceSprite, float colorIndex)
        {
            this.VarianceSprite = varianceSprite;
            this.ColorIndex = colorIndex;

            if (this.VarianceSprite == null)
            {
                this.SpriteRenderer.sprite = null;
                return;
            }

            this.SpriteRenderer.sprite = this.VarianceSprite.Sprite;
            this.SpriteRenderer.color = this.VarianceSprite.ColorRange.Evaluate(this.ColorIndex);
        }
    }
}