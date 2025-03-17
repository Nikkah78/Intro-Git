using UnityEngine;

public class MoveBallA : MonoBehaviour
{
  public  GameObject TargetA;

    void Update()
    {
        transform.position = TargetA.transform.position;
    }
}
