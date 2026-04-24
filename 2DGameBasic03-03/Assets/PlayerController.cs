using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private KeyCode     keyCodeFire = KeyCode.Space;
    [SerializeField]
    private GameObject  bulletPrefab;
    private float       moveSpeed = 3.0f;
    // 초기 방향은 오른쪽으로 설정
    private Vector3     lastMoveDirection = Vector3.right;

    private void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        transform.position += new Vector3(x,y,0) * moveSpeed * Time.deltaTime;

        // x축이나 y축으로 움직였을때 해당 방향을 lastMoveDirection으로 설정
        if(x!=0 || y!=0)
        {
            lastMoveDirection = new Vector3(x,y,0);
        }

        if(Input.GetKeyDown(keyCodeFire))
        {
            GameObject clone = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            clone.name = "Bullet";
            clone.transform.localScale = Vector3.one * 0.2f;
            clone.GetComponent<Movement2D>().Setup(lastMoveDirection);
            clone.GetComponent<SpriteRenderer>().color = Color.red;
        }

    }
}
