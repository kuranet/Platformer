
using UnityEngine;

public class EndlessGround : MonoBehaviour
{
    [SerializeField] Transform PlayerPoss;
    

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3 (0, 0, PlayerPoss.position.z); 
    }
}
