using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerVanilla : MonoBehaviour {
    public GameObject hazard;
    public GameObject hazard2;
    public Vector3 spawnValues;
    public Vector3 spawnValues2;
    public int hazardCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;
  
    void Start()
    {
        
            StartCoroutine(SpawnWaves());
          
    }
    
    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);
        while (true)
        {
            for (int i = 0; i < hazardCount; i++)
            {
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
                Vector3 spawnPosition2 = new Vector3(spawnValues2.x, spawnValues2.y,Random.Range(-spawnValues2.z, spawnValues2.z));
                Quaternion spawnRotation = Quaternion.identity;
                Quaternion spawnRotation2 = Quaternion.identity;
                Instantiate(hazard, spawnPosition, spawnRotation);
                Instantiate(hazard2, spawnPosition2, spawnRotation2);
                yield return new WaitForSeconds(spawnWait);
            }
            yield return new WaitForSeconds(waveWait);
          
        }
    }
   
}

