using UnityEngine;

public class Automatization : MonoBehaviour
{
    [SerializeField] Transform PlayerPoss;
    [SerializeField] GameObject prefab;
    [SerializeField] float leftXPos = -7f;
    [SerializeField] float rightXPos = 7f;
    [SerializeField] float Step = 2f;

    

    // Update is called once per frame
    void Update()
    {
        if((int)(PlayerPoss.position.z) % 25 == 0)
        {
            for (float i = leftXPos; i <= rightXPos; i += Step + 0.1f) //prefab.transform.lossyScale.x
            {
                if (Random.value > 0.8)
                {
                    Instantiate( prefab, new Vector3(i, 1, PlayerPoss.position.z + 25f), Quaternion.identity);
                }
            }
        }  
    }
}
