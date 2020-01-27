using UnityEngine;

public class Automatization : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float leftXPos = -7f;
    [SerializeField] float rightXPos = 7f;
    [SerializeField] float Step = 2f;

    [SerializeField, Header("Generation settings")]
    private GameObject obstaclePrefab;

    [SerializeField]
    private float generationLookahead;

    [SerializeField]
    private float obstaclesDistance;

    [SerializeField]
    private float playerDistanceGenerationTrigger;
    
    private float lastGeneratedPos = 0;

    void Update()
    {
        if(player.position.z > lastGeneratedPos - playerDistanceGenerationTrigger)
        {
            var zPos = lastGeneratedPos;
            for (; zPos <= lastGeneratedPos + generationLookahead; zPos += obstaclesDistance)
            {
                for (float i = leftXPos; i <= rightXPos; i += Step + 0.1f) //prefab.transform.lossyScale.x
                {
                    if (Random.value > 0.8)
                    {
                        Instantiate(obstaclePrefab, new Vector3(i, 1.5f, zPos), Quaternion.identity);
                    }
                }
            }
            lastGeneratedPos = zPos;
        }  
    }
}
