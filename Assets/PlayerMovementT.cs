using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementT
{
    public void Move(Rigidbody rigidbody,Vector3 inputAction ,int speed)
    {
        rigidbody.velocity = new Vector3(inputAction.x * speed, rigidbody.velocity.y, inputAction.z * speed);
    }

    public void Jump(Rigidbody rigidbody, int jump,float force)
    {
        if (jump != 0)
        {
            rigidbody.AddForce(Vector3.up * force, ForceMode.Impulse);
        }
    }
}
