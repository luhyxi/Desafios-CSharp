---
tags:
  - projects
Area: "[[!C-Sharp]]"
Status: In progress
topic:
---
# Dia 04/10:


# Dia 05/10:
### Try Catch:
#### !!!!!!1METODOS MAIS FODA AINDA!!!!!!!!!!!!:
```csharp
//
// NÃO PRECISA COLOCAR O READ LINE NA MEMÓRIA!!!
// PODE FAZER ASSIM!!!
// 
TryParse(Cosnole.ReadLine(), out var coisa)

//
// EXEMPLO BASED COM IF NO CASO DE EXCESSÃO!!!!
//

Console.WriteLine("Insira o seu Salario");    
if (!decimal.TryParse(Console.ReadLine().Replace("R$", "").Trim(), out decimal salarioAntes) || salarioAntes < 0)  
{  
    Console.WriteLine("Input errado, cheque se o valor inserido é um numero positivo");  
    return;  
}
```



1. In C#, the `try-catch` block is a fundamental mechanism for handling exceptions, which are unexpected or erroneous situations that can occur during the execution of a program.

2. **Try Block**: The `try` block encloses the code that may potentially throw an exception. It's where you place the code that you want to monitor for exceptions.
```csharp
try
{
    // Code that may throw an exception
}

```

3. **Catch Block**: If an exception is thrown within the `try` block, the program immediately jumps to the corresponding `catch` block. The `catch` block is responsible for handling the exception. You can specify the type of exception you want to catch or catch a general `Exception` type to handle all exceptions.
```csharp
catch (ExceptionType ex)
{
    // Code to handle the exception
}

```

4. **Exception Handling**: Inside the `catch` block, you can write code to handle the exception gracefully. This can include logging the error, displaying a user-friendly message, or taking other appropriate actions to recover from the exception. 
```csharp
try
{
    int result = 10 / 0; // This will throw a DivideByZeroException
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("An error occurred: " + ex.Message);
}


```

### CultureInfo:

**System.Globalization Namespace:** 
The `System.Globalization` namespace provides classes and enumerations for working with culture-specific information, such as date and time formatting, number formatting, and string comparison. It allows you to adapt your applications to different cultures and regions, ensuring that they can display information in a way that is familiar and meaningful to users from various parts of the world.

**Exemples:**
1. **CultureInfo**: This is one of the central classes in this namespace. It represents a specific culture or region and provides information about that culture, such as its language, calendar system, date and time formatting, and number formatting rules.
    
2. **RegionInfo**: This class provides information about a specific geographic region, including its currency, time zones, and more.
    
3. **DateTimeFormatInfo**: It contains information about how dates and times are formatted in a specific culture, including date and time patterns, month and day names, and AM/PM symbols.
    
4. **NumberFormatInfo**: This class contains information about how numbers are formatted in a specific culture, including decimal and thousand separators, currency symbols, and more.

**Example:**
```csharp
using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        // Create a CultureInfo for the French culture
        CultureInfo frenchCulture = new CultureInfo("fr-FR");

        // Format a date using French culture
        DateTime date = DateTime.Now;
        string formattedDate = date.ToString("d", frenchCulture);
        Console.WriteLine(formattedDate); // Output: 06/10/2023 (for French culture)

        // You can similarly use CultureInfo for number formatting and string comparisons.
    }
}
```

## FOCO EM INTERAÇÃO COM O CONSOLE!!
### String Concatenation:
In C#, there are several methods for concatenating strings, each with its own characteristics. Let's explore these methods:

1. **String Concatenation Operator `+`:**
   - **How it Operates:** The `+` operator is a simple and straightforward way to concatenate strings. It works by combining two or more strings into a single string.

   ```csharp
   string str1 = "Hello, ";
   string str2 = "world!";
   string result = str1 + str2; // Concatenates str1 and str2
   ```

2. **String Interpolation (with `$` symbol):**
   - **How it Operates:** String interpolation allows you to embed expressions or variables directly within a string by placing them within curly braces `{}`. The values of the expressions or variables are automatically inserted into the string.

   ```csharp
   string name = "Alice";
   int age = 30;
   string message = $"My name is {name} and I am {age} years old.";
   ```

