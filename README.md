<img src="https://github.com/user-attachments/assets/93992762-bd38-41d8-8013-4b1f1008d956" alt="icon" width="40" height="40" style="vertical-align:middle">

# Hangman


## Overview
This repo is for the software implementation of the classic game of hangman.
This software will enable a player to play against the computer.
A description of the game plus the requirements of this implementation are provided below.

## The Game
A word is randomly picked by the computer. The computer generates lines for the number of letters in the word. There is a grid of buttons, each one corresponding to a letter in the alphabet. The player clicks a letter from the alphabet that he thinks is part of the word. If he guesses correct, that button glows yellow, is disabled, and appears on the appropriate line. If he guesses wrong, that button turns black, is disabled, and a body part appears on the hangman. (First a face, then eyes...) He goes again, and the game continues. If he guesses the word before the full hangman appears, a label will appear with the words "You Won!", if the full hangman appears before he guesses the word, the label will state: "You lost".

**The full spec for the game is in the repo.**

<img width="790" height="577" alt="image" src="https://github.com/user-attachments/assets/caa33cc3-e785-40de-bff5-c87943b4e228" />
