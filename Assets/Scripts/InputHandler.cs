using UnityEngine;
using UnityEngine.UI;

public class InputHandler : MonoBehaviour
{
  public void OpenAndroidKeyboard()
   {
       TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default);
       Invoke("HideInputField", 0.1f);
   }

   private void HideInputField()
   {
       TouchScreenKeyboard.hideInput = true;
   }
}
