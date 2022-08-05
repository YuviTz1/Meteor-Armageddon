using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicWaveSpawner : MonoBehaviour
{
    public GameObject aestroid;

    private float v31;
    private float v32;
    private float randomX;
    private float yValue;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnAestroid", 1f, 0.9f);
    }

    // Update is called once per frame
    void Update()
    {
        v31 = Camera.main.ViewportToWorldPoint(new Vector3(0f, 1.2f, 0)).x;
        v32 = Camera.main.ViewportToWorldPoint(new Vector3(1f, 1.2f, 0)).x;
        randomX = Random.Range(v31, v32);
        yValue = Camera.main.ViewportToWorldPoint(new Vector3(0f, 1.2f, 0)).y;
    }

    void SpawnAestroid()
    {
        Instantiate(aestroid,new Vector3(randomX,yValue,0), Quaternion.identity);
    }
}
