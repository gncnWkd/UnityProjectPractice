using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject      boxPrefab;

    private void Awake()
    {
        // Instantiate는 인자 세 개를 받아, 선택한 프리팹을 벡터위치에 회전값으로 복제 생성하는 함수이다.
        Instantiate(boxPrefab, new Vector3(3,3,0), Quaternion.identity);
        // Quaternion은 Unity에서 회전을 표현하는 방식(사원수)이며, identity는 회전이 없는 상태를 말한다.
        Instantiate(boxPrefab, new Vector3(-1,-2,0), Quaternion.identity);

        // 오일러 각도를 쿼터니언으로 변경하는 메소드를 제공한다.
        Quaternion rotation = Quaternion.Euler(0,0,45); 
        GameObject clone = Instantiate(boxPrefab, new Vector3(-2,1,0), rotation);

        clone.name = "Box001";
        clone.GetComponent<SpriteRenderer>().color = Color.red;
        clone.transform.position = new Vector3(2,1,0);
        clone.transform.localScale = new Vector3(3,2,1);

    }
}
