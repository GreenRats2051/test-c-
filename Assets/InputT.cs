using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputT : MonoBehaviour
{
    private KeyCode forward;
    private KeyCode backward;
    private KeyCode left;
    private KeyCode right;
    private KeyCode Jump;
    public Vector2 inputAction;
    public int jump;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(forward))
        {
            inputAction.y = 1;
        }
        else
        {
            inputAction.y = 0;
        }
        if (Input.GetKey(backward))
        {
            inputAction.y = -1;
        }
        else
        {
            inputAction.y = 0;
        }
        if (Input.GetKey(right))
        {
            inputAction.x = 1;
        }
        else
        {
            inputAction.x = 0;
        }
        if (Input.GetKey(left))
        {
            inputAction.x = -1;
        }
        else
        {
            inputAction.x = 0;
        }
        if (Input.GetKeyDown(Jump))
        {
            jump = 1;
        }
        else
        {
            jump = 0;
        }
    }
}
