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
            DontDestroyOnLoad(this.gameObject);
        }
        #endregion


    }
}