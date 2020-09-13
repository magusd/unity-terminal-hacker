using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Start is called before the first frame update
    int level;
    enum Screen { MainMenu, Password, Win };
    Screen currentScreen;
    string password;

    void Start()
    {
        Terminal.WriteLine("hello console");
        ShowMainMenu();
    }

    void StartGame()
    {
        currentScreen = Screen.Password;
        Terminal.WriteLine("You chosen level" + level);
        Terminal.WriteLine("Please enter your password:");
    }

    void ShowMainMenu()
    {
        currentScreen = Screen.MainMenu;
        Terminal.ClearScreen();
        Terminal.WriteLine("Console:");
        Terminal.WriteLine("1 - Easy");
        Terminal.WriteLine("2 - Medium");
        Terminal.WriteLine("3 - Hard");
    }

    void OnUserInput(string input)
    {
        if (input == "menu")
        {
            ShowMainMenu();
        }
        else if (currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);
        }
        else if(currentScreen == Screen.Password)
        {
            CheckPassword(input);
        }    
        //PlayDifficulty(difficulty);
    }

    void RunMainMenu(string input)
    {
        if (input == "1")
        {
            level = 1;
            password = "donkey";
            StartGame();
        }
        else if (input == "2")
        {
            level = 2;
            password = "combobulate";
            StartGame();
        }
        else if (input == "007")
        {
            Terminal.WriteLine("Please select a level Mr Bond");
        }
        else
        {
            Terminal.WriteLine("Please choose a valid level");
        }
    }

    void CheckPassword(string input)
    {
        if (input == password)
        {
            Terminal.WriteLine("Good boy");
            ShowMainMenu();
        }
        else
        {
            Terminal.WriteLine("No cookies for youp, try again");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
