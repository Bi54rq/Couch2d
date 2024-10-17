using UnityEngine;

public class Lever : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject lever;
    public GameObject falling;
    public bool leverPulled = false;

    private void Start()
    {
        falling.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        CompareTag("Player");
        leverPulled = true;
        
    }
  
    
   
       
    
    void Update()
    {

        
        if (leverPulled == true)
        {
            falling.SetActive(true);
            Destroy(gameObject);

        }
    }



  







}
