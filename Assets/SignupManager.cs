using UnityEngine;
using TMPro;
using UnityEngine.Networking;
using System.Collections;

public class SignupManager : MonoBehaviour
{
    public TMP_InputField emailInput;
    public TMP_InputField passwordInput;
    public TMP_InputField confirmPasswordInput;
    public TextMeshProUGUI messageText;

    string signupURL = "http://localhost/ar_app/signup.php";

    public void SignupUser()
    {
        if (passwordInput.text != confirmPasswordInput.text)
        {
            messageText.text = "Passwords do not match!";
            return;
        }

        StartCoroutine(Signup());
    }

    IEnumerator Signup()
    {
        WWWForm form = new WWWForm();
        form.AddField("email", emailInput.text);
        form.AddField("password", passwordInput.text);

        UnityWebRequest www = UnityWebRequest.Post(signupURL, form);
        yield return www.SendWebRequest();

        if (www.result == UnityWebRequest.Result.Success)
        {
            messageText.text = www.downloadHandler.text;
            UnityEngine.SceneManagement.SceneManager.LoadScene("LoginScene");
        }
        else
        {
            messageText.text = "Signup Failed!";
        }
    }
}