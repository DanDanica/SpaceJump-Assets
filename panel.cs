using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class panel : MonoBehaviour
{
	public GameObject gameoverPanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag ("Player") == null) {
			gameoverPanel.SetActive (true);
		}
    }
	public void Restart()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene ().name);
	}
	public void Quit()
	{
		Application.Quit();
		Debug.Log("Game Quit");
	}
	public void Menu()
	{
		SceneManager.LoadScene("MenuScene");
		
	}
}
