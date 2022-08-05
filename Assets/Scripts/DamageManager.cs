using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageManager : MonoBehaviour
{
    public static int damage;
    Text damageText;


    // Start is called before the first frame update
    void Start()
    {

        damageText = GetComponent<Text>();
        damage = 0;
    }

    // Update is called once per frame
    void Update()
    {
        damageText.text ="Damage: " + damage.ToString() + "%";
        
    }
}
