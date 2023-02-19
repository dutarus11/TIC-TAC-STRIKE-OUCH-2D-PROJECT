using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrosshairMovement : MonoBehaviour
{

    Vector3 pos;
    public float speed = 1f;

    private void Awake()
    {
        Cursor.visible = false;
    }
    // Update is called once per frame
    void Update()
    {
        MousePosition();
    }

    //crosshair movement logic  
    public void MousePosition() 
    {
        Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector2(cursorPos.x, cursorPos.y);
    }
}
