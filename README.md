<img src="https://github.com/user-attachments/assets/93992762-bd38-41d8-8013-4b1f1008d956" alt="icon" width="40" height="40" style="vertical-align:middle">

# Hangman


## Overview
This repo is for the software implementation of the classic game of hangman.
This software will enable a player to play against the computer.
A description of the game plus the requirements of this implementation are provided below.

## The Game
A word (max 10 letters) is randomly picked by the computer. The computer generates lines for the number of letters in the word. There is a 9x3 grid of buttons, each one corresponding to a letter in the alphabet. The player clicks a letter from the alphabet that he thinks is part of the word. If he guesses correct, that button glows yellow, is disabled, the message shows: “Correct Letter. Go again.”, and the letter appears on the appropriate line. If he guesses wrong, that button turns black, is disabled, the message shows: “Incorrect letter. Try again”, and a body part appears on the hangman. (First a face, then eyes...) He goes again, and the game continues. If he guesses the word before the full hangman appears, a label will appear with the words "You Won!", if the full hangman appears before he guesses the word, the label will state: "You lost".

**The full spec for the game is in the repo.**

<img width="790" height="577" alt="image" src="https://github.com/user-attachments/assets/caa33cc3-e785-40de-bff5-c87943b4e228" />

## Opening in Visual Studio

To see the latest form changes in Visual Studio, open the solution file at the repository root:

```text
Hangman.sln
```

Do not open an older copied project folder or an already-open Visual Studio window that was loaded before pulling the latest branch. After opening `Hangman.sln`, run **Build > Clean Solution**, then **Build > Rebuild Solution**.

The updated Hangman form includes an optional word-length dropdown next to the Start button. Select a number from 3 to 10 before clicking Start, or leave the dropdown blank for a random word length.
