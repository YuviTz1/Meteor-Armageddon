using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{

    public static float selector=1;


    

    private void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            selector = 0;
        }
        if (Input.GetKey(KeyCode.S))
        {
            selector = 1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            selector = 2;
        }
        //Debug.Log(selector);
    }


}
