using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeViews : MonoBehaviour
{
    // Open scene with given name in the same scene
    [SerializeField] private string sceneName;

    public void OpenScene(string sceneName)
    {
        if (sceneName == "") {
            sceneName = "TestMap";
        }
        SceneManager.LoadScene(sceneName);
    }
}
