using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputT : MonoBehaviour
{
    public Vector2 inputAction;
    public int jump;
    private invokerT invoker;
    public PlayerT player;
    private PlayerMovementT playerMovement;
    private PlayerShoot PlayerShoot;
    public bool heFakse = true;

    void Start()
    {
        playerMovement = new PlayerMovementT();
        invoker = new invokerT(playerMovement, player, this);
        PlayerShoot = new PlayerShoot(player.startShoot, player.bullet);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            heFakse = false;
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            heFakse = true;
        }
        if (heFakse == false)
        {
            player.text.color = Color.green;
            inputAction.x = Input.GetAxis("Horizontal");
            inputAction.y = Input.GetAxis("Vertical");
            if (Input.GetKeyDown(KeyCode.Space))
            {
                jump = 1;
            }
            else
            {
                jump = 0;
            }
            invoker.invokeMove();
            invoker.invokeJump();
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                PlayerShoot.shoot();
            }
        }
        else
        {
            player.text.color = Color.red;
        }
    }
}
