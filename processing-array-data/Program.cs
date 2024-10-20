/* 
97 - 100   A+
93 - 96    A
90 - 92    A-
87 - 89    B+
83 - 86    B
80 - 82    B-
77 - 79    C+
73 - 76    C
70 - 72    C-
67 - 69    D+
63 - 66    D
60 - 62    D-
0  - 59    F
 */

/* 
Student         Grade

Sophia:         92.2    A-
Andrew:         89.6    B+
Emma:           85.6    B
Logan:          91.2    A-
 */

// Student names
// initialize variables - graded assignments 
// int currentAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96 };


/* int[][] scores = new int[][] {
    new int[] { 90, 86, 87, 98, 100 },  // sophiaScores
    new int[] { 92, 89, 81, 96, 90 },  // andrewScores
    new int[] { 90, 85, 87, 98, 68 },  // emmaScores
    new int[] { 90, 95, 87, 88, 96 }   // loganScores
};

// Student names
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };
int numberOfStudents = 0;
foreach (string student in studentNames)
{
 numberOfStudents += 1;
}
int[] sum = new int[numberOfStudents];

foreach (int[] score in scores)
{
 int total = 0;
 foreach (int scoreScore in score)
 {
  total += scoreScore;
 }
 // sum.SetValue(1, total);
 sum.Append(total);
 Console.WriteLine($"Sum: {sum} number of students: {numberOfStudents} total: {total}");
} */


int[][] scores = new int[][] {
    new int[] { 90, 86, 87, 98, 100 },  // sophiaScores
    new int[] { 92, 89, 81, 96, 90 },  // andrewScores
    new int[] { 90, 85, 87, 98, 68 },  // emmaScores
    new int[] { 90, 95, 87, 88, 96 }   // loganScores
};

// Student names
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };
int numberOfStudents = studentNames.Length;

int[] sum = new int[numberOfStudents];

for (int i = 0; i < numberOfStudents; i++)
{
 int total = 0;
 foreach (int score in scores[i])
 {
  total += score;
 }
 sum[i] = total;
 Console.WriteLine($"Sum for {studentNames[i]}: {sum[i]}");
}

/* foreach (string name in studentNames)
{

 if (name == "Sophia")
 {
  int sophiaSum = 0;
  decimal sophiaScore;

  foreach (int score in sophiaScores)
  {
   // add the exam score to the sum
   sophiaSum += score;
  }

  sophiaScore = (decimal)(sophiaSum) / currentAssignments;

  Console.WriteLine("Student\t\tGrade\n");
  Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
 }
} */

/* Console.WriteLine("Press the Enter key to continue");
Console.ReadLine(); */
