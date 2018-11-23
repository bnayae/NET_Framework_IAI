# Ex 2-C (Strings, Arrays, Classes)

In this exercise you will strength your knowledge and hands-on experiance with Strings ,arrays and classes.
You need to use as much features from the language that were introduced during the first 3- days of the course

  - You will continue to work on the HR-System from the 3rd lesson
  - Still use multidimension array of strings : private string[][] workers
  - use the HR System https://github.com/tshaiman/NET_Framework_IAI/tree/master/003-Arrays as starting point.

# HR System - Review what we have so far

  - If you havent done so, create a class for the HR system with C'tor that accepts # of Divisions
  - For each Division : ask the user how many workers in that division and insert the data to the array.
  - so far : this is what we have done in class and the solution is in the 003-Arrays project 

# HR System - New Requirements
 - Put the HR System in a sepearte Assembly Called HR System
 - The User will be asked to enter all the names of a division AT -ONCE in the following format :
 **ronen:tomer:ronit:arnon:shlomi:revital**
  this mean there are 6 students for that division , and we already have their names.
  you can choose any delimeter you want , I have used :  but you can choose your own delimeter.
  pay attention to empty inout such as 
 **ronen::tomer**
  in this case there are only 2 persons, not 3. (the empty string in the middle is ignored)
 - In the Main program you can do Input/Output with the Console and delive the result to the HR system.
 - Unlike what was presented in class : try not to use Console.ReadLine inside the HR class.
 - Add a function called "public string AllData()" that is returning the HR System as single string:
 **#ronen:tomer:ronit:arnon:shlomi:revital#liat:alon#shirly:avi:idan#**
so as you can see the divisions are sepeared by # , and the workers in each division are seperated with :
 - **Bonus /Advnace** : take this single string from the function AllData, and create an NEW HR system from it.
 - Hint: use Join, Split, StringBuilder and everything else you find suitable
 - The Exercise is not mandatory and will not be checked. The solution will be given but may not be reviewed.
 - Feel free to contact / Consult.


**Good Luck**

