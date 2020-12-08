using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MeteoritoScript : MonoBehaviour
{
    private GameObject nave;
    public GameObject explosion;
    private AudioManagerScript audioManager;
    private TextMeshProUGUI textScore;


    private void Start()
    {
        nave = GameObject.Find("Nave");
        audioManager = GameObject.Find("AudioManager").GetComponent<AudioManagerScript>();
        textScore = GameObject.Find("TextScore").GetComponent<TextMeshProUGUI>();
    
    }
    // Update is called once per frame
    void Update()
    {
        if (nave)
        {
        float speed = 4f * Time.deltaTime;
        transform.position = Vector2.MoveTowards(this.transform.position, nave.transform.position,speed);

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        audioManager.Play("Explosion");
        GameObject obj = collision.collider.gameObject;
        GameObject explo = Instantiate(explosion, obj.transform.position, Quaternion.identity);
        Destroy(explo, 4f);

        if (obj.tag == "Shoot")
        {
            string score = (int.Parse(textScore.text)  + 1).ToString();
            textScore.SetText(score);
            Destroy(this.gameObject);
            Destroy(obj);

        }
        
    }
}
