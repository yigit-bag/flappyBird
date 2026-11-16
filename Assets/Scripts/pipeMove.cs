using UnityEngine;

public class pipeMove : MonoBehaviour
{
    public float pipeMoveSpeed;

    void Update()
    {
        transform.position += Vector3.left * pipeMoveSpeed * Time.deltaTime;
    }
}
