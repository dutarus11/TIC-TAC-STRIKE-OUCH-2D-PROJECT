using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class GameController : MonoBehaviour
{
    int spriteIndex = -1;
    
    public GameObject winUI;
    public GameObject loseUI;

    public int currentCount;
    
    public float timeRemaining;
    public bool timerActive = false;
    public Text timerTxt;

    private float minSec = 0;
    private float timeNum = 60;
    private float timeNum2 = 1;
    
    private void Start()
    {
        winUI.SetActive(false);
        loseUI.SetActive(false);
        timerActive = true;
    }
    private void Update()
    {
        Timer();
    }

    public int PlayerTurn()
    {
        spriteIndex++;
        return spriteIndex % 2;
    }

    //updates the object count 
    public void UpdateCount(int count)
    {
        currentCount -= count;       
    }

    //winning condition
    public void WinningUI()
    {                
        winUI.SetActive(true);                
    }

    //losing condition
    public void LosingUI()
    {
        loseUI.SetActive(true);
    }
   
    //the timer
    public void Timer()
    {
        if (timerActive)
        {
            if (timeRemaining > minSec)
            {
                timeRemaining -= Time.deltaTime;
                UpdateTimer(timeRemaining);
            }
            else
            {
                Debug.Log("Your time is up! HAHAHAHAHA!");
                timeRemaining = minSec;
                timerActive = false; 
            }
        }

        void UpdateTimer(float currentTime)
        {
            currentTime += timeNum2;
            float mins = Mathf.FloorToInt(currentTime / timeNum);
            float secs = Mathf.FloorToInt(currentTime % timeNum);
            timerTxt.text = string.Format("{0:00} : {1:00}", mins, secs);
        }
    }
}
