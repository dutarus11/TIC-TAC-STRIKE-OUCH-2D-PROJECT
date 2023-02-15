using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turn : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    GameObject gameBoard;
    GameController gameController;


    [SerializeField]
    public GameObject vfx;
    [SerializeField]
    public int count;
       
    public Sprite[] images;
   
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
        gameController.UpdateCount(count);
        
        if (gameController.currentCount == 0 && gameController.timeRemaining > 0)
        {
            gameController.WinningUI();
        }
        else if(gameController.currentCount >= 0 && gameController.timeRemaining <= 0)
        {
            gameController.LosingUI();
        }
    }
    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        gameBoard = GameObject.Find("GameBoard");
        gameController = GameObject.FindObjectOfType<GameController>();
    }

   
}
