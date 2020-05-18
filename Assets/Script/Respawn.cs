using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public GameObject Hell, Yep;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ball")
        {
            Hell.transform.position = Yep.transform.position; 
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
