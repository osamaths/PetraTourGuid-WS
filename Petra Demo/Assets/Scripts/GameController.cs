using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public GameObject BaseModel;
    public List<Model> models = new List<Model>();

    int currentModel = 0;

    public Button nextBtn, prevBtn;
    string nextBtnName = ">>>", prevBtnName = "<<<";
	// Use this for initialization
	void Start () {
        nextBtn.transform.GetChild(0).GetComponent<Text>().text = nextBtnName;
        prevBtn.transform.GetChild(0).GetComponent<Text>().text = prevBtnName;

        //ChangeTargetModel(models[currentModel]);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void ChangeTargetModel (GameObject model)
    {
        for (int i = 0; i < BaseModel.transform.childCount; i++)
        {
            Destroy( BaseModel.transform.GetChild(i).gameObject ); // Remove Child
        }
        GameObject modelObj = (GameObject)Instantiate(model);
        modelObj.transform.SetParent(BaseModel.transform); // Set new model to target
    }

    void SetModelInfo()
    {

    }


    public void NextButton()
    {
        currentModel = Mathf.Abs((models.Count - 1) - currentModel);
        print(currentModel);

        //ChangeTargetModel(models[currentModel]);
    }

    public void PrevButton()
    {
        currentModel = Mathf.Abs(currentModel - (models.Count - 1));
        print(currentModel);

        //ChangeTargetModel(models[currentModel]);
    }
}
