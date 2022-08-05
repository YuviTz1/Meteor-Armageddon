using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{

    public GameObject aestroid1;
    public GameObject aestroid2;
    public GameObject aestroid3;
    public GameObject aestroid4;


    private float v31;
    private float v32;
    private float randomX;
    private float yValue;


    private float randoms1;
    
    private void Start()
    {

        StartCoroutine(spawnAsteroids());
    }

    void FixedUpdate()
    {
        v31 = Camera.main.ViewportToWorldPoint(new Vector3(0f, 1.2f, 0)).x;
        v32 = Camera.main.ViewportToWorldPoint(new Vector3(1f, 1.2f, 0)).x;
        randomX = Random.Range(v31, v32);
        yValue = Camera.main.ViewportToWorldPoint(new Vector3(0f, 1.2f, 0)).y;

       

    }
    
    public IEnumerator spawnAsteroids()
    {

        
            while (true)
            {
                randoms1 = Random.Range(0f, 1f);

                if (randoms1 < 0.65)
                {
                    Instantiate(aestroid1, new Vector3(randomX, yValue, 0), Quaternion.identity);
                    //Debug.Log("small");
                }

            if (Time.time > 15)
            {
                if (randoms1 > 0.65 && randoms1 < 0.85)
                {
                    Instantiate(aestroid2, new Vector3(randomX, yValue, 0), Quaternion.identity);
                    //Debug.Log("med");
                }


                if (Time.time > 50)
                {
                    if (randoms1 > 0.85 && randoms1 < 0.95)
                    {
                        Instantiate(aestroid3, new Vector3(randomX, yValue, 0), Quaternion.identity);
                        //Debug.Log("large");
                    }
                    if (Time.time > 100)
                    {
                        if (randoms1 > 0.95)
                        {
                            Instantiate(aestroid4, new Vector3(randomX, yValue, 0), Quaternion.identity);
                            //Debug.Log("huge");
                        }
                    }
                }

            }


                yield return new WaitForSeconds(0.9f);
            }
        
        
    }


}
