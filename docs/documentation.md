<!--
Journalen skal indeholde
x Your team number
x A table containing the student number and name of each participant in the exercise.
x Direct URLs for all the Jenkins build jobs executing your tests for each new feature, and the Jenkins job for the main branch, eg. http://ci3.ase.au.dk:8080/job/SWTE22_xx_MW_Feature1
x A URL to the GitHub repository, you are using as the shared remote repository for your team, e.g. http://github.com/TeamSWTxxx/MicrowaveHandin3/
o A new class diagram describing the final testable design after you have added all features
o Relevant new sequence diagrams describing each new feature
o A new STM diagram for the UserInterface class, describing the final result after you have added all features
o Any new STM diagrams, if you have chosen to use an STM in other classes to implement the new features
o A short description of what has been changed and what has been added (you don’t have to explain why). Explain and refer to the diagrams where relevant
o A short description of your decisions for the individual features where you had a choice
o If you have made personal features, a full specification of those
-->



<!-- omit in toc -->
# SWT Handin 3 - Microwave Oven

<!-- omit in toc -->
## Group 4 handin information
|   | Name                         | Student Number |
|---|------------------------------|----------------|
| 1 | Atren Amanoel Darvesh        | 201405993      |
| 2 | Simon Hjortgaard Bos         | 201910459      |
| 3 | Mathias Birk Olsen           | 202008722      |
| 4 | Oliver Vestergaard Schousboe | 202008211      |

<div style="page-break-after: always;"></div>

<!-- omit in toc -->
## Table of contents
- [Git Structure](#git-structure)
- [Git branches](#git-branches)
- [Jenkins jobs](#jenkins-jobs)


## Git

[GitHub link](https://github.com/bedstitest/handin03_MicrowaveOven)

### Git Structure

We have decided to use `Feature branching` for our git workflow.

### Git branches

There are a total of 4 branches. The different brances are:

1. main
2. feature/buzzer
3. feature/powerChange
4. feature/timeChange


## Jenkins jobs

There are a total of 4 jobs - one for each branch. Links to the different jobs:

1. [team04E22-microwave-main](http://ci3.ase.au.dk:8080/job/team04E22-microwave-main/)
2. [team04E22-microwave-feature-buzzer](http://ci3.ase.au.dk:8080/job/team04E22-microwave-feature-buzzer/)
3. [team04E22-microwave-feature-powerChange](http://ci3.ase.au.dk:8080/job/team04E22-microwave-feature-powerCharge/)
4. [team04E22-microwave-feature-timeChange](http://ci3.ase.au.dk:8080/job/team04E22-microwave-feature-timeChange/)

## Class diagram

It was decided to use the existing class diagram as a base and only add any changes we made to it.

<!--ADD CLASS DIAGRAM-->

## Sequence diagrams

### Buzzer

<!--ADD FEATURE SEQUENCE DIAGRAM-->

### Power change

<!--ADD FEATURE SEQUENCE DIAGRAM-->


### Time change

<!--ADD FEATURE SEQUENCE DIAGRAM-->

## Updated state machine diagram

It was decided to copy the diagram from the handout and extend it with the new features. Additions are colored blue.

<!--ADD STATE MACHINE DIAGRAM FOR USER INTERFACE-->

<!--### Other STM's??-->

## Description of changes and additions

<!--Ony what, not why.
Explain and reference to diagrams where relevant-->
### Power Change


#### Updating tests
The power change feature demanded change to two classes, the UI and the powerTupe its self.
The UI has a lot of tests, where only some of them are dependt on the configuration.

Two aprroces can be taken, with in the scope of this exercise.
The first being that each test gets the resposibility of arrange the uut.
The second being that the set still is respossibel for creating the uut, but the test dependent on the configuration reassing the uut it needs.

The second approce creats a redundent piese of code, but it ensure that the tests are a bit more maintaineble.
Since there is fewer changes needed to be made, in case the config is changed agian.

Both cases however, are not ideal. This is a brilliant exsample of the importences of a good design from the get go.
Becuase a late change to the inital design, demands an aboundece of change. 

## Decisions






