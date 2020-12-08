using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > 20f)
        {
            Destroy(this.gameObject);
        }
        
    }
}
