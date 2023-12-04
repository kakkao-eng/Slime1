using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class winner : MonoBehaviour
{
    public string sceneName;

    void OnTriggerEnter2D(Collider2D other)
    {
        // โหลดซีนใหม่
        SceneManager.LoadScene(sceneName);

        // ตรวจสอบว่าผู้เล่นเข้าสู่ "ด่าน 2" และถ้าใช่ ให้ปลดล็อคด่านถัดไป
        if (sceneName == "Stage 2")
        {
            UnlockNextLevel();
        }
    }

    void UnlockNextLevel()
    {
        // นำเข้าค่า levelat จาก PlayerPrefs
        int levelat = PlayerPrefs.GetInt("levelat", 1);

        // อัปเดตค่า levelat ให้เป็นด่านถัดไป
        levelat += 1;

        // บันทึกค่า levelat ใน PlayerPrefs
        PlayerPrefs.SetInt("levelat", levelat);
        PlayerPrefs.Save();
    }
}