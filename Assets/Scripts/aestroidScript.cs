using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aestroidScript : MonoBehaviour
{
    private float maxTorque = 3;
    private float maxThrust = 60;
    private Rigidbody2D rb;
    public GameObject impactEffect;
    public GameObject smokeEffect;
    public static int scoreValue = 100;
   


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        Vector2 thrust = new Vector2(Random.Range(-maxThrust, maxThrust), 0);
        float torque = Random.Range(-maxTorque, maxTorque);
        rb.AddForce(thrust);
        rb.AddTorque(torque);
        Destroy(gameObject, 15f);
        
        
    }

    

   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.StartsWith("Base"))
        {
            GameObject effect = Instantiate(impactEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
            Destroy(effect, 0.3f);
            
        }
        if(collision.gameObject.tag.StartsWith("environment"))
        {
            GameObject effect = Instantiate(impactEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
            Destroy(effect, 0.3f);
            Destroy(collision.gameObject);
            DamageManager.damage = DamageManager.damage + 10;
           
        }
        if(DamageManager.damage==40 && collision.gameObject.name.StartsWith("Base"))
        {
           Instantiate(smokeEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
            
        }

        if (DamageManager.damage ==60 && collision.gameObject.name.StartsWith("Base"))
        {
            Instantiate(smokeEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
            
        }

        if (DamageManager.damage == 80 && collision.gameObject.name.StartsWith("Base"))
        {
            Instantiate(smokeEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
            
        }
    }
}
