using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Rigidbody2D rb2d;
    public Camera cam;

    public Transform firePoint;
    public GameObject bulletPrefab;

    public float bulletForce;

   

    Vector2 mousePos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetButtonDown("Fire1")&&Manager.selector==1)
        {
            shoot();
        }

    }

    private void FixedUpdate()
    {
        
        Vector2 lookDir = mousePos - rb2d.position;
        float angle = Mathf.Atan2(lookDir.y,lookDir.x)*Mathf.Rad2Deg+90f;
        if ((angle > 145 && angle < 215)&&Manager.selector==1)
        {
            rb2d.rotation = angle;
        }
       
    }

    void shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(-firePoint.up * bulletForce, ForceMode2D.Impulse);
        Destroy(bullet, 10f);
    }
}
