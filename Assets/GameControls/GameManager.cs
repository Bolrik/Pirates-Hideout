using Pirates;
using Player;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Units;
using UnityEngine;

namespace GameControls
{
    public class GameManager : MonoBehaviour
    {
        #region Singleton Pattern		
        public static GameManager Instance { get; private set; }

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

        public PlayerController Player { get; set; }

        PirateFactory pirateFactory = new PirateFactory();
        public static PirateFactory PirateFactory
        {
            get { return Instance.pirateFactory; }
            private set { Instance.pirateFactory = value; }
        }

        private void Update()
        {
            this.DebugControlls();
        }


        GamePirate DebugUnit { get; set; }
        void DebugControlls()
        {
#warning DEBUG
            if (Input.GetKeyDown(KeyCode.Return))
            {
                if (this.DebugUnit != null)
                {
                    Destroy(this.DebugUnit.gameObject);
                }

                this.DebugUnit = GameManager.PirateFactory.CreateRandom();
            }
        }
    }
}