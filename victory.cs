using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class victory : MonoBehaviour
{

    public GameObject mainCanvas;
    public GameObject VictoryCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other){
        mainCanvas.SetActive(false);
        VictoryCanvas.SetActive(true);
    }
}
