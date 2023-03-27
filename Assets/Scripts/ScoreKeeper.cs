using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    [SerializeField] int currentScore;

    public int GetCurrentScore(){
        return currentScore;
    }

    public void ModifyScore(int value){
        currentScore += value;
        Mathf.Clamp(currentScore, 0, int.MaxValue);
    }

    public void ResetScore(){
        currentScore = 0;
    }
}
