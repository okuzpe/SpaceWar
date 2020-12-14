using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerScript : MonoBehaviour
{
    public GameObject loseCanvas;
    protected Joystick joystick;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        joystick = FindObjectOfType<Joystick>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3(joystick.Horizontal, 0, 0);
        transform.position += move * speed * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {  
        GameObject obj = collision.collider.gameObject;
        if (obj.tag == "Meteorito") {
            Destroy(collision.collider.gameObject);
            Destroy(this.gameObject);
            loseCanvas.SetActive(true);
        }

    }
}
