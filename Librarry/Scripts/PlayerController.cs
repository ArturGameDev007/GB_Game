using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private GameObject _weaponPrefabs;

    private float _horizontalInput;
    private float _speedInput;
    private float _rangeX = 10;

    private void Update()
    {
        Move();
        Shoot();
    }

    private void Move()
    {
        _speedInput = _speed * Time.deltaTime;

        _horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * _speedInput * _horizontalInput);

        if (transform.position.x < -_rangeX)
            transform.position = new Vector3(-_rangeX, transform.position.y, transform.position.z);
        if (transform.position.x > _rangeX)
            transform.position = new Vector3(_rangeX, transform.position.y, transform.position.z);
    }

    private void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            Instantiate(_weaponPrefabs, transform.position, _weaponPrefabs.transform.rotation);
    }
}
