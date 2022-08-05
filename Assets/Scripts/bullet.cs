using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bullet : MonoBehaviour
{

    
    public GameObject hitEffect;
    
    public static int damageDone = 10;
   


    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name.StartsWith("AsterSmall1"))
        {
            GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
            Destroy(effect, 0.4f);
            Destroy(gameObject);
            Destroy(collision.gameObject);
            scoreManager.score = scoreManager.score + aestroidScript.scoreValue;

        }

        if (collision.gameObject.name.StartsWith("AsterMed3"))
        {
            GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
            Destroy(effect, 0.4f);
            Destroy(gameObject);
            aestroidMedScript.health -= damageDone;
            
            if (aestroidMedScript.health<0)
            {
                Destroy(collision.gameObject);
                scoreManager.score = scoreManager.score + aestroidMedScript.scoreValue;
            }
            

        }


        if (collision.gameObject.name.StartsWith("AsterBig1"))
        {
            GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
            Destroy(effect, 0.4f);
            Destroy(gameObject);
            aestroidBigScript.health -= damageDone;

            if (aestroidBigScript.health < 0)
            {
                Destroy(collision.gameObject);
                scoreManager.score = scoreManager.score + aestroidBigScript.scoreValue;
            }


        }

        if (collision.gameObject.name.StartsWith("AsterHuge1"))
        {
            GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
            Destroy(effect, 0.4f);
            Destroy(gameObject);
            aestroidHugeScript.health -= damageDone;
            
            if (aestroidHugeScript.health < 0)
            {
                Destroy(collision.gameObject);
                scoreManager.score = scoreManager.score + aestroidHugeScript.scoreValue;
                
            }


        }




    }

}
