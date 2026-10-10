using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;

    // Variables
    [SerializeField] private float spawnRate = 2.5f;
    [SerializeField] private float heightOffset = 10;
    private float timer = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
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
        } else
        {
            SpawnPipe();
            timer = 0;
        }
    }

    private void SpawnPipe()
    {
        float hightestPoint = transform.position.y + heightOffset;
        float lowestPoint = transform.position.y - heightOffset;

        Vector3 randomSpawnPosition = new(transform.position.x, Random.Range(lowestPoint, hightestPoint));

        Instantiate(pipe, randomSpawnPosition, transform.rotation);
    }
}
