using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class follow_player : MonoBehaviour
{
    public GameObject player;
    public GameObject tracker;
    public Rigidbody2D rb;

    Vector2 force;
    Vector3 direction;
    Vector3 player_coords;
    Vector3 tracker_coords;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        player_coords = player.transform.position;
        tracker_coords = tracker.transform.position;
        direction = player_coords-tracker_coords;

        force = Normalise(direction);
        rb.AddForce(force);
    }

    Vector2 Normalise(Vector3 d)
    {
        float total = 1;
        return new Vector2(d.x/total, d.y/total);
    }
}
