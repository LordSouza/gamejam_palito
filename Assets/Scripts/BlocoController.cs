using UnityEngine;

public class BlocoController : MonoBehaviour
{
    private Animator _animator;

    // Use this for initialization

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
            // Refletir a bola manualmente
            Rigidbody2D rb = other.transform.parent.GetComponent<Rigidbody2D>();
            Vector2 incomingVelocity = rb.linearVelocity;

            // Calcula a direção entre o centro do bloco e da bola (como uma "normal")
            Vector2 collisionNormal = (other.transform.position - transform.position).normalized;

            // Reflete a velocidade com base na normal
            Vector2 reflectedVelocity = Vector2.Reflect(incomingVelocity, collisionNormal);
            rb.linearVelocity = reflectedVelocity;
            
            _animator.enabled = true;
            Destroy(gameObject, 0.75f);
        }
    }
