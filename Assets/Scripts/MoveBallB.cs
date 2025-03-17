using UnityEngine;

public class MoveBallB : MonoBehaviour
{
   
    public GameObject Target;
    void Update()
    {
        transform.position = Target.transform.position;
    }
}
