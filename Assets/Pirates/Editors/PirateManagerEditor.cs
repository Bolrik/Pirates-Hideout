using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Pirates
{
    [CustomEditor(typeof(PirateManager))]
    public class PirateManagerEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            if (!Application.isPlaying)
                return;

            if (GUILayout.Button("Generate Pirate"))
            {
                Pirate pirate = PirateManager.Create();
            }
        }
    }
}