
# Exercise prep

* `git clone https://github.com/MCR-Digital/apprentice-bootcamp-fundamentals-3`
* Make sure the tests pass in your language
  * Java folk: import the `exercises/java` directory using ‘Import project from external model’
  * Choose ‘Use default gradle wrapper (recommended)’

---

## Reading code

---

## Codebase

Refactoring codebase called ‘Trivia’

Notes: Used in ‘Legacy Code Retreat’ workshops

---

## Exercise: Read and try to understand the code (15 mins?)

+ Do not change the code
+ Do try to understand
+ Drawing things will help… flow chart?
+ Use materials to craft the board for the game

---

# Code Smells

---

> A code smell is a hint that something has gone wrong somewhere in your code. Use the smell to track down the problem.  
>   
> Note that a CodeSmell is a hint that something might be wrong, not a certainty.  
—http://wiki.c2.com/?CodeSmell

---

<backgroundimage>https://upload.wikimedia.org/wikipedia/commons/5/55/Kent_Beck_no_Workshop_Mapping_XP.jpg</backgroundimage>
<backgroundimageopacity>0.5</backgroundimageopacity>
<!-- .slide: data-background-position="top" -->

Originated from Kent Beck’s [Once And Only Once](http://wiki.c2.com/?OnceAndOnlyOnce) rule.  
(see also [CodeSmell](http://wiki.c2.com/?CodeSmell)).

<small>
[This file](https://www.flickr.com/photos/8512982@N05/1574023621/) is licensed under the Creative Commons [Attribution-Share Alike 2.0 Generic](https://creativecommons.org/licenses/by-sa/2.0/deed.en) license.
</small>

Note: Kent also created extreme programming, helped form the Agile Manifesto, is the leading proponent of TDD, spawned unit testing frameworks and popularised CRC cards.

---

<backgroundimage>images/Refactoring-Improving-the-Design-of-Existing-Code.jpg</backgroundimage>
<backgroundimageopacity>0.2</backgroundimageopacity>
<!-- .slide: data-background-size="contain" -->
<!-- .slide: data-background-position="right" -->

Further developed and popularised by Martin Fowler 

---

### Why ‘smell’?

+ Things can smell ‘off’ without knowing why: ‘the sniff test’
+ Your sense of smell will improve

Notes: Everyone has a sense of smell  
  Can become more refined  
  Can’t always tell what something is  
  Can usually tell if it smells good or bad  

---

No single definitive list of smells

Notes: Conventions have appeared over the years.  
  You may recognise some of them.  

---

## Today…

Explore *some* smells

---

<backgroundimage>images/qwan-refactoring-cards.jpg</backgroundimage>

Notes: Going to be using QWAN Refactoring Cards  

---

<img src="images/smells-refactoring-cards-sample.png">

### Two types of card

+ Smell cards: help you identify the smell and suggest solutions
+ Refactor cards: explain what the suggested refactors achieve

---

Purpose: give you a framework to improve existing code until it becomes natural

Notes: This takes some of the opinion and emotion out of it

---

### Technique

+ When you find something that smells, find the appropriate card
+ Place the card down, and read the advice
+ Find the refactors it references, and place those underneath
+ Pick the appropriate refactor and apply it
+ Continue reading and start again

---

### First three smells

+ Uncommunicative Name
+ Duplicate Code
+ Magic Number

---

# Ideas

Lines of code in GitHub?
Reading code versus writing code
QWAN cards - recognise smells - fix smells?
What is legacy code, is it a pejorative term?
The existing code is quite good, said no developer ever.
Which idiot wrote this? - git blame
Clever is a circular scale.
Coverage? Get them to consider coverage with just the golden master.

Run Sonar or equivalent on code-base - compare results with manual review - judgement. GitHub integrate?
Static analysis for:
* style
* bugs
* security
* performance
* coverage

Code never breaks - "HYPERAWARE EDITING"

The importance of testing - getting code under test

---

# Reading list

Working Effectively With Legacy Code
  