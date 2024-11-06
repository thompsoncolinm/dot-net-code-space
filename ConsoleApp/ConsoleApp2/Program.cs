// initialize variables - graded assignments 
int currentAssignments = 5;

int[] sophiaGrades = { 93, 87, 98, 95, 100 };
int[] nicolasGrades = { 80, 83, 82, 88, 85 };
int[] zahirahGrades = { 84, 96, 73, 85, 79 };
int[] jeongGrades = { 90, 92, 98, 100, 97 };

int sophiaSum = sophiaGrades.Sum();
int nicolasSum = nicolasGrades.Sum();
int zahirahSum = zahirahGrades.Sum();
int jeongSum = jeongGrades.Sum();

// Create `Console.WriteLine` statements to display the student name and the value of their summed assignment scores

// Console.WriteLine($"Sophia: {sophiaSum}");
// Console.WriteLine($"Nicolas: {nicolasSum}");
// Console.WriteLine($"Zahirah: {zahirahSum}");
// Console.WriteLine($"Jeong: {jeongSum}");

// Create variables to store the average score for their graded assignments

decimal sophiaScore = (decimal) sophiaSum / currentAssignments;
decimal nicolasScore = (decimal) nicolasSum / currentAssignments;
decimal zahirahScore = (decimal) zahirahSum / currentAssignments;
decimal jeongScore = (decimal) jeongSum / currentAssignments;

// Display each student's current score and

// Console.WriteLine($"Sophia: {sophiaScore}");
// Console.WriteLine($"Nicolas: {nicolasScore}");
// Console.WriteLine($"Zahirah: {zahirahScore}");
// Console.WriteLine($"Jeong: {jeongScore}");


// Calculate the letter grade based on the following numeric to letter assignments
// 97 - 100    A+
// 93 - 96     A
// 90 - 92     A-
// 87 - 89     B+
// 83 - 86     B

// Create a function to calculate the appropriate letter grade based on the average score

string CalculateLetterGrade(decimal score)
{
    if (score >= 97)
    {
        return "A+";
    }
    else if (score >= 93)
    {
        return "A";
    }
    else if (score >= 90)
    {
        return "A-";
    }
    else if (score >= 87)
    {
        return "B+";
    }
    else if (score >= 83)
    {
        return "B";
    }
    else
    {
        return "F";
    }
}

// Display each student's score and letter grade

Console.WriteLine("Name\t\t Score\t Grade");
Console.WriteLine($"Sophia:\t\t {sophiaScore}\t{CalculateLetterGrade(sophiaScore)}");
Console.WriteLine($"Nicolas:\t {nicolasScore}\t{CalculateLetterGrade(nicolasScore)}");
Console.WriteLine($"Zahirah:\t {zahirahScore}\t{CalculateLetterGrade(zahirahScore)}");
Console.WriteLine($"Jeong:\t\t {jeongScore}\t{CalculateLetterGrade(jeongScore)}");