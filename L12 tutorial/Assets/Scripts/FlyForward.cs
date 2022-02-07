using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FlyForward : MonoBehaviour
{
    public Health health;
    public float speed = 1000f;
    GameObject chuuni;
    public ParticleSystem particle;
    public Score Score;
    
    void Update()
    {
        transform.Translate(speed * Time.deltaTime * 15, 0, 0);
        if (transform.position.x > 600)
        {
            transform.position = new Vector3(134, 170, 0);
            this.enabled = false;
        }

        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        transform.position = new Vector3(134, 170, 0);
        enabled = false;
        if (other.tag == "Enemy")
        {
            
            Health.health -= 1;
            if (Health.health <= 0)
            {
                particle.Play();
                Destroy(gameObject,5);
                this.enabled = false;
                transform.position = new Vector3(134, 170, 0); 
            }
        }
        if (other.tag == "Target")
        {
            Score.score += 1;

        }
    }

}
