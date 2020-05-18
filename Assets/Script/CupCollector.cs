using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CupCollector : MonoBehaviour
{
    static public int cup;
    [SerializeField]
    public Text TextCup;
    private void Start()
    {
        cup = 0;
    }
}
