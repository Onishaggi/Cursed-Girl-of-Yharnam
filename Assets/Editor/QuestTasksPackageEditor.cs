using UnityEngine;
using UnityEditor;
using System.Collections.Generic;

[CustomEditor(typeof(QuestTasksPackage))]
public class QuestTasksPackageEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        QuestTasksPackage questTasksPackage = (QuestTasksPackage)target;

        EditorGUILayout.Space();

        
        if (GUILayout.Button("Add Go To Location Task"))
        {
            GoToLocType newTask = CreateInstance<GoToLocType>();
            AssetDatabase.AddObjectToAsset(newTask, questTasksPackage);
            questTasksPackage.GoToLocTypes.Add(newTask);
            EditorUtility.SetDirty(questTasksPackage);
        }

        if (GUILayout.Button("Add Talk To NPC Task"))
        {
            TalkToNPCTask newTask = CreateInstance<TalkToNPCTask>();
            AssetDatabase.AddObjectToAsset(newTask, questTasksPackage);
            questTasksPackage.TalkToNPCTasks.Add(newTask);
            EditorUtility.SetDirty(questTasksPackage);
        }

        if (GUILayout.Button("Add Find Object Task"))
        {
            FindObjectTask newTask = CreateInstance<FindObjectTask>();
            AssetDatabase.AddObjectToAsset(newTask, questTasksPackage);
            questTasksPackage.FindObjectTasks.Add(newTask);
            EditorUtility.SetDirty(questTasksPackage);
        }

        if (GUILayout.Button("Add Eliminate Enemies Task"))
        {
            EliminateEnemiesTask newTask = CreateInstance<EliminateEnemiesTask>();
            AssetDatabase.AddObjectToAsset(newTask, questTasksPackage);
            questTasksPackage.EleminateEnemiesTasks.Add(newTask);
            EditorUtility.SetDirty(questTasksPackage);
        }
    }
}