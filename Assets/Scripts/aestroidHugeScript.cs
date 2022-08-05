using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aestroidHugeScript : MonoBehaviour
{

    public static int scoreValue = 400;

    public static int health;

    private float maxTorque = 3;
    private float maxThrust = 60;
    private Rigidbody2D rb;
    public GameObject impactHugeEffect;
    public GameObject aestroidSmall;


    // Start is called before the first frame update
    void Start()
    {
        health = 40;
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
            GameObject effect = Instantiate(impactHugeEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
            Destroy(effect, 0.3f);

        }
        if (collision.gameObject.tag.StartsWith("environment"))
        {
            GameObject effect = Instantiate(impactHugeEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
            Destroy(effect, 0.3f);
            Destroy(collision.gameObject);
            DamageManager.damage = DamageManager.damage + 40;

        }

        if(collision.gameObject.name.StartsWith("laserBullet_0"))
        {
            if(health<10)
            {
                Instantiate(aestroidSmall, transform.position, Quaternion.identity);
                Instantiate(aestroidSmall, transform.position, Quaternion.identity);
            }

        }
    }




}
