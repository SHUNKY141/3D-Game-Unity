using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Random : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    private void Start()
    {
        
    }

    // Update is called once per frame
    //void Update()
   // {
      //  transform.position += Vector3.left;
  //  }
  //  private void FixedUpdate()
  //  {
   //     transform.position += Vector3.right; 
  //  }
}
