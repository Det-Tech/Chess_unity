using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Global
{
    public static string DOMAIN = "api.learntoearn.dev";
    public static int PORT = 443;
    public static bool SSL_ENALBLED = false;

    public static bool isTesting = true;
    public static int testingPort = 7777;
    public static string testingDomain = "localhost";
    public static bool socketConnected = false;

    public static string currentDomain = "";

    public static User m_user;
    public static float balance = 0;
    public static string savedData;
    public static bool isLoading = false;
    public static bool nextLoad;
    public static int myTurn = 0;
    public static string myname = "";
    public static string othername = "";

    public static int limitedMinutes = 10;

    public static void GetDomain()
    {
        currentDomain = DOMAIN;

        if (SSL_ENALBLED)
        {
            currentDomain = "https://" + currentDomain;
        }
        else
        {
            currentDomain = "http://" + currentDomain;
        }

        if (PORT != 0)
        {
            currentDomain += ":" + PORT;
        }

        if (isTesting == true)
        {
            currentDomain = "http://" + testingDomain + ":" + testingPort;
        }
    }
}

[Serializable]
public class User
{
    public long id;
    public string name;
    public long score;

    public string address;

    public User(long id = -1, string name = "", long score = 0, string address = "")
    {
        this.id = id;
        this.name = name;
        this.score = score;
        this.address = address;
    }
}
