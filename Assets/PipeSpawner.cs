using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 5;
    public float timer = 0;
    public float hightOffset = 2.5f;
    // Start is called before the first frame update
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnPipe();
            timer = 0;
        }
    }

    public void SpawnPipe()
    {
        float lowest = transform.position.y - hightOffset;
        float highest = transform.position.y + hightOffset;
        Vector3 position = new Vector3(transform.position.x, Random.Range(lowest, highest), transform.position.z);
        Instantiate(pipe, position, transform.rotation);
    }
}