3. **String.Concat Method:**
   - **How it Operates:** The `string.Concat` method concatenates one or more strings and returns a new string that contains the concatenated values.

   ```csharp
   string str1 = "Hello, ";
   string str2 = "world!";
   string result = string.Concat(str1, str2); // Concatenates str1 and str2
   ```

4. **String.Join Method:**
   - **How it Operates:** The `string.Join` method concatenates an array or collection of strings into a single string, separating them with a specified delimiter.

   ```csharp
   string[] words = { "Hello", "world", "in", "C#" };
   string result = string.Join(" ", words); // Concatenates words with spaces in between
   ```

5. **StringBuilder Class (FASTEST!!!):**
   - **How it Operates:** `StringBuilder` is a mutable class specifically designed for efficient string concatenation, especially when you need to perform many string concatenation operations in a loop. It avoids the performance overhead of repeatedly creating new strings.

   ```csharp
   StringBuilder sb = new StringBuilder();
   sb.Append("Hello, ");
   sb.Append("world!");
   string result = sb.ToString(); // Converts StringBuilder to a string
   ```

   The `StringBuilder` class provides methods like `Append`, `AppendLine`, and `Insert` to build strings efficiently.
### StringBuilder Exemples:

1. **Appending Text in a Loop:**
   You can efficiently build a string by repeatedly appending text in a loop, such as when constructing a long piece of text or generating CSV data.

   ```csharp
   StringBuilder sb = new StringBuilder();
   for (int i = 1; i <= 10; i++)
   {
       sb.Append($"Item {i},");
   }
   string result = sb.ToString();
   // Result will be: "Item 1,Item 2,Item 3,Item 4,Item 5,Item 6,Item 7,Item 8,Item 9,Item 10,"
   ```

2. **Inserting Text at Specific Positions:**
   You can use the `Insert` method to insert text at specific positions within a `StringBuilder`.

   ```csharp
   StringBuilder sb = new StringBuilder("Hello, world!");
   sb.Insert(6, "beautiful ");
   string result = sb.ToString();
   // Result will be: "Hello, beautiful world!"
   ```

3. **Appending Lines with `AppendLine`:**
   `AppendLine` appends a string followed by a line terminator (usually `\r\n` on Windows) to the `StringBuilder`, which is useful when building multi-line text.

   ```csharp
   StringBuilder sb = new StringBuilder();
   sb.AppendLine("Line 1");
   sb.AppendLine("Line 2");
   string result = sb.ToString();
   // Result will be:
   // "Line 1\r\n"
   // "Line 2\r\n"
   ```

4. **Clearing the StringBuilder:**
   You can use the `Clear` method to remove all content from the `StringBuilder`.

   ```csharp
   StringBuilder sb = new StringBuilder("Some text");
   sb.Clear(); // Clears the content
   ```

5. **Setting Capacity:**
   You can set the initial capacity of the `StringBuilder` to optimize performance if you have an idea of how large the final string will be.

   ```csharp
   StringBuilder sb = new StringBuilder(100); // Initial capacity of 100 characters
   ```

6. **Replacing Text:**
   You can replace text within a `StringBuilder` using the `Replace` method.

   ```csharp
   StringBuilder sb = new StringBuilder("Hello, world!");
   sb.Replace("world", "C#");
   string result = sb.ToString();
   // Result will be: "Hello, C#!"
   ```

7. **Appending Formatted Text:**
   You can use the `AppendFormat` method to append formatted text, similar to how you use `string.Format`.

   ```csharp
   StringBuilder sb = new StringBuilder();
   sb.AppendFormat("Name: {0}, Age: {1}", "Alice", 30);
   string result = sb.ToString();
   // Result will be: "Name: Alice, Age: 30"
   ```

