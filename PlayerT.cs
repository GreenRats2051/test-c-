using System.Collections;
using System.Collections.Generic;
using TMPro;
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
    public GameObject bullet;
    public Transform startShoot;
    public TMP_Text text;
}
