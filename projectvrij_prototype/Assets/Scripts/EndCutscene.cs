using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class EndCutscene : MonoBehaviour
{
    Animator EndScene;
    Animator Text;

    bool textshow = false;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(showEnd());
        EndScene = GameObject.Find("Panel").GetComponent<Animator>();
        Text = GameObject.Find("Text").GetComponent<Animator>();
        
    }

    private void Awake()
    {
        GameObject.FindGameObjectWithTag("music").GetComponent<SoundStart>().PlayMusic();
    }
    void Update()
    {
       if(textshow)
        {
            TextS();
        }
    }

    IEnumerator showEnd()
    {
        yield return new WaitForSeconds(4);
        EndScene.Play("EndScene", 0, 0);
        TextS();
    }

    void TextS()
    {
        Text.Play("TextShow", 0,0);
    }


}
