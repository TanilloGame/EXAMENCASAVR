using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class ButtonPressed : MonoBehaviour
{

    public Button miBoton; // Referencia al bot�n en el Inspector
    public Animator miAnimator; // Referencia al Animator
    public string nombreAnimacion = "MiAnimacion"; // Nombre de la animaci�n a reproducir

    void Start()
    {
        if (miBoton != null && miAnimator != null)
        {
            miBoton.onClick.AddListener(ReproducirAnimacion);
        }
    }

    void ReproducirAnimacion()
    {
        miAnimator.Play("Escala");
        Debug.Log("Animaci�n reproducida: " + nombreAnimacion);
    }
}