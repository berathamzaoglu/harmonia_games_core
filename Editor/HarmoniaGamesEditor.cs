
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.VersionControl;
using UnityEngine;

public class HarmoniaGamesEditor : EditorWindow
{


    [MenuItem("Harmonia Games/Edit Settings")]
    public static void Settings()
    {

    }

    [MenuItem("Harmonia Games/Documentation")]
    public static void OpenDocumentation()
    {
        Application.OpenURL("https://drive.google.com/drive/folders/1esGB9DbJRtDhdIj3zpyri1tUDhgvRyCI?usp=sharing");
    }

    /*
        [MenuItem("Harmonia Games/Edit Settings")]
        public static void Settings()
        {
            var settings = Resources.Load<HarmoniaGamesSettings>("HarmoniaSettings");

            if (settings == null)
            {
                settings = ScriptableObject.CreateInstance<HarmoniaGamesSettings>();

                string path = "Assets/HarmoniaGames/Resources";

                if (!AssetDatabase.IsValidFolder(path))
                {
                    AssetDatabase.CreateFolder("HarmoniaGames", "Resources");
                }

                string assetPathAndName = AssetDatabase.GenerateUniqueAssetPath(path + "/HarmoniaSettings.asset");

                AssetDatabase.CreateAsset(settings, assetPathAndName);

                AssetDatabase.SaveAssets();
                AssetDatabase.Refresh();
            }

            EditorUtility.FocusProjectWindow();
            Selection.activeObject = settings;
        }


        [MenuItem("Harmonia Games/Elephant Settings")]
        public static void ElephantSettings()
        {
            var settings = Resources.Load<ElephantSettings>("ElephantSettings");

          /*  if (settings == null)
            {
                settings = ScriptableObject.CreateInstance<HarmoniaGamesSettings>();

                string path = "Assets/HarmoniaGames/Resources";

                if (!AssetDatabase.IsValidFolder(path))
                {
                    AssetDatabase.CreateFolder("HarmoniaGames", "Resources");
                }

                string assetPathAndName = AssetDatabase.GenerateUniqueAssetPath(path + "/HarmoniaSettings.asset");

                AssetDatabase.CreateAsset(settings, assetPathAndName);

                AssetDatabase.SaveAssets();
                AssetDatabase.Refresh();
            }

            EditorUtility.FocusProjectWindow();
            Selection.activeObject = settings;
        }
    */

}

