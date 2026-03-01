using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class Enemigo : MonoBehaviour
{
    private NavMeshAgent navMeshAgent;
    private Transform playerTransform;

        void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>(); // Obtener el componente NavMeshAgent del enemigo
        playerTransform = FindAnyObjectByType<Jugador>().transform; // Buscar cualquier objeto Jugador en la escena y tomar su transform
    }

    void Update()
    {
        navMeshAgent.destination = playerTransform.position;  // Actualiza constantemente la posición de destino del enemigo hacia el jugador
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Player")) // Si el enemigo choca con el jugador
        {
            Jugador jugadorScript = collision.gameObject.GetComponent<Jugador>();
            if (jugadorScript != null)
                jugadorScript.Die();
        }
    }
}
