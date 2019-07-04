using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class third_choice : MonoBehaviour
{
	public Material noLook;
	public Material ayeSpy;

    public GameObject[] choice_objects;
	public GameObject death_screen;
	
    // Start is called before the first frame update
    void Start()
    {	
        GetComponent<Renderer>().material = noLook;
    }

	public void totallyWatching() {
		GetComponent<Renderer>().material = ayeSpy;
		StartCoroutine(choice_2());
	}

	IEnumerator choice_2( )
    {
		
		yield return new WaitForSeconds(1.5f);
		choice_objects = GameObject.FindGameObjectsWithTag("choice_3");
        Debug.Log(choice_objects.Length);
        foreach (GameObject choice in choice_objects){
			choice.SetActive(false);
		}

		Debug.Log("GAAAAAME OVER");
		death_screen.SetActive(true);
		//SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

	public void notEvenLooking() {
	    GetComponent<Renderer>().material = noLook;
	}
}
