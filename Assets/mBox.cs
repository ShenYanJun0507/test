using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mBox : MonoBehaviour
{
    public float distance;
    public GameObject Player, Box;
    public static int Fuck;

    
    void Start()
    {
        Fuck = 1;
    }

    
    void Update()
    {
        ¶ZÂ÷();
    }

    void ¶ZÂ÷()
    {
        distance = Vector3.Distance(Player.transform.position, Box.transform.position);
        if (distance < 1)
        {
            GameObject.Find("player controler").GetComponent<PL_move>().Box();
            Destroy(Box, 0.5f);
        }
    }
}
