using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DamageController : MonoBehaviour
{
    public CameraShake cameraShake;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(DamageManager.damage>=100)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        
 

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.StartsWith("AsterSmall1"))
        {
            DamageManager.damage = DamageManager.damage + 10;
            StartCoroutine(cameraShake.Shake(0.15f, 0.1f));
        }

        if (collision.gameObject.name.StartsWith("AsterMed3"))
        {
            DamageManager.damage = DamageManager.damage + 20;
            StartCoroutine(cameraShake.Shake(0.15f, 0.2f));
        }

        if (collision.gameObject.name.StartsWith("AsterBig1"))
        {
            DamageManager.damage = DamageManager.damage + 30;
            StartCoroutine(cameraShake.Shake(0.15f, 0.3f));
        }

        if (collision.gameObject.name.StartsWith("AsterHuge1"))
        {
            DamageManager.damage = DamageManager.damage + 40;
            StartCoroutine(cameraShake.Shake(0.15f, 0.4f));
        }
    }
}
