using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndicateDirectionWeapon :MonoBehaviour
{
    [SerializeField] private float _speed = 5.0f;

    private float _speedInput;

    private void Update()
    {
        IndicateDirection();
    }

    private void IndicateDirection()
    {
        _speedInput = _speed * Time.deltaTime;
        transform.Translate(Vector3.forward * _speedInput);
    }
}
