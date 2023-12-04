using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public string levelToLoad;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // โหลดด่านที่ต้องการ (ในกรณีนี้คือ "ด่าน 2")
            SceneManager.LoadScene(levelToLoad);
        }
    }
}

