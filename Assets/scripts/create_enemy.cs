using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class create_enemy : MonoBehaviour
{
    // Start is called before the first frame update
    public follow_player s;
    public GameObject player;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            Instantiate(s, transform.position, transform.rotation);
            s.player = player;
        }
    }
}
