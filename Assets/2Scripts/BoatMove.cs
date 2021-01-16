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

        if (time < 3)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }else if(time > 3 && time < 6)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

        if (time > 8)
            time = 0;

        Debug.Log(time);
    }
}
