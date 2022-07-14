using UnityEngine;

// Include the namespace required to use Unity UI
//using UnityEngine.UI;

using System.Collections;

public class PlayerController : MonoBehaviour {

	float moveHorizontal = 0;
	float moveVertical = 0;
	public float speed;
	//public Text countText;
	//public Text winText;

	private Rigidbody rb;
	//private int count;

	void Start ()
	{

		
		rb = GetComponent<Rigidbody>();
        //count = 0;
        //SetCountText ();
        //winText.text = "You Win!!";
    }
	
	void FixedUpdate ()
	{
		//float moveHorizontal = Input.GetAxis ("Horizontal");
		//float moveVertical = Input.GetAxis ("Vertical");
		float matX;
		float matY;


		bool ismatXnull = float.TryParse(Globals.Variables.matX,out matX);
		bool ismatYnull = float.TryParse(Globals.Variables.matY,out matY);


        if (matY < 26)		//UP
        {
            moveVertical = 1;
        }
        if (matX < 26)		//LEFT
        {
            moveHorizontal = -1;
        }
        if (matY > 26)		//DOWN
        {
            moveVertical = -1;
        }
        if (matX > 26)		//RIGHT
        {
            moveHorizontal = 1;
        }
		//Debug.Log(moveHorizontal + " " + moveVertical);
        Debug.Log("MovX: " + matX + " MovY: " + matY);

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }

	public void GameQuit()
	{

		#if UNITY_EDITOR
			// Application.Quit() does not work in the editor so
			// UnityEditor.EditorApplication.isPlaying need to be set to false to end the game
			UnityEditor.EditorApplication.isPlaying = false;
		#else
			Application.Quit();
		#endif
	}

	//void OnTriggerEnter(Collider other) 
	//{
	//	if (other.gameObject.CompareTag ("Pick Up"))
	//	{
	//		other.gameObject.SetActive (false);
	//		count = count + 1;

	//		SetCountText ();
	//	}
	//}

	//void SetCountText()
	//{
	//	countText.text = "Count: " + count.ToString ();
	//	if (count >= 12) 
	//	{
	//		winText.text = "You Win!";
	//	}
	//}
}