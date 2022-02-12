using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Image healthBar;
    public float health = 100f;

    void Update()
    {
        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }

    // Change colour when take damage? 
    // flip colour change for half a millisecond 0.05
    public void Damage(float Amount)
    {
        health -= Amount;
        healthBar.fillAmount = health / 100;
    }
    

    public void Heal(float Amount)
    {
        health += Amount;
        health = Mathf.Clamp(health,0,100);

        healthBar.fillAmount = health / 100;
    }
}
