using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectible : MonoBehaviour
{
   void OnTriggerEnter2D(Collider2D other)
    {
        RubysController controller = other.GetComponent<RubysController>(); 
        if (controller != null)
        {
            Debug.Log("Object that entered the trigger : " + other);
          if (controller.health < controller.maxHealth)
            {
                controller.ChangeHealth(1);
                Destroy(gameObject);
            }
        }
       
    }
   
}
