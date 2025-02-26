using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class ButtonPressed : MonoBehaviour
{

    public Button miBoton; // Referencia al botón en el Inspector
    public Animator miAnimator; // Referencia al Animator
    public string nombreAnimacion = "MiAnimacion"; // Nombre de la animación a reproducir

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
        Debug.Log("Animación reproducida: " + nombreAnimacion);
    }
}