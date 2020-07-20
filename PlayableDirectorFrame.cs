using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

[RequireComponent(typeof(PlayableDirector))]
public class PlayableDirectorFrame : MonoBehaviour
{
    PlayableDirector _mPlayableDirector;
   
    public PlayableDirector mPlayableDirector
    {
        get
        {
            if(_mPlayableDirector==null)
            {
                _mPlayableDirector = GetComponent<PlayableDirector>();
            }
            return _mPlayableDirector;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        mPlayableDirector.timeUpdateMode = DirectorUpdateMode.GameTime;
    }


    //大小根据帧数和mPlayableDirector 区间计算
    [Range(0.0f, 1.0f)]
    public float Frame = 0;
    float mFrame = 0;

 

    public void Update()
    {
        if (mFrame != Frame)
        {
            mPlayableDirector.time = Frame;
            mPlayableDirector.RebuildGraph();
            mPlayableDirector.Play();
            mPlayableDirector.playableGraph.GetRootPlayable(0).SetSpeed(0);
            mFrame = Frame;
           
        }
    }

    public void LateUpdate()
    {
        
           
            
    }
}
