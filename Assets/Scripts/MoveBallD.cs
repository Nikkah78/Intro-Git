using UnityEngine;

public class MoveBallD : MonoBehaviour
{
    public GameObject Target;
  public float speed = 5f;
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }
}
