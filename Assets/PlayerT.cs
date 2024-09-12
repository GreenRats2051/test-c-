using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerT : MonoBehaviour
{
    [field: SerializeField]
    public Rigidbody rb
    { get; private set; }
    [field: SerializeField]
    public int speed
    { get; private set; }
    [field: SerializeField]
    public float force
    { get; private set; }
}
