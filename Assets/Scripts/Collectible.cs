using UnityEngine;

public class Collectible : MonoBehaviour
{
    // Cuando colisiona con un Collectible(Tag)  
    private void OnCollisionEnter(Collision collision) 
    {
        if (collision.transform.CompareTag("Player")) // Comprueba si el objeto con el que colisionó tiene la etiqueta "Player"
        {
            FindAnyObjectByType<GameManager>().AddCollectible(); // Busca cualquier instancia de GameManager en la escena y llama a su método AddCollectible()
            Destroy(gameObject); //Destruye el collectible para que desaparezca de la escena 
        }
    }
}
