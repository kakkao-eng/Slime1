using UnityEngine;

public class CollisionChecker : MonoBehaviour
{
    public CanvasController canvasController;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // เรียกเมื่อต้องการให้ Button ปรากฏออกมา (เมื่อผ่านด่าน 1)
            canvasController.ShowButton();
        }
    }
}