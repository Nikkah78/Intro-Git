using UnityEngine;

public class MoveBallG : MonoBehaviour
{
    public Transform Target;
    public float speed = 5f;
    private bool isBlocked = false;
    void Update()
    {
        if (!isBlocked)
        {
            transform.position = Vector3.MoveTowards(transform.position, Target.position, speed* Time.deltaTime);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform == Target)
        {
            isBlocked = true;
        }
    }
}
