using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Flag : MonoBehaviour

{

    public ParticleSystem WinFX;
    public TextMeshProUGUI WinText;
    public string sceneToLoad;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collsion)
    {

        if (collsion.gameObject.CompareTag("Player"))
        {
            WinText.gameObject.SetActive(true);
            Invoke("LoadNextScene", 1);
        }
    }
    public void LoadNextScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
