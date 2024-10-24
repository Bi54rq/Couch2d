using UnityEngine;

public class P2Button : MonoBehaviour
{
    private ButtonManager buttonManager;

    void Start()
    {
        buttonManager = FindObjectOfType<ButtonManager>();
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            buttonManager.SetP2Active(true);
        }
    }
}
