﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    bool saltar;
    public static int counter=0;
    public setup setup;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("left")){
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-1000f*Time.deltaTime,0));
        }
        if(Input.GetKey("right")){
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(1000f*Time.deltaTime,0));
        }
        if (Input.GetKeyDown("up") && saltar){
            saltar = false;
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0,300f));

        } 
        if(counter > 4){
            Destroy(this.gameObject);
            setup.Setup();
            
        }
    }
    private void OnCollisionEnter2D(Collision2D collision){
      
        if(collision.transform.tag == "piso"){
            saltar = true;
        }
        if(collision.transform.tag == "proyectil"){
            counter = counter + 1;
            
            
        }
    }
}
