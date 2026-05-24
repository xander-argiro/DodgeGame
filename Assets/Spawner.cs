using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject fallingObjectPrefab;

    float spawnInterval;
    float timer = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void SpawnFallingObject() {
        float  xPos = Random.Range(-8.5f, 8.5f);
        
        Vector3 spawnPos = new Vector3(xPos, transform.position.y, 0f);


        GameObject spawnedObject = Instantiate(fallingObjectPrefab, spawnPos, Quaternion.identity);

        float size = Random.Range(0.5f, 2f);
        spawnedObject.transform.localScale = Vector3.one * size;
    }


    // Update is called once per frame
    void Update()
    {
        spawnInterval = Random.Range(0.4f, 1f);

        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            SpawnFallingObject();
            timer = 0f;
        }
    }
}
