using UnityEngine;

public class Boundaries : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.GetComponent<Player>().SetStartPosition();
    }
}
