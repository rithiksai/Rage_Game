using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trajectory : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject dotPrefab;
    [SerializeField] GameObject dotsParent;
    [SerializeField] float dotSpacing;

    [SerializeField] int dotsNumber;

    Transform[] dotsList;
    Vector3 pos;

    float timeStamp;
    void Start()
    {
        hide();

        prepareDots();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void prepareDots()
    {
        dotsList = new Transform[dotsNumber];
		//dotPrefab.transform.localScale = Vector3.one * dotMaxScale;

		//float scale = dotMaxScale;
		//float scaleFactor = scale / dotsNumber;

		for (int i = 0; i < dotsNumber; i++) 
        {

			dotsList [i] = Instantiate (dotPrefab,null).transform;

			dotsList [i].parent = dotsParent.transform;

			/*dotsList [i].localScale = Vector3.one * scale;
			if (scale > dotMinScale)
				scale -= scaleFactor;*/
		}
    }

    public void UpdateDots (Vector3 ballPos, Vector2 forceApplied)
	{
		timeStamp = dotSpacing;
		for (int i = 0; i < dotsNumber; i++) 
        {
			pos.x = (ballPos.x + forceApplied.x * timeStamp);
            //pos.y = ballPos.y;
            pos.z = (ballPos.z + forceApplied.y * timeStamp);
;			pos.y = (ballPos.y + 7 * timeStamp) - (Physics2D.gravity.magnitude * timeStamp * timeStamp) / 2f;
		
			//you can simlify this 2 lines at the top by:
//pos = (ballPos+force*time)-((-Physics2D.gravity*time*time)/2f);
//
//but make sure to turn "pos" in Ball.cs to Vector2 instead of Vector3	
			
			dotsList [i].position = pos;
			timeStamp += dotSpacing;
		}
	}

    public void hide()
    {
        dotsParent.active = false;
    }

    public void show()
    {
        dotsParent.active = true;
    }


    
    
}
