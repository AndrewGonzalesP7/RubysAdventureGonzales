using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubysController : MonoBehaviour
{
    public float speed = 3.0f;
    public int maxHealth = 5;

    public int health { get { return currentHealth; } }
     int currentHealth;

    Rigidbody2D rigidbody2d;
    float horizontal;
    float vertical;
    // Start is called before the first frame update
    void Start()
    {
        //QualitySettings.VSyncCount = 0;
        //Application.targetFrameRate = 10;
        rigidbody2d = GetComponent<Rigidbody2D>();
        currentHealth = maxHealth;
        currentHealth = 1;
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float veritcal = Input.GetAxis("Vertical");

        Vector2 position = transform.position;
        position.x = position.x + 6.0f * horizontal * Time.deltaTime;
        position.y = position.y + 6.0f * veritcal * Time.deltaTime;
        transform.position = position;
        
    }
     void FixedUpdate()
    {
        Vector2 position = rigidbody2d.position;
        position.x = position.x + 6.0f * horizontal * Time.deltaTime;
        position.y = position.y + 6.0f * vertical * Time.deltaTime;
        rigidbody2d.MovePosition(position);

    }
    public void ChangeHealth(int amount)
    {
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
        Debug.Log(currentHealth + "/" + maxHealth);
    }
}