8. **Chaining StringBuilder Methods:**
   You can chain multiple `Append` and `AppendLine` methods together to build complex strings efficiently.

   ```csharp
   StringBuilder sb = new StringBuilder();
   sb.Append("Hello")
     .Append(", ")
     .Append("world!")
     .AppendLine()
     .Append("Have a nice day.");
   string result = sb.ToString();
   // Result will be:
   // "Hello, world!"
   // "Have a nice day."
   ```

`StringBuilder` is a versatile class for efficiently manipulating strings, especially when you need to perform multiple string concatenation operations in a memory-efficient way.

### Regex:
**Definition:** Regex (regular expressions) is a set of patterns that get regular expressons and match, search for and manipulate a set of strings to that pattern.
1. **Creating a Pattern -** Regex consist of a combination of characters and metacharacters that have special meanings - **Examples**: 
	`\d{2} 9\d{4}-\d{4}` Formato para numeros de celulares BR
	`\d{3}-\d{2}-\d{4}` Social Security Number (SSN)
2. **Using the Regex Class:** 
	In C#, you can work with regular expressions using the `System.Text.RegularExpressions.Regex` class. You typically create an instance of this class with your regular expression pattern
	
 ```csharp
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = "My SSN is 123-45-6789.";
        string pattern = @"\d{3}-\d{2}-\d{4}";
        Regex regex = new Regex(pattern);
    }
}
 ```

3. **Matching Text:** 
	Once you have a `Regex` instance, you can use its methods to search for and match text in a given input string. The most common methods are:
- `Match`: This method searches for the first occurrence of the pattern in the input string and returns a `Match` object with information about the match.   
- `Matches`: This method finds all occurrences of the pattern in the input string and returns a collection of `Match` objects.
```csharp
Match match = regex.Match(input); 
if (match.Success) 
{     
Console.WriteLine("Found SSN: " + match.Value);
}
```

4. **Accessing Match Information:**
	The `Match` object contains information about the matched text, including the text itself, the starting position, and the length of the match. You can access this information using properties like `Value`, `Index`, and `Length`.

5. **Replacing Text:** 
	Regex can be used to replace parts of a string that match a pattern with another string. You can use the `Regex.Replace` method for this purpose.
```csharp
string newInput = regex.Replace(input, "XXX-XX-XXXX");
Console.WriteLine("Updated input: " + newInput);
```

### Ternary:
In C#, a ternary operator is a concise way to write a conditional expression. It allows you to assign a value to a variable based on a condition. The ternary operator is often used as a shorthand for simple if-else statements. Here's how it works:

The basic syntax of the ternary operator is as follows:

```csharp
variable = (condition) ? expression_if_true : expression_if_false;
```

- `condition`: A Boolean expression that evaluates to either `true` or `false`.
- `expression_if_true`: The value to assign to the variable if the condition is `true`.
- `expression_if_false`: The value to assign to the variable if the condition is `false`.

Here's an example of using the ternary operator to assign a value to a variable based on a condition:

```csharp
int age = 20;
string message = (age >= 18) ? "You are an adult" : "You are a minor";
```

In this example, the condition `(age >= 18)` is evaluated. If it's `true` (in this case, because `age` is 20), the variable `message` will be assigned the string `"You are an adult"`. If it's `false`, it will be assigned the string `"You are a minor"`.

The ternary operator can be used for any data type, not just strings. Here's an example using it for numeric values:

```csharp
int x = 10;
int y = 5;
int result = (x > y) ? x : y; // result will be 10
```

In this case, if `x` is greater than `y`, `result` will be assigned the value of `x`, which is 10. Otherwise, it will be assigned the value of `y`, which is 5.

Ternary operators are handy for simple conditional assignments and can make your code more concise and readable. However, for more complex conditions or multiple possible outcomes, it's often better to use traditional if-else statements for clarity.

Q1: Can you provide an example of using a ternary operator in C# for a scenario other than assigning values to variables?
Q2: Are there any limitations or considerations to keep in mind when using ternary operators in C#?

