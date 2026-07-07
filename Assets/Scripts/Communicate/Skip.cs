using UnityEngine;

public class CanvasSwitcher : MonoBehaviour
{
    [SerializeField] private GameObject canvasA;
    [SerializeField] private GameObject canvasB;
  

    public void SwitchCanvas()
    {
        if(canvasB != null)
            canvasB.SetActive(true); 

        if(canvasA != null)
            canvasA.SetActive(false); 
    }
}
