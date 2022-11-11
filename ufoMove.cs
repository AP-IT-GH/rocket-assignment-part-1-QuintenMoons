using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ufoMove : MonoBehaviour
{
    public int maxSpeed;
    private Vector3 startPosition;

    void Start()
    {
        maxSpeed = 3;

        startPosition = transform.position;
    }

    void Update()
    {
        
      transform.position = new Vector3(startPosition.x, startPosition.y + Mathf.Sin((Time.time + 30) * maxSpeed) * 7, startPosition.z);
      
    }
}
