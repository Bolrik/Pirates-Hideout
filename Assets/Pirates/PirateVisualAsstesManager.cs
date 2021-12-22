using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Visuals;

namespace Pirates
{
    public class PirateVisualAsstesManager : MonoBehaviour
    {
        #region Singleton Pattern		
        static PirateVisualAsstesManager Instance { get; set; }

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

        [SerializeField] private VarianceSprite[] hats;
        public static VarianceSprite[] Hats { get { return Instance.hats; } }

    }
}