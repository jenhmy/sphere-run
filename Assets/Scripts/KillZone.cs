using UnityEngine;

public class KillZone : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Player")) 
        {
            Jugador jugadorScript = collision.gameObject.GetComponent<Jugador>();
            if (jugadorScript != null)
                jugadorScript.Die();
        }
    }

}
