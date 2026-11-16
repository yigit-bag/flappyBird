using UnityEngine;

public class pipeSpawner : MonoBehaviour
{
    public float maxSpawnTime = 1.5f;
    public float timer = 0;
    public float spawnHeight;
    public GameObject pipe;

    void Start()
    {
        GameObject newPipe = Instantiate(pipe);
        newPipe.transform.position = transform.position + new Vector3(0,Random.Range(-spawnHeight,spawnHeight),0);
    }

    void Update()
    {
        if (timer > maxSpawnTime)
        {
            GameObject newPipe = Instantiate(pipe);
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-spawnHeight, spawnHeight), 0);

            Destroy(newPipe,10);
            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
