using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTeleporter : MonoBehaviour
{
    // Назва сцени, до якої ми хочемо телепортувати гравця
    public string targetSceneName;

    // Кнопка, яка тригерить телепорт
    public KeyCode teleportKey = KeyCode.E;

    void Update()
    {
        // Перевірка, чи натиснута кнопка для телепортування
        if (Input.GetKeyDown(teleportKey))
        {
            // Телепортування до вказаної сцени
            SceneManager.LoadScene(targetSceneName);
        }
    }
}
