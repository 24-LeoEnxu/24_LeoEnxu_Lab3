using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketMovementScript : MonoBehaviour
{
    public float speed;
   
    // Start is called before the first frame update
    void Start()
    {
        transform.GetComponent<Transform>();
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
            GameManager.score += 10;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("Unhealthy"))
        {
            Destroy(collision.gameObject);
        }
    }
}
