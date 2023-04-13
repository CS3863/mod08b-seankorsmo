using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UseData : MonoBehaviour
{

    List<Dictionary<string, object>> data;
    //   public GameObject myCube;//prefab
    int rowCount;
    private float startDelay = 2.0f;
    private float timeInterval = 1.0f;
    public object tempObj;
    public float tempFloat;
    public Vector3 rotateAmount;

    void Awake()
    {

        data = CSVReader.Read("project data");//udata is the name of the csv file 

        for (var i = 0; i < data.Count; i++)
        {
            print("xh2o_error " + data[i]["xh2o_error"] + " ");
        }

        rowCount = 0;

    }//end Awake()

    // Use this for initialization
    void Start()
    {
        while (data != null)
        {
            InvokeRepeating("SpawnObject", startDelay, timeInterval);
        }

    }//end Start()



    void SpawnObject()
    {
        tempObj = (data[rowCount]["xh2o_error"]);
        tempFloat = System.Convert.ToSingle(tempObj);
        //tempFloat = (tempFloat - 350.0f) * 5.0f;
        rowCount++;

       // rotateAmount(tempFloat, tempFloat, tempFloat);

        //transform.localScale = new Vector3(tempFloat, tempFloat, tempFloat);
        transform.Rotate(tempFloat, tempFloat, tempFloat);    

        Debug.Log("tempFloat " + tempFloat);
        Debug.Log("Count " + rowCount);
    }
}