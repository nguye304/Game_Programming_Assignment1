using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyByContact : MonoBehaviour {
    public GameObject explosion;
    public GameObject playerExplosion;
    public int scoreValue;
    private GameController gameController;
    
    void Start()
    {
        
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if (gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent<GameController>();
        }
        if (gameController == null)
        {
            Debug.Log("Cannot find 'GameController' script");
        }
    }
    void OnTriggerEnter(Collider other)
    {//when the object touches the arrow, destroy the gameobject
        if (other.tag == "Boundary")
        {
            return;
        }
        Instantiate(explosion, transform.position, transform.rotation);
        Debug.Log(other.name);
        if (other.tag=="Player")
        {
            Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
            SceneManager.LoadScene("LoseMenu");
        }
        
        
        Destroy(gameObject);//destroys itself
        Destroy(other.gameObject);
        //Instantiate(, transform.position, transform.rotation);
    }
    

}
