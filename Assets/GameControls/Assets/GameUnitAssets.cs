using Pirates;
using UnityEngine;

namespace GameControls
{
    public class GameUnitAssets : MonoBehaviour
    {
        #region Singleton Pattern		
        static GameUnitAssets Instance { get; set; }

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

        [SerializeField] private GamePirate pirate;
        public static GamePirate Pirate { get { return Instance.pirate; } }
    }
}