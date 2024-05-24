using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 
public class PlayerTeleport : MonoBehaviour
{
    private bool isPlayerInTrigger = false; // Флаг, що відображає, чи знаходиться гравець в тригері

     public int sceneBuildIndex;
    void Update()
    {
        // Якщо гравець в тригері та натиснута задана клавіша
        if (isPlayerInTrigger && Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene(sceneBuildIndex); // Завантажити задану сцену
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInTrigger = true; // Гравець у тригері
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInTrigger = false; // Гравець вийшов з тригеру
        }
    }
}
            