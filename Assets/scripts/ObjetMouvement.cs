using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetMouvement : MonoBehaviour
{
     
    public enum MouvmentType
    {
        Rotation,
        Translation
    }

   

    [System.Serializable]
    public struct Move
    {
        public MouvmentType type;

        public Space space;

        public float speed;

        public Vector3 direction;
    }

    public List <Move> movements;
    // Start is called before the first frame update
    void Start()
       
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        foreach(Move mov in movements)
        { 
            
            if (mov.type == MouvmentType.Rotation)
            {
                transform.Rotate(mov.direction.normalized * mov.speed * Time.deltaTime, mov.space);
            }
            else if (mov.type == MouvmentType.Translation)
            {
                transform.Translate(mov.direction.normalized * mov.speed * Time.deltaTime, mov.space);
            }
        }


        //switch (mouvementType)
        //{
        //    case MouvmentType.Rotation:
        //        Rotate
        //            break;
        //    case MouvmentType.Translation:
        //        Translate
        //            break;
        //}
    }
}
