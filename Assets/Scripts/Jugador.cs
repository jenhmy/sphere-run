using UnityEngine;
using UnityEngine.SceneManagement;

public class Jugador : MonoBehaviour {

    public float speed = 10f;
    private Rigidbody rb;
    public AudioSource deathSound;

    private void Awake()
    {
       rb = GetComponent<Rigidbody>(); 
    }

    private void Update() 
    {
        float moveHorizontal = Input.GetAxis("Horizontal"); 
        float moveVertical = Input.GetAxis("Vertical"); 
        Vector3 movement = new Vector3(moveHorizontal*speed, rb.linearVelocity.y, moveVertical*speed);        
        rb.linearVelocity = movement; 
    }

    public void Die()
    {
        if (deathSound != null)
            deathSound.Play();
        Invoke("RestartScene", deathSound.clip.length);
    }

    private void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
