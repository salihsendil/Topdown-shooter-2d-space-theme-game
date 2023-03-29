using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    [SerializeField] float loadSceneDelay = 2f;
    ScoreKeeper scoreKeeper;

    private void Awake() {
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
    }

    public void LoadGame(){
        SceneManager.LoadScene("Level0");
        scoreKeeper.ResetScore();
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
