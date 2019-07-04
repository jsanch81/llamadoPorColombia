using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColor : MonoBehaviour
{
	public Material noLook;
	public Material ayeSpy;

    public GameObject[] choice_objects;
	
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Renderer>().material = noLook;
    }

	public void totallyWatching() {
		GetComponent<Renderer>().material = ayeSpy;
		StartCoroutine(choice_1());
	}

	IEnumerator choice_1( )
    {
		
		yield return new WaitForSeconds(1.5f);
		choice_objects = GameObject.FindGameObjectsWithTag("choice_1");
        Debug.Log(choice_objects.Length);
        foreach (GameObject choice in choice_objects){
			choice.SetActive(false);
		}
        
        
    }

	public void notEvenLooking() {
	    GetComponent<Renderer>().material = noLook;
	}
}
