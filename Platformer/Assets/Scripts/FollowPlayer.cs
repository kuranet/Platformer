using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] Transform PlayerPos;
    [SerializeField] Vector3 offset;
    
    // Update is called once per frame
    void Update()
    {
        transform.position = PlayerPos.position + offset;
    }
}
