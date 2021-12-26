using Pirates;
using UnityEngine;
using Visuals;
using System.Collections.Generic;
using Units;

namespace GameControls
{
    public class PirateVisualAssets : MonoBehaviour
    {
        #region Singleton Pattern		
        static PirateVisualAssets Instance { get; set; }

        private void Awake()
        {
            if (Instance != null)
            {
                if (Instance == this)
                    return;

                Destroy(this);
                return;
            }

            Instance = this;
        }
        #endregion

        [SerializeField] private VarianceSprite[] hat;
        public static VarianceSprite[] Hat { get { return Instance.hat; } }

        [SerializeField] private VarianceSprite[] clothing;
        public static VarianceSprite[] Clothing { get { return Instance.clothing; } }

        [SerializeField] private VarianceSprite[] head;
        public static VarianceSprite[] Head { get { return Instance.head; } }

        [SerializeField] private VarianceSprite[] face;
        public static VarianceSprite[] Face { get { return Instance.face; } }

    }
}