using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatMove : MonoBehaviour
{
    public float speed;
    public float time = 0; 

    void Update()
    {
        time += Time.deltaTime;

        if (time < 4)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }else if(time > 4 && time < 7)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

        if (time > 9)
            time = 0;

        Debug.Log(time);
    }
}
