using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{

    // Variables
    [SerializeField] private float moveSpeed = 1.6f; // Speed at which the pipes move
    private readonly float deadZone = -7;

    // Update is called once per frame
    void FixedUpdate()
    {
        // Move the pipe left constantly
        transform.position += moveSpeed * Time.deltaTime * Vector3.left;

        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
