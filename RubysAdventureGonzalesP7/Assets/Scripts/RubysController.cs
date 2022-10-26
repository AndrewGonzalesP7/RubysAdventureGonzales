using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubysController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("horizontal");
        Debug.Log(horizontal);
        Vector2 position = transform.position;
        position.x = position.x + 0.01f * horizontal;
        transform.position = position;
    }
}
