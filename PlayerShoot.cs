using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    private Transform _startShoot;
    public GameObject _bullet;
    public PlayerShoot(Transform startShoot, GameObject bullet)
    {
        _startShoot = startShoot;
        _bullet = bullet;
    }
    public void shoot()
    {
        Instantiate(_bullet, _startShoot.position, Quaternion.identity);
    }
}
