using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBehavior : MonoBehaviour
{

    //[SerializeField] float rotationSpeed = 12f;
    [SerializeField] Sprite[] emotes;
    SpriteRenderer emote;
    float rightStickV;
    float rightStickH;
    float rightTrigger;
    float leftTrigger;
    



    void Start()
    {
        emote = gameObject.GetComponent<SpriteRenderer>();

    }


    void Update()
    {
        /*
        //KEYBOARD CONSTANT ROTATION
        
        if (Input.GetKey(KeyCode.C))
        {
            gameObject.transform.Rotate(Vector3.forward * rotationSpeed);
        }

        if (Input.GetKey(KeyCode.V))
        {
            gameObject.transform.Rotate(Vector3.back * rotationSpeed);
        }

        //KEYBOARD BASIC
        if (Input.GetKey(KeyCode.I) && Input.GetKey(KeyCode.O))
        {
            emote.sprite = emotes[2];
        }
        else if (Input.GetKey(KeyCode.I))
        {
            emote.sprite = emotes[1];
        }
        else if (Input.GetKey(KeyCode.O))
        {
            emote.sprite = emotes[3];
        }
        else
        {
            emote.sprite = emotes[0];
        }
        
        if (Input.GetButton("Jump"))
        
       */

        //EMOTION READING

        rightStickV = Input.GetAxis("rightStickVertical");
        rightStickH = Input.GetAxis("rightStickHorizontal");
        if (rightStickV > 0f)
        {
            emote.sprite = emotes[4];
        }
        else
        {
 
        }

        //V 2.0 = Point sprite to stick heading
        float heading = Mathf.Atan2(Input.GetAxis("Horizontal"), (Input.GetAxis("Vertical")));
        transform.rotation = Quaternion.Euler(0f, 0f, heading * Mathf.Rad2Deg);

        //PRINT X AND Y VALUES
        //Debug.Log(Input.GetAxis("Horizontal"));
        //Debug.Log(Input.GetAxis("rightStickHorizontal"));

        //SCALING


        //BASIC BLINK & TALK
      
        if (Input.GetButton("leftBumper") && Input.GetButton("rightBumper"))
        {
            emote.sprite = emotes[2];
        }
        else if (Input.GetButton("rightBumper"))
        {
            emote.sprite = emotes[1];
        }    
        else if (Input.GetButton("leftBumper"))
        {
            emote.sprite = emotes[3];
        }
        else
        {
            emote.sprite = emotes[0];
        }
        

        //HAPPY BLINK & TALK

        //void Happy()
        {
            if (Input.GetButton("leftBumper") && Input.GetButton("rightBumper"))
            {
                emote.sprite = emotes[6];
            }
            else if (Input.GetButton("rightBumper"))
            {
                emote.sprite = emotes[5];
            }
            else if (Input.GetButton("leftBumper"))
            {
                emote.sprite = emotes[7];
            }
            else
            {
                emote.sprite = emotes[4];
            }
        }
    
    }
    

}
