using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


public class EffectFunctionScript : MonoBehaviour
{
    //Only for editor
    #if UNITY_EDITOR
    [MenuItem("Checking/Run In Editor")]
    private static void valueCheck()
    {
    DataInputScript data;
      data = Resources.Load<DataInputScript>("DataInputScript");
      Debug.Log(data.characters[0].name);
    }
    #endif

    /*[RuntimeInitializeOnLoadMethod]
    private static void initialize()
    {
    DataInputScript data;
          data = Resources.Load<DataInputScript>("DataInputScript");
          Debug.Log(data.characters[0].name);
    }
*/
    // Start is called before the first frame update

    public int value;
    public int initial;
    public float timer;
    public float endtimer;
    public string state;
    public bool mode;
    public int turn;


    void Start()
    {
      //DataInputScript data;
      //data = Resources.Load<DataInputScript>("DataInputScript");
      //Debug.Log(data.characters[0].name);

      //Debug.Log(data.effects[1].name);
      value = 10;
      initial = 100;
      timer = 0.0f;
      endtimer = 5.0f;
      state = "regen";
      mode = true;
      turn = 0;
    }

    // Update is called once per frame
    void Update()
    {
      Debug.Log(value);
      Debug.Log(initial);
      Debug.Log(state);
      Debug.Log(mode);
      Debug.Log("turn"+turn);

    if (Input.GetKeyDown("space")){
      if (mode == true){
        mode = false;
      }
      else if (mode == false){
        mode = true;
      }
    }

    if (Input.GetKeyDown(KeyCode.T)){
      if (turn <= 4){
        turn = turn + 1;
      }
      else if (turn >= 5){
        if (state == "regen"){
          state = "poison";
          turn = 0;
        }
        else if (state == "poison"){
          state = "regen";
          turn = 0;
      }
    }


    //REAL_TIME
    if (mode == true){
      //regen
      if (state == "regen"){
      timer += Time.deltaTime;

        if (endtimer > 0){
          if (initial > 0 && initial <=200 && timer >=1){
            
            initial = initial + value;
            endtimer = endtimer - timer;
            if (endtimer <= 0){
              state = "poison";
              endtimer = 5;
            }
            timer =0;
          
          }

        }

      }

      //poison
      else if (state == "poison"){
      timer += Time.deltaTime;

        if (endtimer > 0){
          if (initial > 0 && initial <=200 && timer >=1){
            
            initial = initial - value;
            endtimer = endtimer - timer;
            if (endtimer <= 0){
              state = "regen";
              endtimer = 5;
            }
            timer = 0;
          
        }

        }

      }

    }
    else if (mode == false){
      if (state == "regen"){
        if (turn > 0){
          if (initial > 0 && initial <=200){
            initial = initial + value;
          }

        }

      }
      else if (state == "poison"){
        if (turn > 0){
          if (initial > 0 && initial <=200){
            initial = initial - value;
          }

        }

      }
    }



   }
  }
}
