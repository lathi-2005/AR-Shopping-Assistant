using UnityEngine;
using UnityEngine.SceneManagement;

public class NavigationManager : MonoBehaviour
{
    public void GoToLogin()
    {
        SceneManager.LoadScene("LoginScene");
    }

    public void GoToSignup()
    {
        SceneManager.LoadScene("SignupScene");
    }

    public void GoToScan()
    {
        SceneManager.LoadScene("ScanScene");
    }

    public void GoToProduct()
    {
        SceneManager.LoadScene("ProductScene");
    }

    public void GoToRecommendation()
    {
        SceneManager.LoadScene("RecommendationScene");
    }
}