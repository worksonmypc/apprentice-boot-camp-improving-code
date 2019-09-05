### Another three smells

* Long method
* Conditional complexity
* Large class

---

# Static Analysis

--

Static Analysis involves using automated processes to analyse code

(vs Code Review which is a human process)

Note: ask why it is static  

--

Static (as opposed to dynamic) as the code is not actually executed

--

Limits: can only detect common mistakes, syntax issues, potential bugs, but not actual errors

--

Q: Where have you (maybe) already used Static Analysis?

+ A: Compilers
+ A: IDE (suggestions it makes are based on SA)

Note: draw connection between compile time errors vs run time errors

--

Static analysis can apply predefined rules to large codebases to quickly report on a number of measures such as:

+ Common mistakes (e.g. unassigned return values, addition / increment confusion in loop construction)
+ Poor design (e.g. circular dependencies / package tangle)
+ Unclean code (e.g. bad naming, long methods, constructors with many parameters)
+ Cyclomatic complexity (roughly how many conditionals the codebase contains)
+ Lines of code

Note: ask about coverage and whether it is measurable using static analysis—requires program execution so dynamic analysis  

--

## Continuous Integration

You can include static analysis in your CI pipeline

Note: arguably not sensible to fail the build based on SA  
  Often leads to frustration and tweaked thresholds 

--

Example: [SonarQube](https://www.sonarqube.org)

+ Multi language (25+ including Java, C#, Python, PHP, JavaScript, CSS, HTML)
+ Security scanning
+ Workflow
+ Historical tracking
+ Your tech debt in financial terms
+ You run your build tool to push results to SonarQube
+ Free if you host yourself

--

## GitHub Integration

Analyse code after every push

Note: Arguably better as out of phase with deployment, but might get ignored

--

Example: [Codacy](https://www.codacy.com)

+ Similar to SonarQube
+ Triggered by repository pushes
+ Multi language (~29 languages including Java, C#, Python, PHP, JavaScript, CSS)
+ Don’t need to execute a build yourself
+ Hosted… free for up to four users

--

## IDE Static Analysis

Can expand the power of the IDE to do more

Note: Better as it is faster feedback, and doesn’t impact the rest of the team  

--

Example: [Error Prone](https://errorprone.info)

+ Replaces the Java compiler to create errors when issues found
+ Immediate feedback for the developer
+ Integrates with the IDE (IntelliJ plugin)
+ Java specific, although [ErrorProne.NET](https://github.com/SergeyTeplyakov/ErrorProne.NET) exists
+ Free