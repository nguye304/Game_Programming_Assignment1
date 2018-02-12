using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
//this script controls all of the spawning and hazard logic
public class GameController : MonoBehaviour
{

    public GameObject upArrow;
    public GameObject leftArrow;
    public GameObject downArrow;
    public GameObject rightArrow;
    
    public Vector3 LspawnValues;
    public Vector3 UspawnValues;
    public Vector3 DspawnValues;
    public Vector3 RspawnValues;
    public int hazardCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;

    void Start()
    {
     
        StartCoroutine(SpawnWaves());
    }
    void GameOver()
    {
        SceneManager.LoadScene(name);
    }
    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);
        while (true)
        {

              for (int i = 0; i < hazardCount; i++)
               {
                    Vector3 spawnPosition = new Vector3(/*Random.Range(-spawnValues.x, spawnValues.x)*/LspawnValues.x, LspawnValues.y, LspawnValues.z);
                    Vector3 spawnPosition2 = new Vector3(/*Random.Range(-spawnValues.x, spawnValues.x)*/DspawnValues.x, DspawnValues.y, DspawnValues.z);
                    Vector3 spawnPosition3 = new Vector3(/*Random.Range(-spawnValues.x, spawnValues.x)*/UspawnValues.x, UspawnValues.y, UspawnValues.z);
                    Vector3 spawnPosition4 = new Vector3(/*Random.Range(-spawnValues.x, spawnValues.x)*/RspawnValues.x, RspawnValues.y, RspawnValues.z);
                    Quaternion spawnRotation = Quaternion.identity;
                    


                    Instantiate(upArrow, spawnPosition3, spawnRotation);//clones the stuff
                    Instantiate(leftArrow, spawnPosition, spawnRotation);
                    Instantiate(rightArrow, spawnPosition4, spawnRotation);
                    Instantiate(downArrow, spawnPosition2, spawnRotation);
                    
                    spawnWait = Random.Range(0, 2);
                    yield return new WaitForSeconds(spawnWait);
               }
                yield return new WaitForSeconds(waveWait);

            
        }
    }
}
