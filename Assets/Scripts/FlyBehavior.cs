using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;


public class FlyBehavior : MonoBehaviour
{
    [SerializeField] private float _velocity = 1.5f;
    [SerializeField] private float _rotationSpeed = 10f;
    private Rigidbody2D rb;


    

    public AudioSource audiosource;
    public AudioClip clip;
    public AudioClip die;

    public InputAction action;
    

    private void Start()
    {
        audiosource.GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody2D>();
    }


    private void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame) // Testing inputs with computer
        {
            rb.velocity = Vector2.up * _velocity;
            Flap();
            Debug.Log("Flapping");

        }
    } 

    private void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0, 0, rb.velocity.y * _rotationSpeed);
    }
    IEnumerator PlayerHit() // Little Delay with IEnumerator that will have time to play effects.
    {
        Debug.Log("PlayerHit!");
        yield return new WaitForSeconds(0.4f);
        Destroy(gameObject, 0.2f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Pipe"))
        {

            StartCoroutine(PlayerHit());
            PlayerHit(); 
            Die();
            FlyBehavior flybehavior = GetComponent<FlyBehavior>();


            


            
           
        }


       
    }

    public void Flap()
    {
        audiosource.clip = clip;
        audiosource.PlayOneShot(audiosource.clip);
    }


    public void Die()
    {
       
        audiosource.clip = die;
        audiosource.PlayOneShot(audiosource.clip);

       
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Point"))
        {
            Scoring.instance.AddPoint(10);


        }
    }
    


    public void OnFly()
    {
        rb.velocity = Vector2.up * _velocity;
        Flap();
       
    }

}



