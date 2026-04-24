using UnityEngine;

public class PositionAutoDestroyer : MonoBehaviour
{
    private Vector2 limitMin = new Vector2(-4.50f, -4.5f);
    private Vector2 limitMax = new Vector2(4.5f, 4.5f);

    private void Update()
    {
        if(transform.position.x < limitMin.x || transform.position.x > limitMax.x || 
        transform.position.y < limitMin.y || transform.position.y > limitMax.y) 
        {
            Destroy(gameObject);
        }
    }
}
