using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BasketMovementScript : MonoBehaviour
{
    public float speed;
    public AudioSource audioSource;
    public AudioClip[] audioClip;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float horizontalInput = Input.GetAxis("Horizontal");

        transform.position = transform.position + new Vector3(horizontalInput * speed * Time.deltaTime, 0, 0);

        if (transform.position.x <= -10)
        {
            transform.position = new Vector2(-10, transform.position.y);
        }
        if (transform.position.x >= 10)
        {
            transform.position = new Vector2(10, transform.position.y);
        }

    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Healthy"))
        {
            audioSource.clip = audioClip[0];
            audioSource.Play();
            GameManager.score += 10;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("Unhealthy"))
        {
            audioSource.clip = audioClip[1];
            audioSource.Play();
            Destroy(collision.gameObject);
            SceneManager.LoadScene("LoseScene");
        }
    }
}
