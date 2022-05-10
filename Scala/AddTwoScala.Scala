/*
Aliyah Millán
CPSC-362
7 May 2022
*/

 object Main {
   def main(args: Array[String]){
     print("Enter a number: ")
     var num1 = scala.io.StdIn.readInt()
     print("Enter another number: ")
     var num2 = scala.io.StdIn.readInt()
     var sum = num1 + num2
     println("Your sum is: " + sum + "\n")
   }
 }
