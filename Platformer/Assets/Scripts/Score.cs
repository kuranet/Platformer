using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] Text scoreText;
   
    // Update is called once per frame
    void Update()
    {
        scoreText.text = (player.position.z/10).ToString("0");
    }
}
