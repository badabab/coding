#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Cat))]
public class CatInspector : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        Cat cat = (Cat)target;

        if (GUILayout.Button("Run"))
        {
            cat.Run();
        }

        if (GUILayout.Button("Sleep"))
        {
            cat.Sleep();
        }

        if (GUILayout.Button("Moew"))
        {
            cat.Meow();
        }

        if (GUILayout.Button("Print"))
        {
            cat.Print();
        }
    }
}
#endif