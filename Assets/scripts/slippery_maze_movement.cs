using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class slippery_maze_movement : MonoBehaviour
{
    Vector3 coords;
    public bool is_moving = false;
    // Start is called before the first frame update
    public GameObject player;       
    private Vector2 vel;

    public float speed = 0.01f;
    // Update is called once per frame
    void Update()
    {
        if (!is_moving)
        {
            if(Input.GetKeyDown(KeyCode.LeftArrow))
            {
                vel =new  Vector2(-speed,0);
                is_moving = true;
            }
            if(Input.GetKeyDown(KeyCode.RightArrow))
            {
                vel = new Vector2(speed,0);
                is_moving = true;
            }if(Input.GetKeyDown(KeyCode.UpArrow))
            {
                vel = new Vector2(0,speed);
                is_moving = true;
            }if(Input.GetKeyDown(KeyCode.DownArrow))
            {
                vel = new Vector2(0,-speed);
                is_moving = true;
            }
            coords = player.transform.position;
            coords.y = (float)(Math.Round(coords.y));
            coords.x = (float)(Math.Round(coords.x));
            player.transform.position = coords;
        }

        
    }
    void FixedUpdate(){
        if(is_moving){
            
            coords = player.transform.position;
            coords.y = coords.y + vel.y;
            coords.x = coords.x + vel.x;
            player.transform.position = coords;
        
        }
    }

    void OnCollisionEnter2D(Collision2D col){
        vel = new Vector2(0,0);
        is_moving = false;
        
    }
}
