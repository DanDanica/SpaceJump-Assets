using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
	
	public Rigidbody2D rb;
	public TextMeshProUGUI scoreText;
	public float jumpAmount = 8f;

	public GameObject player;

	private int score;
   void start ()
	{
		player = GameObject.FindGameObjectWithTag ("Player");
	}
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
	{
		rb.velocity = new Vector2(0, jumpAmount);
	}
    }
	private void OnTriggerExit2D(Collider2D collision)
	{
		if(collision.gameObject.CompareTag("ScoreTrigger"))
		{
			score++;
			scoreText.text = score.ToString();
		}
	}

	void OnTriggerEnter2D(Collider2D other){
  	if(other.tag == "Player"){
	Destroy (player.gameObject);
   	 // shake the camera here..
  	}
	}

	//private void OnCollisionEnter2D(Collision2D collision)
	//{
		//SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	//}
}
