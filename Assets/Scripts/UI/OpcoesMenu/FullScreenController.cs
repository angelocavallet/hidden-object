using UnityEngine;
using UnityEngine.UI;

public class FullScreenController : MonoBehaviour
{
    private Toggle toggle;

    public void Start()
    {
        toggle = GetComponent<Toggle>();
        toggle.isOn = GameManager.instance.telaCheia;
    }

    public void Change()
    {
        GameManager.instance.telaCheia = !GameManager.instance.telaCheia;
    }
}
