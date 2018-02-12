using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pressedLogic : MonoBehaviour {

    public GameObject keys;
    public GameObject arrow2kill;

    void OnTriggerEnter(Collider other)//will be called when collider enters another collider
    {
        if (other.tag == "Boundary")
        {
            return;
        }
        if (other.tag == "Key")
        {
            return;
        }
        //Debug.Log(other.name);
        //Debug.Log(GameObject.name);
        //Destroy(gameObject);
        //Destroy(other.gameObject);

        /*
            if (pressed == true && collision.gameObject.tag == "Arrows")//it pressed is true when it collides
            {
                score = score + 1;//increase your score
            }
            else if (pressed == false && collision.gameObject.tag == "Arrows")//if pressed is false when it collides
            {
                health = health - 1;
            }
            */
    }
}
