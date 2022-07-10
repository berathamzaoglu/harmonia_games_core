using UnityEngine;
using UnityEditor;


class HGPackageManager : EditorWindow
{


   

    [MenuItem("Harmonia Games/HG Package Manager")]


    static void Init()
    {

        GetWindow<HGPackageManager>().Show();
    }

    void OnGUI()
    {

     

        GUILayout.BeginVertical();
        {
            // Display options to import Essential resources
            GUILayout.BeginVertical(EditorStyles.helpBox);
            {
                GUILayout.Label("Inter-Scene Level Manager System ", EditorStyles.boldLabel);
                GUILayout.Label("This appears to be the first time you access TextMesh Pro, as such we need to add resources to your project that are essential for using TextMesh Pro. These new resources will be placed at the root of your project in the \"TextMesh Pro\" folder.", new GUIStyle(EditorStyles.label) { wordWrap = true });
                GUILayout.Space(5f);

                // GUI.enabled = !m_EssentialResourcesImported;

                GUILayout.BeginHorizontal();

                if (GUILayout.Button("Document"))
                {
                    Application.OpenURL("http://unity3d.com/");
                }

                if (GUILayout.Button("Import"))
                {


                }

                GUILayout.EndHorizontal();
                GUILayout.Space(5f);
                GUI.enabled = true;
            }
            GUILayout.EndVertical();

            GUILayout.BeginVertical(EditorStyles.helpBox);
            {
                GUILayout.Label("Single-Scene Level Manager System ", EditorStyles.boldLabel);
                GUILayout.Label("This appears to be the first time you access TextMesh Pro, as such we need to add resources to your project that are essential for using TextMesh Pro. These new resources will be placed at the root of your project in the \"TextMesh Pro\" folder.", new GUIStyle(EditorStyles.label) { wordWrap = true });
                GUILayout.Space(5f);

                // GUI.enabled = !m_EssentialResourcesImported;

                GUILayout.BeginHorizontal();

                if (GUILayout.Button("Document"))
                {
                    Application.OpenURL("http://unity3d.com/");
                }

                if (GUILayout.Button("Import"))
                {


                }

                GUILayout.EndHorizontal();
                GUILayout.Space(5f);
                GUI.enabled = true;  
            }
            GUILayout.EndVertical();


            GUILayout.BeginVertical(EditorStyles.helpBox);
            {
                GUILayout.Label("Runner Template", EditorStyles.boldLabel);
                GUILayout.Label("This appears to be the first time you access TextMesh Pro, as such we need to add resources to your project that are essential for using TextMesh Pro. These new resources will be placed at the root of your project in the \"TextMesh Pro\" folder.", new GUIStyle(EditorStyles.label) { wordWrap = true });
                GUILayout.Space(5f);

                // GUI.enabled = !m_EssentialResourcesImported;

                GUILayout.BeginHorizontal();

                if (GUILayout.Button("Document"))
                {
                    Application.OpenURL("http://unity3d.com/");
                }

                if (GUILayout.Button("Import"))
                {


                }

                GUILayout.EndHorizontal();
                GUILayout.Space(5f);
                GUI.enabled = true;
            }
            GUILayout.EndVertical();




            GUILayout.BeginVertical(EditorStyles.helpBox);
            {
                GUILayout.Label("Arcade-Idle Template", EditorStyles.boldLabel);
                GUILayout.Label("This appears to be the first time you access TextMesh Pro, as such we need to add resources to your project that are essential for using TextMesh Pro. These new resources will be placed at the root of your project in the \"TextMesh Pro\" folder.", new GUIStyle(EditorStyles.label) { wordWrap = true });
                GUILayout.Space(5f);

                // GUI.enabled = !m_EssentialResourcesImported;

                GUILayout.BeginHorizontal();

                if (GUILayout.Button("Document"))
                {
                    Application.OpenURL("http://unity3d.com/");
                }

                if (GUILayout.Button("Import"))
                {


                }

                GUILayout.EndHorizontal();
                GUILayout.Space(5f);
                GUI.enabled = true;
            }
            GUILayout.EndVertical();
        }
            GUILayout.EndVertical();

        
    }



}
