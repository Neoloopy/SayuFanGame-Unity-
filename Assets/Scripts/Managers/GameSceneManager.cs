using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneManager : MonoBehaviour
{
    [SerializeField] int _scene;
    void ChangeScene()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(_scene);
    }
    void SceneTransitions(){
        // TODO: Create an animated scene transition
        // Create an In and out transition sequence
    }
}
