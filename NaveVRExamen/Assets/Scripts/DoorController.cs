using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DoorController : MonoBehaviour
{
    public Animator doorAnimator;
    private bool isOpen = false; // Estado de la puerta

    public void ToggleDoor()
    {
        if (isOpen)
        {
            doorAnimator.SetTrigger("CloseDoor"); // Activa la animaci�n de cierre
        }
        else
        {
            doorAnimator.SetTrigger("OpenDoor"); // Activa la animaci�n de apertura
        }

        isOpen = !isOpen; // Cambia el estado de la puerta
    }
}
