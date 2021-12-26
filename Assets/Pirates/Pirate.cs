using Units;
using UnityEngine;
using Visuals;

namespace Pirates
{
    public class Pirate : Unit
    {
        #region Values
        public Hat Hat { get; private set; }
        #endregion
    }

    //[System.Serializable]
    //public class GamePirateVisuals : GameUnitVisuals
    //{
    //    [SerializeField] private VarianceSpriteRenderer bodyRenderer;
    //    public VarianceSpriteRenderer BodyRenderer { get { return bodyRenderer; } }

    //    [SerializeField] private VarianceSpriteRenderer clothingRenderer;
    //    public VarianceSpriteRenderer ClothingRenderer { get { return clothingRenderer; } }

    //    [SerializeField] private VarianceSpriteRenderer headRenderer;
    //    public VarianceSpriteRenderer HeadRenderer { get { return headRenderer; } }

    //    [SerializeField] private VarianceSpriteRenderer leftHandRenderer;
    //    public VarianceSpriteRenderer LeftHandRenderer { get { return leftHandRenderer; } }

    //    [SerializeField] private VarianceSpriteRenderer rightHandRenderer;
    //    public VarianceSpriteRenderer RightHandRenderer { get { return rightHandRenderer; } }

    //    [SerializeField] private VarianceSpriteRenderer hatRenderer;
    //    public VarianceSpriteRenderer HatRenderer { get { return hatRenderer; } }
    //}
}