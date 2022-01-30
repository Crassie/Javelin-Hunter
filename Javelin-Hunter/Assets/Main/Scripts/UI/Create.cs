using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Create : MonoBehaviour
{
    // Start is called before the first frame update
    public void SelectMainScene()
    {
        SceneManager.LoadScene("Main", LoadSceneMode.Single);
    }
}
