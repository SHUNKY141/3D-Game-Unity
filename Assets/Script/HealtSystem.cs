using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealtSystem : MonoBehaviour
{

    public int healt;
    public int numberOfLives;

    public Image[] lives;

    public Sprite Fulllive;
    public Sprite emptyLive;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (healt > numberOfLives)
        {
            healt = numberOfLives;
        }

        for (int i=0; i < lives.Length; i++)
        {
            if (i < healt)
            {
                lives[i].sprite = Fulllive;
            }
            else
            {
                lives[i].sprite = emptyLive;
            }


            if (i < numberOfLives)
            {
                lives[i].enabled = true;
            }
            else
            {
                lives[i].enabled = false;
            }
        }
    }
}
