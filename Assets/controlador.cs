using UnityEngine;

public class controlador : MonoBehaviour
{
    public void reiniciar()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("nivel1");
    }

public void mudar()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("nivel2");
    }



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