# Dia 06/10:
### Do-While:
A "Do-While" loop in C# is used when you want to execute a block of code repeatedly based on a condition, but you want to ensure that the code block runs at least once, regardless of whether the condition is initially true or false. Here are some scenarios where you might use a Do-While loop in C#:
```csharp
int count = 0;
do
{
    Console.WriteLine($"This is iteration {count}");
    count++;
} while (count < 5);
```

### Stack and Heap:

#### **Stack:**

1. **Definition:** The stack is a region of memory that follows a Last-In-First-Out (LIFO) data structure. It is used to store local variables, function call information, and control flow data.
2. **Usage in C#:** In C#, the stack is primarily used for managing the execution of methods and storing local variables within those methods. When a method is called, a new stack frame is created to store information about that method's execution, including parameters and local variables.
3. **Faster Access:** Accessing data from the stack is generally faster than the heap because it involves simple pointer manipulation.
4. **Limited Size:** The stack has a limited size, and its memory is allocated at compile-time. This means that you need to know the size of data structures at compile-time, making it less flexible for dynamic memory allocation.
5. **Automatic Memory Management:** Variables on the stack are automatically deallocated when they go out of scope, which means you don't need to manage memory manually for these variables.

#### **Heap:**

1. **Definition:** The heap is a region of memory that follows a more complex memory management scheme, allowing for dynamic allocation and deallocation of memory at runtime.
2. **Usage in C#:** In C#, the heap is used for objects that are created using the `new` keyword. Objects on the heap have a longer lifespan and are not tied to the scope of a single method.
3. **Slower Access:** Accessing data on the heap is generally slower because it involves more complex memory management and pointer dereferencing.
4. **Dynamic Memory Allocation:** The heap allows for dynamic memory allocation, meaning you can create and resize objects as needed during runtime.
5. **Manual Memory Management:** In C#, memory on the heap is managed automatically through a garbage collector. You don't need to explicitly deallocate memory. The garbage collector identifies and reclaims memory that is no longer in use.


### Arrays:

In C#, an array is a data structure that allows you to store and manipulate a collection of elements of the same data type. Arrays provide a way to work with multiple values of the same type under a single variable name. Here's an explanation of arrays in C#:
#### **1 -Initializing with Values:**

**Dynamic Initialization:** Dynamic initialization involves creating an array and then populating it with values one by one, either through a loop or directly assigning values to elements. This method is suitable when you don't know the array's contents at compile-time.

```csharp
int[] dynamicArray = new int[5]; // Create an array with a size of 5
dynamicArray[0] = 1; // Assign values to individual elements
dynamicArray[1] = 2;
dynamicArray[2] = 3;
dynamicArray[3] = 4;
dynamicArray[4] = 5;
```

**Static Initialization:** Static initialization involves creating an array and initializing it with values at the time of declaration. This method is suitable when you know the array's contents at compile-time.

```csharp
int[] staticArray = { 1, 2, 3, 4, 5 }; // Initialize an array with values
```


#### **2 - Length:**
**Usage with One-Dimensional Arrays:**
   - For one-dimensional arrays, such as `int[]` or `string[]`, the `Length` property returns the total number of elements in the array.
   - The index of the last element in the array is one less than the length because array indexing is zero-based.

   ```csharp
   int[] numbers = { 1, 2, 3, 4, 5 };
   int length = numbers.Length; // length will be 5
   int lastElement = numbers[length - 1]; // accessing the last element
   ```

**Usage with Multidimensional Arrays:**
   - For multidimensional arrays, the `Length` property returns the total number of elements across all dimensions.
   - To get the length of a specific dimension in a multidimensional array, you can use the `GetLength` method and specify the dimension you want to query.

   ```csharp
   int[,] matrix = new int[3, 4];
   int totalElements = matrix.Length; // total elements (3x4 = 12)
   int rows = matrix.GetLength(0);    // number of rows (dimension 0) = 3
   int columns = matrix.GetLength(1); // number of columns (dimension 1) = 4
   ```

#### **3- Iterating through an Array:** 

- **Methods:** C# provides several ways to iterate over collections, including `for` loops, `foreach` loops, and LINQ (Language-Integrated Query) methods like `Select`, `Where`, and `Aggregate`.

