using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;   
using UnityEngine.SceneManagement; 

public class scrVideo : MonoBehaviour
{
    [SerializeField]
    VideoPlayer video;
    void Start()
    {
        video.loopPointReached += MudarCenaFim;
        
    }

    void MudarCenaFim(VideoPlayer vp)
    {
        SceneManager.LoadScene("ComIa");
    }

}
