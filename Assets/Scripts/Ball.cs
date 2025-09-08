using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 200.0f;
    
    private Rigidbody2D _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        AddStartingMovement();
    }

    private void AddStartingMovement()
    {
        float x = Random.value < 0.5f ? -1.0f : 1.0f;
        float y = Random.value < 0.5f ? Random.Range(-1.0f, 0.5f) : 
            Random.Range(0.5f, 1.0f);
        Vector2 direction = new Vector2(x, y);
        _rb.AddForce(direction * this.speed);
    }

    public void AddForce(Vector2 force)
    {
        _rb.AddForce(force);
    }
}
