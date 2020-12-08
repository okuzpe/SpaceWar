using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundinaryScript : MonoBehaviour
{
    private float objectWidth, screnwidth;
    // Start is called before the first frame update
    void Start()
    {
        objectWidth = transform.GetComponent<SpriteRenderer>().bounds.size.x;
        Camera cam = Camera.main;
        float camHeigth = 2f * cam.orthographicSize;
        screnwidth = (camHeigth * cam.aspect / 2) - objectWidth;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 viewPos = transform.position;
        viewPos.x = Mathf.Clamp(viewPos.x, -screnwidth, screnwidth);
        transform.position = viewPos;
    }
}
