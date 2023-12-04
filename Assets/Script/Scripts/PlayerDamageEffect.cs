using System.Collections;
using UnityEngine;

public class PlayerDamageEffect : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color flashColor = new Color(1f, 0f, 0f, 0.5f); // สีแดงที่ใช้ในการกระพริบ
    public float flashDuration = 0.1f; // ระยะเวลาของการกระพริบ

    private Color originalColor;

    private void Start()
    {
        if (spriteRenderer == null)
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
        }

        if (spriteRenderer != null)
        {
            originalColor = spriteRenderer.color;
        }
    }

    public void PlayDamageEffect()
    {
        StartCoroutine(DamageEffectCoroutine());
    }

    IEnumerator DamageEffectCoroutine()
    {
        spriteRenderer.color = flashColor;

        yield return new WaitForSeconds(flashDuration);

        spriteRenderer.color = originalColor;
    }
}
