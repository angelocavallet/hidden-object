using UnityEngine;

public class MaisDeUmaFaseJogada : MonoBehaviour
{
    private DialogoPersonagemUnicoController dialogoController;
    private BoxCollider2D localController;

    private void Start()
    {
        dialogoController = gameObject.GetComponent<DialogoPersonagemUnicoController>();
        localController = gameObject.GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        if (GameManager.instance && GameManager.instance.primeiraFaseJogada)
        {
            if (dialogoController != null) dialogoController.enabled = true;
            if (localController != null) localController.enabled = true;
        }
    }
}