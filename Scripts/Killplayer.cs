using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killplayer : MonoBehaviour
{
    public Vector3 direction;
    public float speed;
    public System.Action destroyed;

    private void Update()
    {
        this.transform.position += this.direction * this.speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player") {
            this.destroyed.Invoke();
        }
        
        Destroy(this.gameObject);
    }
}
