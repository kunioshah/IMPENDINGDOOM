using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuActions : MonoBehaviour
{

   public FishAttri myInv;

   public void StartGame(){
      SceneManager.LoadScene(1);
      myInv.clearList();
   }
   public void BackToMenu() {
      SceneManager.LoadScene(0);
   }

   public void QuitGame() {
      Application.Quit();
   }

}
