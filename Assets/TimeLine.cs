using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeLine : MonoBehaviour
{
    float timer_f = 0;
    int timer_i = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer_f += Time.deltaTime;
        timer_i = (int)timer_f;
        Debug.Log(timer_i);
    }
}
