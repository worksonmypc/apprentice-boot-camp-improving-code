# What is "legacy" code?

Note:
Ask the audience?
We intentionally haven't used the word legacy in the title of this bootcamp - because it is so loaded.

--

## A pejorative term

+ Old
+ Dirty
+ Hard to work with

Note:
These are all common perceptions - and perhaps what the audience will have suggested.

--

## Where does it come from?

+ We write it
+ Anything that's existing
+ The code you wrote before lunch

Note:
Expect the audience to suggest it comes from elsewhere.
Emphasise our role in creating it.

--

> The existing code is quite good.

\- _No Developer Ever_

Note:
All pre-existing code is typically regarded as poor quality.

--

> Which idiot wrote this?

+ `git blame Legacy.java`

Note:
Use of term idiot is intentional to indicate the strength of feeling around these issues.
Talk about appropriate language?
Mention `git blame` and the use of version control for auditing.

--

<img height="600" src="images/your-country-wants-you.jpg">

Note:
The emphasis here is not to be so quick to judge - we are often the culprit.

--

## Clever is a circular scale


Note:
We do the wrong thing even with the best of intentions.
The second system effect - Fred Brooks

--

## Embrace the legacy

Note:
We need to take ownership of legacy code and help ensure we don't leave behind a _Big Ball of Mud_ for those who follow.

---

# Exercise prep

* Go here:
 
 https://github.com/MCR-Digital/apprentice-boot-camp-improving-code
* Click the **Fork** button to make your own copy of the repository
* `git clone https://github.com/<YOUR_USERNAME>/apprentice-boot-camp-improving-code`

--

## Make sure the tests pass
  * Java folk
    * import the `exercises/java` directory using ‘Import project from external model’
    * Choose ‘Use default gradle wrapper (recommended)’
  * Other languages
    * ask your mentors how to go about it

--

## Reading code

+ Possibly your most important skill
+ Great source of learning (if you read good code)
+ Good developers spend ~10x as long reading
+ Developers who only write create debt

--

## Codebase

Refactoring codebase called ‘Trivia’

Notes: Used in ‘Legacy Code Retreat’ workshops

--

## Exercise: Read and try to understand the code (15 mins?)

+ Look at Game Runner and Game
+ Do not change the code
+ Do try to understand
+ Drawing things will help… flow chart?

--

## Recap - What have we discovered?

* What does the code represent?
* What concepts do we have?
* How does it work?

--

## Here's one I made earlier... (15 mins?)

<backgroundimage>images/Blue_peter_badge.jpg</backgroundimage>
<backgroundimageopacity>0.25</backgroundimageopacity>
<!-- .slide: data-background-repeat="repeat" -->
<!-- .slide: data-background-size="100px" -->

+ Groups of 4 or 5
+ Use your best cutting and sticking skills to make a physical copy of the game

<a rel="license" href="http://creativecommons.org/licenses/by-sa/4.0/">
    <img alt="Creative Commons License" style="border-width:0" src="https://i.creativecommons.org/l/by-sa/4.0/80x15.png" />
</a>
<div style="font-size:0.25em">
This work is licensed under a 
<a rel="license" href="http://creativecommons.org/licenses/by-sa/4.0/">Creative Commons Attribution-ShareAlike 4.0 International License</a>.
</div>

--

## Review - what did we end up with?