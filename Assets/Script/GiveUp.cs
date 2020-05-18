using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GiveUp : MonoBehaviour
{
    public GameObject Player, cup;
    public int Text;
    
    private void Update()
    {
        if (Vector3.Distance(Player.transform.position, cup.transform.position) < 1)
        {
            cup.SetActive(false);
            CupCollector.cup += Text;
            GameObject.FindGameObjectWithTag("Player").GetComponent<CupCollector>().TextCup.text = CupCollector.cup.ToString();
        }
        
        
    }
    
}

