using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Camera_change : MonoBehaviour
{
    public Camera C_1;
    public Camera C_2;
    //���O��J2���ṳ��

    void Start()
    {
        C_1.enabled = true;
        C_2.enabled = false;
        //���}�䤤�@�Ө����W�t�@��
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            C_1.enabled = true;
            C_2.enabled = false;
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            C_1.enabled = false;
            C_2.enabled = true;
        }
    }
}
