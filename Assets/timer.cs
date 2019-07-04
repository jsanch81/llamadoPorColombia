using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour
{
    public GameObject respawnPrefab;
    public GameObject[] respawns;
	public GameObject fire_turn;

	public GameObject[] third_choices;

    void Start()
    {
        respawns = GameObject.FindGameObjectsWithTag("Fire");
        Debug.Log(respawns.Length);
        foreach (GameObject respawn in respawns)
        {
            StartCoroutine(Example(respawn));
        }
		fire_turn = GameObject.Find("Fuego_prender");
		StartCoroutine(EspecialFire(fire_turn));

		third_choices = GameObject.FindGameObjectsWithTag("choice_3");
		foreach (GameObject choice in third_choices)
        {
            StartCoroutine(third_choices_timer(choice));
        }
    }

    IEnumerator Example(GameObject respawn )
    {
        respawn.SetActive(false);
        yield return new WaitForSeconds(20);
        respawn.SetActive(true);
        
    }

	IEnumerator EspecialFire(GameObject fire )
    {
        fire.SetActive(false);
        yield return new WaitForSeconds(15);
        fire.SetActive(true);
        
    }

	IEnumerator third_choices_timer(GameObject choice )
    {
        choice.SetActive(false);
        yield return new WaitForSeconds(23);
        choice.SetActive(true);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
