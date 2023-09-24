using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveNest : MonoBehaviour
{

    public float speed = 0.65f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

      

        
    }

    
}
