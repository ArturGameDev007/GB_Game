using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float _topBopund = 30;
    private float _loweBound = -10;

    private void Update()
    {
        DestroyBound();
    }

    private void DestroyBound()
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
