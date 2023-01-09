using System;
using System.Linq;

class Person{
	protected string firstName;
	protected string lastName;
	protected int id;
	
	public Person(){}
	public Person(string firstName, string lastName, int identification){
			this.firstName = firstName;
			this.lastName = lastName;
			this.id = identification;
	}
	public void printPerson(){
		Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id); 
	}
}

class Student : Person{
    private int[] testScores;  
  
    /*	
    *   Class Constructor */
    public Student(string firstName,string lastName,int id, int[] scores):base(firstName,lastName,id){
        testScores=scores;
    }
    /*   Parameters: 
    *   firstName - A string denoting the Person's first name.
    *   lastName - A string denoting the Person's last name.
    *   id - An integer denoting the Person's ID number.
    *   scores - An array of integers denoting the Person's test scores.
    */
    // Write your constructor here
    
    /*	
    *   Method Name: Calculate
    *   Return: A character denoting the grade.
    */
    // Write your method here

    public string Calculate(){

        int sum=0;
        string grade="";
        foreach (var item in testScores)
        {
            sum+=item;
        }
int point=sum/testScores.Length;
if(point>=90 && point<=100)
        grade= "O";
      if(point>=80 && point<90)
        grade= "E";
      if(point>=70 && point<80)
        grade= "A";
      if(point>=55 && point<70)
        grade= "P";
      if(point>=40 && point<55)
        grade= "D";
      if(point<40)
        grade= "T";
    return grade;

    }
}

class Solution {
	static void Main() {
		string[] inputs = Console.ReadLine().Split();
		string firstName = inputs[0];
	  	string lastName = inputs[1];
		int id = Convert.ToInt32(inputs[2]);
		int numScores = Convert.ToInt32(Console.ReadLine());
		inputs = Console.ReadLine().Split();
	  	int[] scores = new int[numScores];
		for(int i = 0; i < numScores; i++){
			scores[i]= Convert.ToInt32(inputs[i]);
		} 
	  	
		Student s = new Student(firstName, lastName, id, scores);
		s.printPerson();
		Console.WriteLine("Grade: " + s.Calculate() + "\n");
	}
}