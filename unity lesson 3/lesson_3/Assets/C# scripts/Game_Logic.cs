using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Logic : MonoBehaviour
{

    Rigidbody2D playerRb;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    /*void Update()
    {
        
    }*/

    void FixedUpdate()
    {
        playerRb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed,0f);
    }

    /*void onCollisionEnter2D(Collision2D other)
    {
        Destroy(this.gameobject);
    }*/
}
