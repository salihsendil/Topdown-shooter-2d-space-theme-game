using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    [SerializeField] float loadSceneDelay = 2f;

    public void LoadGame(){
        SceneManager.LoadScene("Level0");
    }

    public void LoadMainMenu(){
        SceneManager.LoadScene("Start");
    }

    public void LoadGameOver(){
        StartCoroutine(WaitandLoad("End", loadSceneDelay));
    }
    public void QuitGame(){
        Debug.Log("Quitting...");
        Application.Quit();
    }

    IEnumerator WaitandLoad(string sceneName, float delay){
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(sceneName);
    }

}
