using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TargetMovement : MonoBehaviour
{
    float timeCounter = 90;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timeCounter += Time.deltaTime*3;
        float x = 480 +Mathf.Cos(timeCounter) * 30;
        float y = 164 +Mathf.Sin(timeCounter) * 35;

        transform.position = new Vector3(x, y);
    }
}
