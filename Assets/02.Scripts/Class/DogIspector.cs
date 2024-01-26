#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Dog))]
public class DogInspector : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        Dog dog = (Dog)target;

        if (GUILayout.Button("Run"))
        {
            dog.Run();
        }

        if (GUILayout.Button("Sleep"))
        {
            dog.Sleep();
        }

        if (GUILayout.Button("Bark"))
        {
            dog.Bark();
        }

        if (GUILayout.Button("Print"))
        {
            dog.Print();
        }
    }
}
#endif