using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Turn : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    GameObject gameBoard;
    GameController gameController;
       
    public GameObject vfx;
      
    public int count;
    
    public Sprite[] images;
   
    public AudioSource audioSourceSFX;

    private float minTime = 0;
    private float seconds = 3;

    bool nonPlayed = true;
    
    private void Start()
    {
        spriteRenderer.sprite = null;
        vfx.SetActive(false);               
    }

    private void OnMouseDown()
    {
        if (nonPlayed)
        {
            int index = gameBoard.GetComponent<GameController>().PlayerTurn();
            spriteRenderer.sprite = images[index];
            nonPlayed = false;           
        }
        
        vfx.SetActive(true);        
       
        AudioSFX();
                
        gameController.UpdateCount(count);
        
        if (gameController.currentCount == minTime && gameController.timeRemaining > minTime)
        {
            gameController.WinningUI();
            StartCoroutine(ResetCoroutine());
        }
        else if(gameController.currentCount >= minTime && gameController.timeRemaining <= minTime)
        {
            gameController.LosingUI();
            StartCoroutine(ResetCoroutine());
        }
    }
    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        gameBoard = GameObject.Find("GameBoard");
        gameController = GameObject.FindObjectOfType<GameController>();
    }

    //reset the game 
    IEnumerator ResetCoroutine()
    {
        yield return new WaitForSeconds(seconds);
        ResetGame();
    }
    public void ResetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    //sound effect
    public void AudioSFX()
    {
        audioSourceSFX.Play();
        Debug.Log("sfx in effect");
    }
}
