using UnityEngine;
using UnityEngine.InputSystem;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D bird;
    public LogicScript logic;
    private bool birdAlive = true;

    // Default Values
    [SerializeField] private float flapstrength = 5.7f; // The strength at which the bird flaps

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Move the bird up when a valid eye is pressed
        if ((Keyboard.current.spaceKey.isPressed || Keyboard.current.upArrowKey.isPressed) && birdAlive)
        {
            bird.linearVelocity = Vector2.up * flapstrength;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        birdAlive = false;
        logic.GameOver();
    }
}
