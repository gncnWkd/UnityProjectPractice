using UnityEngine;

public class Movement2D : MonoBehaviour
{
    private float moveSpeed = 5.0f;
    private Rigidbody2D rigid2D;

    private void Start()
    {
        rigid2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {        
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        rigid2D.linearVelocity = new Vector3(x,y,0) * moveSpeed;
       // transform.position += new Vector3(x,y,0) * moveSpeed * Time.deltaTime;

    }
}
