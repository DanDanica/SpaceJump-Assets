using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    public float speed;
    public float minX;
    public float maxX;
    public float interval;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawn", interval, interval);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.up * speed * Time.deltaTime;
    }

    private void spawn(){
	GameObject newPlat = Instantiate(prefab);
        newPlat.transform.position = new Vector2(
            Random.Range(minX, maxX),
            transform.position.y + (Random.Range(0.5f, 1f))
        );
    }
}
