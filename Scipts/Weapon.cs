using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform _firePoint;
    public GameObject _bulletPrefab;
    public Animator _anim;
    PLayerController _playerController;

    private void Awake()
    {
        _playerController = GetComponent<PLayerController>();
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
            _anim.SetBool("Shot",true);
            _playerController.movespeed = 0;
        }
        else
        {
            _anim.SetBool("Shot",false);
        }
    }
    public void Shoot()
    {
        Instantiate(_bulletPrefab,_firePoint.position,_firePoint.rotation);
    }
}
