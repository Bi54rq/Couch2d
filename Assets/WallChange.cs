using UnityEngine;

public class WallChange : MonoBehaviour
{
    public GameObject p1wall;
    public GameObject p2wall;
    private bool touched = false;



    private void Start()
    {
        p2wall.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        CompareTag("Player");
        touched = true;

    }


    void Update()
    {


        if (touched == true)
        {
            p2wall.SetActive(true);
            p1wall.SetActive(false);
            Destroy(gameObject);

        }
    }

}
