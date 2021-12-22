using UnityEngine;
using Visuals;

namespace Pirates
{
    public class Pirate : MonoBehaviour
    {
        #region Values
        public Hat Hat { get; private set; }
        #endregion

        #region Editor

        [SerializeField] private PirateVisuals visuals;
        public PirateVisuals Visuals { get { return visuals; } }

        #endregion
    }

    [System.Serializable]
    public class PirateVisuals
    {
        [SerializeField] private VarianceSpriteRenderer bodyRenderer;
        public VarianceSpriteRenderer BodyRenderer { get { return bodyRenderer; } }

        [SerializeField] private VarianceSpriteRenderer clothingRenderer;
        public VarianceSpriteRenderer ClothingRenderer { get { return clothingRenderer; } }

        [SerializeField] private VarianceSpriteRenderer headRenderer;
        public VarianceSpriteRenderer HeadRenderer { get { return headRenderer; } }

        [SerializeField] private VarianceSpriteRenderer leftHandRenderer;
        public VarianceSpriteRenderer LeftHandRenderer { get { return leftHandRenderer; } }

        [SerializeField] private VarianceSpriteRenderer rightHandRenderer;
        public VarianceSpriteRenderer RightHandRenderer { get { return rightHandRenderer; } }

        [SerializeField] private VarianceSpriteRenderer hatRenderer;
        public VarianceSpriteRenderer HatRenderer { get { return hatRenderer; } }
    }
}