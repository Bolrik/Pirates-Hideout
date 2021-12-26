using GameControls;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Pirates
{
    [CustomEditor(typeof(PirateFactory))]
    public class PirateFactoryEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            GUILayout.Label("Create Pirates");

            if (!Application.isPlaying)
            {
                if (GUILayout.Button("*Inactive* - Generate Pirate"))
                    Debug.LogWarning("Only available in Play-Mode.");
                return;
            }

            if (GUILayout.Button("Generate Pirate"))
            {

            }
        }
    }
}