using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float _topBopund = 30;
    private float _loweBound = -10;

    private void Update()
    {
        OnDestroy(); 
    }

    private void OnDestroy()
    {
        if (transform.position.z > _topBopund)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < _loweBound)
        {
            Destroy(gameObject);
        }
    }
}
