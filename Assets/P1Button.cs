using UnityEngine;

public class P1Button : MonoBehaviour
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
            buttonManager.SetP1Active(true);
        }
    }
}
