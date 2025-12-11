using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public UDPReceive udpReceive; 

    void Update()
    {
        string data = udpReceive.data;

        if (!string.IsNullOrEmpty(data))
        {
            data = data.Remove(0, 1);
            data = data.Remove(data.Length - 1, 1);

            string[] info = data.Split(',');

      
            float x = float.Parse(info[0]) / 100f;
            float y = float.Parse(info[1]) / 100f;
            float z = float.Parse(info[2]) / 1000f; 

            transform.localPosition = new Vector3(-x, y, z); 
        }
    }
}