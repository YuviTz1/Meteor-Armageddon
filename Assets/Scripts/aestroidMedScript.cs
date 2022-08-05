using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aestroidMedScript : MonoBehaviour
{

    public static int scoreValue = 200;

    public static int health ;

    private float maxTorque = 3;
    private float maxThrust = 60;
    private Rigidbody2D rb;
    public GameObject impactMedEffect;
    
   


    // Start is called before the first frame update
    void Start()
    {
        health = 20;
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
            GameObject effect = Instantiate(impactMedEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
            Destroy(effect, 0.3f);

        }
        if (collision.gameObject.tag.StartsWith("environment"))
        {
            GameObject effect = Instantiate(impactMedEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
            Destroy(effect, 0.3f);
            Destroy(collision.gameObject);
            DamageManager.damage = DamageManager.damage + 20;

        }
    }

    
}
