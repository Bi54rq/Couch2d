using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public GameObject ActiveTarget;
    public bool P1Active = false;
    public bool P2Active = false;
    public bool Bothtouched = false;

    void Update()
    {
        if (P1Active && P2Active)
        {
            Bothtouched = true;
            ActiveTarget.SetActive(true);
        }
    }

    public void SetP1Active(bool value)
    {
        P1Active = value;
    }

    public void SetP2Active(bool value)
    {
        P2Active = value;
    }
}
