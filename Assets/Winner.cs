using UnityEngine;
using UnityEngine.SceneManagement; // Import the SceneManagement namespace

public class Winner : MonoBehaviour
{
    public string SceneToLoad;


    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            LoadScene(); // Call the method to load a scene
        }
    }

    private void LoadScene()
    {
        // Replace "SceneName" with the name of the scene you want to load
        SceneManager.LoadScene(SceneToLoad);
    }
}
