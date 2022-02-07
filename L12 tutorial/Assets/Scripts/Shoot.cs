using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Shoot : MonoBehaviour
{
    public FlyForward flyforward;
    private void Start()
    {
        flyforward.enabled = false;
    }
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && Health.health > 0)
        {
            flyforward.enabled = true;
        }
        
    }
}
