using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(UWrapper), true)]
public class UWrapperDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        EditorGUI.BeginProperty(position, label, property);

        position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);

        var warpped = property.FindPropertyRelative("wrapped");
        EditorGUI.PropertyField(position, warpped, GUIContent.none);

        EditorGUI.EndProperty();
    }

}