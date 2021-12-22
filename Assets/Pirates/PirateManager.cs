using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pirates
{
    public class PirateManager : MonoBehaviour
    {
        #region Singleton Pattern		
        static PirateManager Instance { get; set; }

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

            if (!Application.isEditor)
                DontDestroyOnLoad(this.gameObject);

            this.AwakeInit();
        }

        void AwakeInit()
        {
            // ToDo
        }

        void Start()
        {
            this.StartInit();
        }

        private void StartInit()
        {
            // ToDo
        }
        #endregion


        [SerializeField] private Pirate pirate;
        public static Pirate Pirate { get { return Instance.pirate; } }


        public static Pirate Create()
        {
            Pirate pirate = Instantiate(Pirate);
            pirate.Visuals.HatRenderer.Set(PirateVisualAsstesManager.Hats.Random());


            return pirate;
        }
    }
}