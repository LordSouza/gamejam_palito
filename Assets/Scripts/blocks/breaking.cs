using UnityEngine;

public class breaking : MonoBehaviour
{
    Rigidbody2D _rb;
    //Animator _animator;
    private Collider2D _collider;
    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        //_animator = GetComponent<Animator>();
        _collider = GetComponentInChildren<Collider2D>();
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("aaaaaaaaaaaa");
        //_animator.enabled = true;
        _collider.enabled = false;
        //Destroy(collision.transform.parent.gameObject);
        Destroy(gameObject);
    }
}