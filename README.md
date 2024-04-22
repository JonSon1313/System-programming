# System-programming
                               System programming. Examination
 The condition of the task
Implement a console application that organizes the interaction between threads according to the figure.
A class with data is given
// A class that contains an array of numbers
class Data
{
    public static int[] AI; // array with data
    public static int count; // number of even numbers
    public static int sum; // the sum of the array elements
}

In the program, organize data entry
Create 5 parameterized threads:
- thread number 1 - forms an array of random AI numbers from the Data class;
- thread # 2 - calculates the number of paired elements of the Data.AI array;
- thread #3 - calculates the sum of the elements of the array formed in the Data.AI array;
- thread # 4 - reverses the array;
- thread # 5 - provides output of array elements in a convenient form (in a string);

All threads are given parameters:
- n - the number of elements in the AI array;
- min - the lower bound of the AI array element value;
- max - the upper bound of the AI array element value.
At the beginning of the program, the user enters the values n, min, max.
After entering the data, the program implements the execution of actions in threads, as shown in the figure below. After each change in the program, you need to display the array on the screen (thread # 5).

                                             Algorithm (in Ukrainian language)
  ![image](https://github.com/JonSon1313/System-programming/assets/92844652/2bf7dd32-4d25-413a-8bdd-0dd68fd96108)
