using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace Visuals
{
    public class VarianceSpriteEditorWindow : EditorWindow
    {
        [MenuItem("Tools/Sprite/VarianceSprite")]
        public static void ShowWindow()
        {
            GetWindow<VarianceSpriteEditorWindow>();
        }

        private void OnGUI()
        {
            GUILayout.Label("Preview", EditorStyles.boldLabel);

            if (Selection.activeObject is VarianceSprite varianceSprite)
            {
                GUILayout.Box(varianceSprite.Sprite.texture, EditorStyles.inspectorFullWidthMargins);
            }
            else
                GUILayout.Label($"Select a {nameof(VarianceSprite)}");
        }
    }
}