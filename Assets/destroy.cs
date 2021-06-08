using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    
    public float speed = 10f;
    private Rigidbody2D rigidbody;
    public GameObject wall;


    void Start(){
        
    }
    void Update(){
        rigidbody = this.GetComponent<Rigidbody2D>();
        rigidbody.velocity = new Vector2(-2f,0);
        
        if(transform.position.x < -10){
            Destroy(this.gameObject);
        }

    }
    void OnCollisionEnter2D(Collision2D collision){
      if (collision.gameObject.tag == "ignore")
      {
          Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
      }
      if(collision.transform.tag == "Player"){
            Destroy(this.gameObject);
        }
    }
}