- **Example with `foreach`:** The `foreach` loop is often used for simple iteration tasks. Here's an example:

  ```csharp
  int[] numbers = { 1, 2, 3, 4, 5 };
  foreach (int number in numbers)
  {
      Console.WriteLine(number);
  }
  ```

  This code iterates through the `numbers` array, printing each element to the console.

- **Example with LINQ:** If you want to perform more complex operations during iteration, LINQ methods can be useful. For instance, you can use `Where` to filter elements based on a condition:

  ```csharp
  int[] numbers = { 1, 2, 3, 4, 5 };
  var evenNumbers = numbers.Where(n => n % 2 == 0);
  ```

  This code creates a new collection `evenNumbers` containing the even elements from the `numbers` array.

- **Custom Iteration:** You can also implement custom iteration behavior in your own classes by defining the `IEnumerable<T>` interface and using `yield return` to yield elements one by one.

- **Iterating Over Other Data Structures:** In addition to arrays and lists, you can iterate over various data structures in C#, such as dictionaries, sets, and queues, using appropriate iteration techniques.

#### 4 - Array Resize
 
   The `Array.Resize` method in C# is used to change the size of an existing one-dimensional array. Here's a brief explanation of how it works:

- **Parameters:** It takes two parameters: the array you want to resize and the new desired length for the array.

- **Resize Behavior:** If the new length is greater than the current length of the array, it adds null (for reference types) or the default value (for value types) to the newly created elements. If the new length is smaller, it truncates the array, removing elements beyond the specified length.

- **Example:** Here's an example of using `Array.Resize`:

  ```csharp
  int[] numbers = { 1, 2, 3, 4, 5 };
  Array.Resize(ref numbers, 7); // Resizes 'numbers' to have 7 elements
  ```

### Acessing Arrays in C#:
1. **Indexing Syntax:**
   - To access an element in an array, you use square brackets `[]` after the array variable name and provide the index of the element you want to access.
   - Array indexing is zero-based, which means the first element has an index of 0, the second element has an index of 1, and so on.

2. **Example with One-Dimensional Array:**
   ```csharp
   int[] numbers = { 10, 20, 30, 40, 50 };
   int firstNumber = numbers[0]; // Access the first element (10)
   int thirdNumber = numbers[2]; // Access the third element (30)
   ```

3. **Example with Multidimensional Array:**
   - For multidimensional arrays, you use multiple indices, each corresponding to a dimension.
   - In a 2D array, you provide two indices, one for the row and one for the column.

   ```csharp
   int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 } };
   int element = matrix[1, 2]; // Access the element in the second row and third column (6)
   ```

### While-True Loop:

1. **Infinite Execution:** When you use `while(true)`, the loop's condition is always `true`, which means the loop will execute repeatedly without any built-in exit condition.

2. **Use Cases:** Infinite loops can be useful in various situations, such as:
   - Creating a continuous-running program, like a server or a game loop.
   - Implementing user interfaces that should remain active until explicitly closed.
   - Developing background processes or services that continuously perform tasks.

3. **Exiting the Loop:** Since `while(true)` loops run indefinitely, you need a way to exit them when a specific condition is met. Common methods for exiting an infinite loop include:
   - Using the `break` statement: You can include conditional checks within the loop and use `break` to exit when a particular condition is satisfied.
   - Setting a flag: You can define a boolean flag variable that, when set to `false`, causes the loop to terminate.
   - Throwing exceptions: You can throw an exception from within the loop to exit it.

Here's an example of a simple `while(true)` loop that continues to execute until a user enters "quit":

```csharp
while (true)
{
    Console.Write("Enter a command (type 'quit' to exit): ");
    string userInput = Console.ReadLine();

    if (userInput.ToLower() == "quit")
    {
        break; // Exit the loop when the user types 'quit'
    }

    // Perform some action based on user input
    Console.WriteLine($"You entered: {userInput}");
}
```

In this example, the loop keeps running until the user enters "quit," at which point it exits due to the `break` statement.

### Difference between `continue` and `break`:

