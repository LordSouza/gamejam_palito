using UnityEngine;

public class BallBreaker : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();
        
        ball.ResetPosition();
        
    }
}
