using UnityEngine;

public class SpawnManager :MonoBehaviour
{
    [SerializeField] private GameObject[] _animalPrefabs;
    [SerializeField] private Test _test;

    private float _spawnPositionX = 10;
    private float _spawnPositionZ = 14;

    private float _startDelay = 2;
    private float _spawnInterval = 1.5f;

    private void Start()
    {
        InvokeRepeating("SpawnRandomAnimalsPosition", _startDelay, _spawnInterval);
    }

    private void SpawnRandomAnimalsPosition()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(-_spawnPositionX, _spawnPositionX), 0, _spawnPositionZ);

        int indexAnimal = Random.Range(0, _animalPrefabs.Length);

        Instantiate(_animalPrefabs[indexAnimal], spawnPosition, _animalPrefabs[indexAnimal].transform.rotation);
    }
}
