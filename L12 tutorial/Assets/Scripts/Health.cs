using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health: MonoBehaviour
{
    public Text text;
    public static int health { get; set; }
    public int check;

    void Start()
    {
        health = 3;
    }
    void Update()
    {
        text.text =$"Health: {health.ToString()}" ;
    }
    
}
