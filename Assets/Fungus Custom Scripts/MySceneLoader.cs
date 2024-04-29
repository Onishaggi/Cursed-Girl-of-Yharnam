using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


[CommandInfo("Custom", "Exist Game", "Exist the Game")]
[AddComponentMenu("")]
public class MySceneLoader : Command
{
    //[SerializeField] int _sceneId;

    // Function to load the scene
    public override void OnEnter()
    {
        base.OnEnter();
        Application.Quit();

        Continue();
    }
    public void LoadScene()
    {
        //SceneManager.LoadScene(_sceneId);
        
    
    }
}
