<img src="https://github.com/user-attachments/assets/93992762-bd38-41d8-8013-4b1f1008d956" alt="icon" width="40" height="40" style="vertical-align:middle">

# Hangman


## Overview
This repo is for the software implementation for the classic game of hangman.
This software will enable a player to play against the computer.
A decription of the game plus the requirements of this implementation are provided below.

## The Game
A word is randomly picked by the computer. The computer generates lines for the amount of letters in the word. There are a grid of buttons, each one corresponding to a letter in the alphabet. There is a hangman model on the side of the screen. The player clicks a letter from the alphabet that he thinks is part of the word. If he guesses correct, that button glows yellow, is disabled, and appears on the appropriate line. If he guesses wrong, that button turns gray, is disabled, and a bodypart appears on the hangman. (First a face, then eyes...) He goes again, and the game continues. If he guesses the word before the full hangman appears, a label will appear with the words "You Won!", if the full hangman appears before he guesses the word, the label with state: "You lost".

**The full spec for the game is in the repo.**

