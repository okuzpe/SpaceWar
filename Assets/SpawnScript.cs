using System;
using System.Collections;
using UnityEngine;


public class SpawnScript : MonoBehaviour
{
    public GameObject shootObject;
    public GameObject naveObject;
    public GameObject meteoriotoObject;
    private readonly float delayShoot = 1f;
    private readonly float shootSpeed = 250f;
    private bool canShoot = true;
    public AudioManagerScript audioManager;

    // Start is called before the first frame update

    public void Start()
    {
        InvokeRepeating("MeteoritoSpawn", 1f, 3f);

    }

    void MeteoritoSpawn()
    {
        if (naveObject)
        {
            float HorizontalRandom = UnityEngine.Random.Range(-10.0f, 10.0f);
            Vector3 navePosition = naveObject.transform.position;
            navePosition.y = +10f;
            navePosition.x = HorizontalRandom;
            Instantiate(meteoriotoObject, navePosition, Quaternion.identity);
        }

    }

    public void OnShoot()
    {
        if (canShoot && naveObject)
        {
            audioManager.Play("Shoot");
            StartCoroutine(Shoot());
        }

    }
    public IEnumerator Shoot()
    {
        canShoot = false;
        GameObject shoot = Instantiate(shootObject, naveObject.transform.position, Quaternion.identity);
        shoot.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, shootSpeed * Time.fixedDeltaTime);

        yield return new WaitForSeconds(delayShoot);
        canShoot = true;
    }
}
