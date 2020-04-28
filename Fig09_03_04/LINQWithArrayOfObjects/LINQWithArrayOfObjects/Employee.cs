// Fig. 9.3: Employee.cs

/// <summary>
///  Employee class with FirstName, LastName and MonthlySalary properties.
/// </summary>
public class Employee
{
   /// <summary>
   ///  monthly salary of employee
   /// </summary>
   private decimal monthlySalaryValue; 

   /// <summary>
   /// auto-implemented property FirstName
   /// </summary>
   public string FirstName { get; set; }
  
   /// <summary>
   /// auto-implemented property LastName
   /// </summary>
   public string LastName { get; set; }

   /// <summary>
   /// constructor initializes first name, last name and monthly salary
   /// </summary>
   /// <param name="first"></param>
   /// <param name="last"></param>
   /// <param name="salary"></param>
   public Employee(string first, string last, decimal salary)
   {
      FirstName = first;
      LastName = last;
      MonthlySalary = salary;
   } // end constructor


   /// <summary>
   /// property that gets and sets the employee's monthly salary  
   /// </summary>
   public decimal MonthlySalary
   {
      get
      {
         return monthlySalaryValue;
      } // end get
      set
      {
         if (value >= 0M) // if salary is non-negative
         {
            monthlySalaryValue = value;
         } // end if
      } // end set
   } // end property MonthlySalary

   /// <summary>
   /// Return a String containing the employee's information. 
   /// É utilizado no Console.WriteLine(element);
   /// </summary>
   /// <returns>string</returns>
   public override string ToString()
   {
      return string.Format("{0,-10} {1,-10} {2,10:C}",
         FirstName, LastName, MonthlySalary);
   } // end method ToString
} // end class Employee

/**************************************************************************
 * (C) Copyright 1992-2014 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 *************************************************************************/
