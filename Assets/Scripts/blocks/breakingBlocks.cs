using UnityEngine;

public class breakingBlocks : MonoBehaviour
{
    public Sprite[] blockStates; 
    private int hits = 0;
    private SpriteRenderer sr;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.sprite = blockStates[hits]; 
    }

    public void TakeHit()
    {
        hits++;

        if (hits < blockStates.Length)
        {
            sr.sprite = blockStates[hits];
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
