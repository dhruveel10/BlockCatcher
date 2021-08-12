using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    bool spawn = true;
    [SerializeField] float minSpawnTime = 1f;
    [SerializeField] float maxSpawnTime = 5f;
    [SerializeField] Blocks[] blockSpawner;

    IEnumerator Start()
    {
        while (spawn)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnTime, maxSpawnTime));
            SpawnAttacker();
        }
    }

    public void StopSpawning()
    {
        spawn = false;
    }

    void SpawnAttacker()
    {
        var attackerIndex = Random.Range(0, blockSpawner.Length);
        Spawn(blockSpawner[attackerIndex]);
    }

    private void Spawn(Blocks myAttacker)
    {
        Blocks newAttcker = Instantiate(myAttacker, transform.position, transform.rotation) as Blocks;
        newAttcker.transform.parent = transform;
    }
}
