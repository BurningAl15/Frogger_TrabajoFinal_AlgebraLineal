using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameController : MonoBehaviour {

    Goal goal;
    public string name;

    public GameObject pauseTab;
    public GameObject lose;
    public Text texto;
    public Text texto2;
    public GameObject pressBtn;
    private void Start()
    {
        goal = FindObjectOfType<Goal>();
        pauseTab.SetActive(false);
        lose.SetActive(false);
        
        pressBtn.SetActive(false);
        texto.text = PlayerPrefs.GetInt("HigherScore", 0).ToString();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            pauseTab.SetActive(true);
            texto.text = "El score más alto: " + PlayerPrefs.GetInt("HigherScore", goal.counter).ToString();
            Time.timeScale = 0;
        }
        if(Input.GetKeyUp(KeyCode.Tab))
        {
            pauseTab.SetActive(false);
            Time.timeScale = 1;
        }
        
    }


    public IEnumerator SceneM(float duration)
    {
        for (float t = 0; t < duration/3; t += Time.deltaTime)
        {
            yield return null;
        }
        for (float t = 0; t < duration; t += Time.deltaTime)
        {
            lose.SetActive(true);
            pressBtn.SetActive(true);
            yield return null;
        }


        for (float t = 0; t < duration; t += Time.deltaTime)
        {
            pressBtn.SetActive(false);
            lose.SetActive(true);
            if (goal.counter > PlayerPrefs.GetInt("HigherScore", 0))
            {
                PlayerPrefs.SetInt("HigherScore", goal.counter);
            }
            texto2.text ="El score más alto: " + PlayerPrefs.GetInt("HigherScore", goal.counter).ToString();
            //Time.timeScale = 0;
            

            
            yield return null;
        }
        
        while (!Input.anyKey)
        {
            pressBtn.SetActive(false);
            SceneManager.LoadScene(name);
            //lose.SetActive(false);
            
            yield return null;

        }

        //for (float t = 0; t < duration; t += Time.deltaTime)
        //{
        //    //Time.timeScale = 1;
            
        //    yield return null;
        //}
        
    }

    //public IEnumerator SceneControl(float duration)
    //{

    //        //Fade in del texto
    //        for (float t = 0; t < duration; t += Time.deltaTime)
    //        {
    //            var color = texto.color;
    //            color.a = Mathf.Lerp(0f, 1f, t / duration);
    //            texto.color = color;
    //            yield return null;
    //        }

    //        //Esperando input
    //        while (!Input.anyKey)
    //        {
    //            yield return null;
    //        }

    //        //Fade out del texto
    //        for (float t = 0; t < duration; t += Time.deltaTime)
    //        {
    //            var color = texto.color;
    //            color.a = Mathf.Lerp(1f, 0f, t / duration);
    //            texto.color = color;
    //            yield return null;
    //        }

       
    //    SceneManager.LoadScene(name);

    //}
}
