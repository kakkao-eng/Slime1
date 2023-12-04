using UnityEngine;
using UnityEngine.UI;

public class CanvasController : MonoBehaviour
{
    public Button buttonToHide;

    void Start()
    {
        // ซ่อน Button ที่คุณต้องการในเริ่มต้น
        buttonToHide.gameObject.SetActive(false);
    }

    public void ShowButton()
    {
        // เรียกเมื่อต้องการให้ Button ปรากฏออกมา (ในตอนที่คุณต้องการ)
        buttonToHide.gameObject.SetActive(true);
    }
}
