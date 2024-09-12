using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody rb;
    public float force;
    public int timeDestroy;

    void Start()
    {
        rb.AddForce(Vector3.fwd * force, ForceMode.Impulse);
        Destroy(this.gameObject, timeDestroy);
    }
}
