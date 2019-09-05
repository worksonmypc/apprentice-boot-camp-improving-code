
# Code Smells

--

Purpose: provide language to discuss problems

+ Less ambiguous if language is shared
+ Takes ego away from conversation
+ Helps you identify issues
+ Suggests resolutions

--

> A code smell is a hint that something has gone wrong somewhere in your code. Use the smell to track down the problem.  
>   
> Note that a CodeSmell is a hint that something might be wrong, not a certainty.  
—http://wiki.c2.com/?CodeSmell

--

<backgroundimage>https://upload.wikimedia.org/wikipedia/commons/5/55/Kent_Beck_no_Workshop_Mapping_XP.jpg</backgroundimage>
<backgroundimageopacity>0.5</backgroundimageopacity>
<!-- .slide: data-background-position="top" -->

Originated from Kent Beck’s [Once And Only Once](http://wiki.c2.com/?OnceAndOnlyOnce) rule.  
(see also [CodeSmell](http://wiki.c2.com/?CodeSmell)).

<small>
[This file](https://www.flickr.com/photos/8512982@N05/1574023621/) is licensed under the Creative Commons [Attribution-Share Alike 2.0 Generic](https://creativecommons.org/licenses/by-sa/2.0/deed.en) license.
</small>

Note: Kent also created extreme programming, helped form the Agile Manifesto, is the leading proponent of TDD, spawned unit testing frameworks and popularised CRC cards.

--

<backgroundimage>images/Refactoring-Improving-the-Design-of-Existing-Code.jpg</backgroundimage>
<backgroundimageopacity>0.2</backgroundimageopacity>
<!-- .slide: data-background-size="contain" -->
<!-- .slide: data-background-position="right" -->

Further developed and popularised by Martin Fowler 

--

### Why ‘smell’?

+ Things can smell ‘off’ without knowing why: ‘the sniff test’
+ Your sense of smell will improve

Notes: Everyone has a sense of smell  
  Can become more refined  
  Can’t always tell what something is  
  Can usually tell if it smells good or bad  

--

No single definitive list of smells

Notes: Conventions have appeared over the years.  
  You may recognise some of them.  

--

## Today…

Explore *some* smells

---

<backgroundimage>images/qwan-refactoring-cards.jpg</backgroundimage>

QWAN Refactoring Cards

Notes: Going to be using QWAN Refactoring Cards  

--

<img src="images/smells-refactoring-cards-sample.png">

### Two types of card

+ Smell cards: help you identify the smell and suggest solutions
+ Refactor cards: explain what the suggested refactors achieve

--

Purpose: give you a framework to improve existing code until it becomes natural

Notes: This takes some of the opinion and emotion out of it

--

### QWAN Card Technique

+ When you find something that smells, find the appropriate card
+ Place the card down, and read the advice
+ Find the refactors it references, and place those underneath
+ Pick the appropriate refactor and apply it
+ Continue reading and start again

--

### First three smells

+ Uncommunicative Name
+ Duplicate Code
+ Magic Number
+ Long Method

--

# Uncommunicative Name

TODO

--

# Duplicate Code

TODO

--

# Magic Number

TODO

--


# Long Method

TODO

--

# Coverage

+ Covering this code is not in scope  
+ We’ve covered the code with single exhaustive test
+ Test is interesting, but not part of today’s learning
+ If tests help you, feel free to add them

--

Exercise: address these smells (30 mins)

TODO

+ After each change, run all of the tests
+ Commit if green
+ Revert if red

Notes: If working in small chunks reverting not a big deal  
    Remember you can have tests running automatically in IntelliJ  
    Run *all* of the tests  
    
--

Exercise 2: more smells

+ Conditional Complexity

TODO expand and move this later