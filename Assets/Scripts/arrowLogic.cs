using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowLogic : MonoBehaviour {
    private int score;
    public int health;
    private float horiValue;
    private float vertiValue;
    bool pressed=false;//start off false
    public GameObject lArrow;
    public GameObject rArrow;
    public GameObject dArrow;
    public GameObject uArrow;
    public GameObject otherA;
    // Use this for initialization
	void Start () {
        score = 0;
        
    }

   
    // Update is called once per frame
    void Update() {//pressed will become true when pressed
        pressed = false;//update should reset pressed to false after each frame
        horiValue = Input.GetAxis("Horizontal");
        //Debug.Log(horiValue);
        vertiValue = Input.GetAxis("Vertical");
        //Debug.Log(vertiValue);
        Debug.Log(pressed);
        //StartCoroutine("CheckInputs");
        if (horiValue > 0)//right
        {
            Debug.Log("right was pressed");
            pressed = true;
            horiValue = 0;
        }
        else if (horiValue < 0)//left
        {
            Debug.Log("left was pressed");
            pressed = true;
            horiValue = 0;
        }
        else//if it is 0
        {
            Debug.Log("it is not left or right");
            
            pressed = false;
            horiValue = 0;
        }

        if (vertiValue > 0)//up
        {
            Debug.Log("Up was pressed");
            pressed = true;
            //Destroy(other);
            vertiValue = 0;
        }
        else if (vertiValue < 0)//down 
        {
            Debug.Log("Down was pressed");
            pressed = true;
            //Destroy(other);
            vertiValue = 0;
        }
        else
        {
            Debug.Log("It is not up or down");
            pressed = false;
            vertiValue = 0;
        }

    }
    /*
    void CheckInputs()
    {
        

    }*/
    void OnTriggerEnter(Collider other)//will be called when collider enters another collider
    {
        //--------------------------------Exceptions-------------------------
        if (other.gameObject.tag == "Boundary")
        {//dont destroy the boundary
            return;
        }
        /*
        if (other.gameObject.tag == "Key")
        {//dont destroy the keys
            return;
        }*/
        //-----------------------------------------------------------------
        Debug.Log(other.gameObject.name);
        if (pressed == true && other.gameObject.tag =="Arrows")//if pressed is true when it collides
        {
            Debug.Log(other.gameObject.tag);
            score = score + 1;//increase your score
            Destroy(gameObject); 
        }
        else if (pressed == false && other.gameObject.tag == "Arrows")//if pressed is false when it collides
        {
            Debug.Log(other.gameObject.tag);
            health = health - 1;
            Destroy(gameObject);
        }

    }
}
