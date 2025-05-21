using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class camera_movement : MonoBehaviour
{
    private Vector3 final_coords;
    private Vector3 coords;
    
    private BoxCollider2D own_switch;
    public BoxCollider2D other_switch;
    public GameObject c;
    private GameObject room;
    bool move = false;
    void OnTriggerEnter2D(Collider2D trigger){
        move = true;
        
    }

    void Start(){
        
        own_switch = gameObject.GetComponent<BoxCollider2D>();
        
        room = gameObject.transform.parent.gameObject;
        Vector3 final_coords = room.transform.position;
       
    }

    float x_distance;
    float y_distance;
    void FixedUpdate(){
        
        if(move){
            Vector3 final_coords = room.transform.position;
            coords = c.transform.position;
            
            x_distance = final_coords.x - coords.x;
            y_distance = final_coords.y - coords.y;
            coords.x = coords.x + 0.15f * x_distance;
            coords.y = coords.y + 0.15f * y_distance;
            c.transform.position = coords;
            
            if(Math.Abs(coords.x + coords.y - final_coords.x - final_coords.y) < 0.1){
                Debug.Log("stopped");
                coords.x = final_coords.x;
                coords.y = final_coords.y;
                c.transform.position = coords;
                move = false;
            }
        }

    }
}
