using UnityEngine;

public class EndlessRoad : MonoBehaviour
{
    [SerializeField] private Transform player;       // Reference to the player's GameObject.
    [SerializeField] private Transform startPoint;   // The starting point of the road.
    [SerializeField] private Transform roadblock;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Endpoint"))
        {
            player.position = new Vector3(startPoint.position.x, player.position.y, player.position.z);

            float roadblockZ = Random.Range(-2.38f, 2.38f);
            roadblock.position = new Vector3(roadblock.position.x, roadblock.position.y, roadblockZ);
        }

    }
}