1. **`break`:**
   - The `break` statement is used to exit a loop prematurely.
   - When `break` is encountered within a loop, it immediately terminates the loop, and control flow continues with the code following the loop.
   - `break` is typically used when you want to exit a loop based on a specific condition being met.

   Example:
   ```csharp
   for (int i = 1; i <= 5; i++)
   {
       if (i == 3)
       {
           break; // Exit the loop when i is 3
       }
       Console.WriteLine(i);
   } //Output: 1, 2
   ```

2. **`continue`:**
   - The `continue` statement is used to skip the current iteration of a loop and move to the next iteration.
   - When `continue` is encountered within a loop, it immediately jumps to the next iteration, bypassing the remaining code within the current iteration.
   - `continue` is typically used when you want to skip certain iterations of a loop based on a condition but continue with the next iteration.

   Example:
   ```csharp
   for (int i = 1; i <= 5; i++)
   {
       if (i == 3)
       {
           continue; // Skip the iteration when i is 3
       }
       Console.WriteLine(i);
   } //Output: 1, 2, 4, 5
   ``` 

### Matrizes:

1. **Declaration and Initialization:**
   - Multi-dimensional arrays are declared by specifying the data type, followed by multiple pairs of square brackets `[ , ]` to indicate the number of dimensions.
   - You can initialize a multi-dimensional array directly when declaring it, specifying the dimensions and providing initial values.

   Example of declaration and initialization of a 2D array:
   ```csharp
   int[,] matrix = new int[3, 4]; // Declares a 2D array with 3 rows and 4 columns
   ```

2. **Accessing Elements:**
   - To access elements in a multi-dimensional array, you use multiple indices, each corresponding to a dimension.
   - In a 2D array, you provide two indices: one for the row and one for the column.

   Example:
   ```csharp
   int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 } };
   int element = matrix[1, 2]; // Accesses the element in the second row and third column (6)
   ```

3. **Iterating through Multi-Dimensional Arrays:**
   - You can use nested loops to iterate through the elements of a multi-dimensional array.
   - The outer loop typically iterates through rows, and the inner loop iterates through columns.

   Example:
   ```csharp
   int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 } };
   for (int row = 0; row < 2; row++)
   {
       for (int col = 0; col < 3; col++)
       {
           Console.WriteLine(matrix[row, col]); // Access and print each element
       }
   }
   ```

4. **Usage in Practice:**
   - Multi-dimensional arrays are useful for representing data that has a structured, grid-like arrangement, such as matrices, tables, or game boards.
   - They provide a straightforward way to store and manipulate such data efficiently.

#### Dictionaries:
1. **Declaration and Initialization:**
   - Dictionaries are declared by specifying the key and value data types within angle brackets `< >`.
   - You can initialize a dictionary when declaring it or later using the `new` keyword.

   Example of declaration and initialization of a dictionary:
   ```csharp
   Dictionary<string, int> studentGrades = new Dictionary<string, int>();
   ```

2. **Adding and Retrieving Elements:**
   - You add key-value pairs to a dictionary using the `Add` method, where you specify both the key and the value.
   - You can retrieve values associated with keys using the key as an index.

   Example:
   ```csharp
   studentGrades.Add("Alice", 95);
   studentGrades.Add("Bob", 88);

   int aliceGrade = studentGrades["Alice"]; // Retrieves Alice's grade (95)
   ```

3. **Checking for Key Existence:**
   - It's important to check if a key exists in the dictionary before trying to access it using the indexer.
   - You can use the `ContainsKey` method to check for key existence.

   Example:
   ```csharp
   if (studentGrades.ContainsKey("Charlie"))
   {
       int charlieGrade = studentGrades["Charlie"];
   }
   ```

4. **Iterating through a Dictionary:**
   - You can use a `foreach` loop to iterate through the key-value pairs in a dictionary.

   Example:
   ```csharp
   foreach (KeyValuePair<string, int> pair in studentGrades)
   {
       Console.WriteLine($"Student: {pair.Key}, Grade: {pair.Value}");
   }
   ```
