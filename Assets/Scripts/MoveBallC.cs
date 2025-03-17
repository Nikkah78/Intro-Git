using UnityEngine;
using UnityEngine.UIElements;

public class MoveBallC : MonoBehaviour
{
    public GameObject Target;
    
    void Update()   
    {
       transform.position = new Vector3(Target.transform.position.x, Target.transform.position.y +  1, Target.transform.position.z);
    }
}
