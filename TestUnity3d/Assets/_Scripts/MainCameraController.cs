
using UnityEngine;

public class MainCameraController : MonoBehaviour
{
    // Variables necesarias
    public Transform target;
    [SerializeField] private Vector3 offset;
    [SerializeField] private float followSpeed;


    private void LateUpdate()
    {
        FollowTarget();
    }

    public void FollowTarget()
    {
        // Si hay un objetivo, se mueve la posición de la cámara al offset 
        if (target != null)
        {
            var targetPos = target.position + offset;
            transform.position = targetPos;
        }
    }


}
