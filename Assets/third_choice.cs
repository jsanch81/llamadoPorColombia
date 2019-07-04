using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;
using System.Text;

public class third_choice : MonoBehaviour
{
	public Material noLook;
	public Material ayeSpy;

    public GameObject[] choice_objects;
	public GameObject death_screen;

	const string letters= "bcdfghjklmnpqrstvwxyz";
    const string vowels = "aeiou";
	
    // Start is called before the first frame update
    void Start()
    {	
        GetComponent<Renderer>().material = noLook;
    }

	public void totallyWatching() {
		GetComponent<Renderer>().material = ayeSpy;
		StartCoroutine(choice_2());
		int id = Random.Range(0,2147483647); 
        int actual_time =  (int)Time.time;
        string myString = "";
        //string word = RandomString(7, true);
        for(int i=0; i<6; i++){
            if (i%2 == 0)
                myString += letters[Random.Range(0, letters.Length)];
            else 
                myString += vowels[Random.Range(0,vowels.Length)];   
        }
        string command = "https://us-south.functions.cloud.ibm.com/api/v1/web/cam.912%40hotmail.com_dev/default/database.json?command=insert&";
        command = command + "id="+id + "&name=" + myString+ "&score=" + actual_time;
        StartCoroutine(GetRequest(command));
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

	IEnumerator GetRequest(string uri)
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(uri))
        {
            // Request and wait for the desired page.
            yield return webRequest.SendWebRequest();

            string[] pages = uri.Split('/');
            int page = pages.Length - 1;

            if (webRequest.isNetworkError)
            {
                Debug.Log(pages[page] + ": Error: " + webRequest.error);
            }
            else
            {
                Debug.Log(pages[page] + ":\nReceived: " + webRequest.downloadHandler.text);
            }
        }
    }

	public void notEvenLooking() {
	    GetComponent<Renderer>().material = noLook;
	}
}
