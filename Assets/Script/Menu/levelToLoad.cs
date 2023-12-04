using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class levelToLoad : MonoBehaviour
{
    public Button[] LvlButtons;

    void Start()
    {
        int levelat = PlayerPrefs.GetInt("levelat", 1); // 1 เป็นค่าเริ่มต้น

        for (int i = 0; i < LvlButtons.Length; i++)
        {
            int sceneIndex = i + 1;

            if (sceneIndex > levelat)
            {
                LvlButtons[i].interactable = false;
            }
            else
            {
                LvlButtons[i].onClick.AddListener(() => LoadScene(sceneIndex));
            }
        }
    }

    void LoadScene(int sceneIndex)
    {
        SceneManager.LoadScene("Stage " + sceneIndex);
    }
}