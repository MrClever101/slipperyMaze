using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement_script : MonoBehaviour
{
    public float player_speed = 0.01F;
    public GameObject player;
    Vector3 coords;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            coords = player.transform.position;
            coords.x = coords.x - player_speed;
            player.transform.position = coords;
        }
        else if(Input.GetKey(KeyCode.RightArrow))
        {
            coords = player.transform.position;
            coords.x = coords.x + player_speed;
            player.transform.position = coords;
        }
        if(Input.GetKey(KeyCode.UpArrow))
        {
            coords = player.transform.position;
            coords.y = coords.y + player_speed;
            player.transform.position = coords;
        }
        else if(Input.GetKey(KeyCode.DownArrow))
        {
            coords = player.transform.position;
            coords.y = coords.y - player_speed;
            player.transform.position = coords;
        }
    }
}
