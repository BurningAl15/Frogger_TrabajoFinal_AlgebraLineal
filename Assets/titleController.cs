using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class titleController : MonoBehaviour {
    //public GameObject img;
    public string play;
    public string credits;
    //bool cont = false;
    // Update is called once per frame
    public void Play()
    {
        SceneManager.LoadScene(play);
    }

    public void Credits()
    {
        SceneManager.LoadScene(credits);
    }

    //IEnumerator fade(float duration,string name)
    //{
    //    for (float i = 0; i < duration; i++)
    //    {
    //        img.SetActive(true);
    //        var color = img.GetComponent<Image>().color;
    //        color.a = Mathf.Lerp(0f, 1f, 1-i / duration);
    //        img.GetComponent<Image>().color = color;
    //        yield return null;
    //    }
    //    //while (!Input.anyKey)
    //    //{
            
    //    //    yield return null;
    //    //}

    //    for (float i = 0; i < duration; i++)
    //    {
    //        img.SetActive(true);
    //        var color = img.GetComponent<Image>().color;
    //        color.a = Mathf.Lerp(0f, 1f, i / duration);
    //        img.GetComponent<Image>().color = color;
    //        yield return null;
    //    }
    //    while(duration>=0)
    //    { 
    //        SceneManager.LoadScene(name);
    //    }
    //}


}
