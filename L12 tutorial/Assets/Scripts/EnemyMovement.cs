using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnemyMovement : MonoBehaviour
{
    float moveDirection = 1f;
    float moveSpeed = 9f;



    void Update()
    {
        transform.Translate(0, moveSpeed * Time.deltaTime * moveDirection * 10, 0);

        if (transform.position.y > 250)
        {
            moveDirection = -1f;
        }
        if (transform.position.y < 90)
        {
            moveDirection = 1f;
        }


    }
}
