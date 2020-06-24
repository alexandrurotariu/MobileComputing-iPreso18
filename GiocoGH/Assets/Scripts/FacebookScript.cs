using System.Collections.Generic;
using UnityEngine;
using Facebook.Unity;
using UnityEngine.UI;

public class FacebookScript : MonoBehaviour
{

    public Text FriendsText;

    private void Awake()
    {
        if (!FB.IsInitialized)
        {
            FB.Init(() =>
            {
                if (FB.IsInitialized)
                    FB.ActivateApp();
                else
                    Debug.LogError("Couldn't initialize");
            },
            isGameShown =>
            {
                if (!isGameShown)
                    Time.timeScale = 0;
                else
                    Time.timeScale = 1;
            });
        }
        else
            FB.ActivateApp();
    }

    #region Login / Logout
    public void FacebookLogin()
    {
        var permissions = new List<string>() { "public_profile", "email", "user_friends" };
        FB.LogInWithReadPermissions(permissions);
    }

    public void FacebookLogout()
    {
        FB.LogOut();
    }
    #endregion

    public void FacebookShare()
     { FB.ShareLink(new System.Uri("https://unity.com/"), "Ho superato il livello!",
         "Vieni a divertirti! :D",
         new System.Uri("https://upload.wikimedia.org/wikipedia/commons/8/8a/Official_unity_logo.png"));

    }       

    #region Inviting
    public void FacebookGameRequest()
    {
        FB.AppRequest("Hey! Vieni a giocareeee!", title: "iPreso18");
    }

   
    #endregion

    public void GetFriendsPlayingThisGame()
    {
        string query = "/me/friends";
        FB.API(query, HttpMethod.GET, result =>
        {
            var dictionary = (Dictionary<string, object>)Facebook.MiniJSON.Json.Deserialize(result.RawResult);
            var friendsList = (List<object>)dictionary["data"];
            FriendsText.text = string.Empty;
            foreach (var dict in friendsList)
                FriendsText.text += ((Dictionary<string, object>)dict)["name"];
        });
    }
}