# <u> C# Documentation by Lim Wei Zhen </u>
Most the contents below are created with reference to "Complete C# Materclass" from Udemy, created by Denis Panjuta. 

If you are interested to learn more, click on the link below to visit the website.  

[Complete C# Masterclass](https://www.udemy.com/course/complete-csharp-masterclass/)

## **Introduction**
This is a C# documentation compiled by Lim Wei Zhen, which only covers the summary of codes, standard practices, and examples. 

## <u> **Section 1.0: Data Types and Variables**</u>

### **Section 1.1: Integral**
There are different data types for integral (whole number), such as :
```csharp
// range from -128 to 127
sbyte x = 120;

// range from -32,768 to 32,767
short x = 30000;

// range from -2,147,483,648 to 2,147,483,647
int x = 2000000;

// range from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
long x = 9000000000;
```
**Tips & Suggestions :**

**Use the smallest data type your value fits into.**
____
### **Section 1.2: Float**
There are different data types for float (floating point value), such as :
```csharp
// range from 1.5 x 10^-45 to 3.4 x 10^38, with 7-digit precision
float x = 99.99f; 
// Take note that "f" is added at the end of the numbers to tell C# that we are referring to float.

// range from 5.0 x 10^-324 to 1.7 x 10^308, 15-digit precision
double x = 15;

// range from -7.9 x 10^28 to 7.9 x 10^28, 28-digit precision
decimal x = 1.5m;
// Take note that "m" is added at the end of the numbers to tell C# that we are referring to decimal.
```
**Tips & Suggestions:**

**Depending on the performance :**
- **Use *`float`* if high demands for processing powers is required.**
- **Use *`double`* for real world values (except money calculations).**
- **Use *`decimal`* for high level of accuracy.**

<br/>

____
<br/>

### **Section 1.3: Boolean**
For boolean, it only allows for two statuses: **`true`**/**`false`**
```csharp
bool switch = false;
```
<br/>

____
<br/>

### **Section 1.4: Unicode Characters And Strings**
There are different data types for strings, such as :
```csharp
// for single character or unicode
char singleLetter = 'A';
// Take note that single quote allows for single character literal or unicode

// for string type data
string username = "WeiZhen123"
// Take note that when defining string data type, the "s" is lower case
```
<br/>

____
<br/>

### **Section 1.5: C# Standard Practice & Guidelines**
Maintaining code is not easy, especially when it is poorly wrtiten and hard to understand, hence it is always a good practice to : 
-  Create reasonable variable name.
```csharp
// refer to user's age
int userAge = 35;
```
- Create proper method name.
```csharp
// method to check internet connection
void CheckInternetConnection(){
    //fancy networking code
}
```
- Include comments.

<br/>

There are multiple ways to include comments in C#, which are :
1. Single-Line Comments :   
Any text between **`//`** and the end of the line is ignored by C# (will not be executed)
```csharp
// a bool to check if user is logged in
bool isUserLoggedIn = true;
```
2. Multiline Comments :  
Any text between **`/*`** and **`*/`** will be ignored by C#.
```csharp
/* these methods are responsible
for storing user data and connecting 
to the database. */
```
3. XML Documentation Comments :  
Typing **`///`** before a class or function to create documentation automatically in Visual Studio. The documentation contains one or more documentation elements. Each element starts with a start tag (e.g. \<summary> )and ends with an end tag (e.g. \</summary>). The following is a list of a few elements with their description.

<p align="center"> 

|**Element**|**Description**|
|---|---|
|\<summary>| Provide Description for Class, member and so on |
|\<param name="i">| Describe a parameter of a method |
|\<returns>| Describe return type of a method |
|\<value>| Describe value of a property |

</p align="center">

```csharp
/// <summary>
/// Add class containing method for addition
/// </summary>
class add
{
    /// <summary>
    /// Result method for getting result
    /// </summary>
    /// <param name="i"> First No. </param>
    /// <param name="j"> Second No. </param>
    /// <returns> returns int which is the sum of two No. </returns>
    public int result(int i, int j)
    {
        return i + j;
    }
}
```
Preview of XML Documentation Comments : 
<p align="center"> 

![Alt text](XML_Documentation_Comments_Preview.png)

</p align="center">
<br/>

____
<br/>

### **Section 1.6: C# Coding Conventions**
Coding conventions are important as they serve the following purposes:
- Create a consistent look to the code, so that readers can focus on content, not layout.
- Enable readers to understand the code more quickly by making assumptions based on previous experience.
- Facilitate copying, changing, and maintaining the code.
- Demonstrate C# best practices.

For a more in-depth explainations on the C# coding conventions, refer to the link below:

[C# Coding Conventions from learn.microsoft.com](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions#place-the-using-directives-outside-the-namespace-declaration)

[C# Coding Standards Best Practices from dofactory.com - Recommend](https://www.dofactory.com/csharp-coding-standards)

<br/>

### <u> ***Naming Conventions*** </u>
To maintain consistency with Microsoft's .Net Framework, below are the common C# naming conventions and best practices. Use these in your own projects and/or adjust these to your own needs.

<br/>

#### **Class & Method**
Use **PascalCasing** for class names and method names.
```csharp
public class ClientActivity
{
    public void ClearStatistics()
    {
        //...
    }
    public void CalculateStatistics()
    {
        //...
    }
}
```
**Why :** To be consistent with the Microsoft's .NET Framework and easy to read.
<br/>
<br/>

#### **Variable & Method Arguments**
Use **camelCasing** for local variables and method arguments.
```csharp
public class UserLog
{
    public void Add(LogEvent logEvent)
    {
        int itemCount = logEvent.Items.Count;
        // ...
    }
}
```
**Why :** To be consistent with the Microsoft's .NET Framework and easy to read.
<br/>
<br/>

#### **Identifiers**
<span style="color:red"> **Do not** </span> use **`Hungarian`** notataion or any other type identification in identifiers.

```csharp
// Correct
int counter;
string name;

// Avoid
int iCounter;
string strName; 
```
**Why :** To be consistent with the Microsoft's .NET Framework. In addition, the Visual Studio IDE makes it very easy to determine the type of a variable (via tooltips). It is best to avoid type indicators in identifiers. 
<br/>
<br/>

#### **Constants**
<span style="color:red"> **Do not** </span> use Screaming Caps for constants or readonly variables.

```csharp
// Correct
public static const string ShippingType = "DropShip";

// Avoid
public static const string SHIPPINGTYPE = "DropShip";
```
**Why :** To be consistent with the Microsoft's .NET Framework. Caps grap too much attention.
<br/>
<br/>

#### **Abbreviations**
<span style="color:red"> **Avoid** </span> using **Abbreviations**.  
Exceptions : Commonly used abbreviations such as Id, Xml, Ftp, Uri.

```csharp
// Correct
UserGroup userGroup;
Assignment employeeAssignment;
 
// Avoid
UserGroup usrGrp;
Assignment empAssignment;
 
// Exceptions
CustomerId customerId;
XmlDocument xmlDocument;
FtpHelper ftpHelper;
UriPart uriPart;
```
**Why :** To be consistent with the Microsoft's .NET Framework. It prevents inconsistent abbreviations by different developers.
<br/>
<br/>

#### **Abbreviation Casing**
Do use **PascalCasing** for abbreviations 3 characters or more (2 chars are both uppercase).
```csharp
HtmlHelper htmlHelper;
FtpTransfer ftpTransfer;
UIControl uiControl;
```
**Why :** To be consistent with the Microsoft's .NET Framework. Caps would grap visually too much attention.
<br/>
<br/>

#### **No Underscores**
<span style="color:red"> **Avoid** </span> use **Underscores** in identifiers.  
Exception: Prefix private static variables with an underscore.

```csharp
// Correct
public DateTime clientAppointment;
public TimeSpan timeLeft;

// Avoid
public DateTime client_Appointment;
public TimeSpan time_left;

// Exception
private DateTime _registrationDate;
```
**Why :** To be consistent with the Microsoft's .NET Framework. It makes code more natural to read (without 'slut). Also avoids underline stress, i.e. inability to see underline.
<br/>
<br/>

#### **Type Names**
Do use **predefined type names** instead of system type names like Int16, Single, UInt64, etc.
```csharp
// Correct
string firstName;
int lastIndex;
bool isSaved;

// Avoid 
String firstName;
Int32 lastIndex;
Boolean isSaved;
```
**Why :** To be consistent with the Microsoft's .NET Framework. It makes code more natural to read.
<br/>
<br/>

#### **Implicit Types**
Do use implicit type **var** for local variable declarations.  
Exception: primitive types (int, string, doulbe, etc) use predefined names.
```csharp
var stream = File.Create(path);
var customers = new Dictionary();

// Exceptions
int index = 100;
string timeSheet;
bool isCompleted;
```
**Why :** To removes clutter, particularly with complex generic types. Type is easily detected with Visual Studio tooltips.
<br/>
<br/>

#### **Noun Class Names**
Do use noun or noun phrases to name a class.
```csharp
public class Employee
{
}
public class DocumentCollection
{
}
```
**Why :** Consistent with the Microsoft's .NET Framework. Makes classes easy to remember.
<br/>
<br/>

#### **Interface**
Do prefix interfaces with the letter **`I`**. Interface names are noun (phrases) or adjectives.
```csharp
public interface IShape
{
}
public interface IShapeCollection
{
}
```
**Why :** To be consistent with the Microsoft's .NET Framework.
<br/>
<br/>

#### **File Names**
Do name source file according to their main classes.  
Exception: File names with partial classess reflect their source or purpose, e.g. designer, generated, etc.
```csharp
// Located in Task.cs
public partial class Task
{
    // ...
}

// Located in Task.generated.cs
public partial class Task
{
    // ...
} 
```
**Why :** To be consistent with the Microsoft practices. Files are alphabetically sorted and partial classess remain adjacent.
<br/>
<br/>

#### **Namespaces**
Do organize namespaces with a clearly defined structure
```csharp
// Examples
namespace Company.Product.Module.SubModule {}
namespace Product.Module.Component {}
namespace Product.Layer.Module.Group {}
```
**Why :** To be consistent with the Microsoft's .NET Framework. Maintains good organization of your code base.
<br/>
<br/>

#### **Curly Brackets**
Do vertically align curly brackets.
```csharp
// Correct
class Program
{
    static void Main(string[] args)
    {
    }
}
```
**Why :** Microsoft has a different standard, but developers have overwhelmingly preferred vertically aligned brackets.
<br/>
<br/>

#### **Member Variables**
Do declare all member variables at the top of a class, with static variables at the very top.
```csharp
// Correct
public class Account
{
    public static string BankName;
    public static decimal Reserves;

    public string Number {get; set;}
    public DateTime DateOpened {get; set;}
    public DateTime DateClosed {get; set;}
    public decimal Balance {get; set;}

    // Constructor
    public Account()
    {
        // ...
    }
}
```
**Why :** Generally accepted practice that prevents the need to hunt for variable declarations.
<br/>
<br/>

#### **Enums**
Do use singular names for enums.  
Exception: bit field enums.
```csharp
// Correct
public enum Color
{
    Red,
    Green,
    Blue,
    Yellow,
    Magenta,
    Cyan
}

// Exception
[Flags]
public enum Dockings
{
    None = 0,
    Top = 1,
    Right = 2,
    Bottom = 4,
    Left = 8
}
```
**Why :** To be consistent with the Microsoft's .NET Framework and makes the code more natural to read. Plural flags because enum can hold multiple values (using bitwise 'OR').
<br/>
<br/>

#### **Enum Types**
<span style="color:red"> **Do not** </span> explicitly specify a type of an enum or values of enums (except bit fields)

```csharp
// Don't
public enum Direction : long
{
    North = 1,
    East = 2,
    South = 3,
    West = 4
}
 
// Correct
public enum Direction
{
    North,
    East,
    South,
    West
}
```
**Why :** Create confusion when relying on actual types and values.
<br/>
<br/>

#### **Enum Suffix**
<span style="color:red"> **Do not** </span> suffix enum names with Enum.

```csharp
// Don't
public enum CoinEnum
{
    Penny,
    Nickel,
    Dime,
    Quarter,
    Dollar
}
 
// Correct
public enum Coin
{
    Penny,
    Nickel,
    Dime,
    Quarter,
    Dollar
}
```
**Why :** To be consistent with the Microsoft's .NET Framework and consistent with prior rule of no type indicators in indentifiers.
<br/>
<br/>

### <u> ***Layout Conventions*** </u>
Good layout uses formatting to emphasize the structure of your code and to make the code easier to read. Microsoft examples and samples conform to the following conventions : 
- Use default Code Editor settings (smart indenting, four-character indents, tab saved as spaces).
- Write only one statement per line.
- Write only one declaration per line.
- If continuation lines are not indented automatically, ident them one tab stop (four spaces).
- Add at least one blank in between method definitions and property definations.
- Use parentheses to make clauses in an expression apparent, as shown in the following code.
```csharp
if ((val1 > val2) && (val1 > val3))
{
    // Take appropriate action.
}
```
<br/>

### <u> ***Place Using Directives Outside Namespace Declaration*** </u>
When a using directive is outside a namespace devlaration, that imported namespace is its fully qualified name. In addition to that, it is much more easier to use, read, and less prone to error.
```csharp
using Azure;

namespace CoolStuff.AwesomeFeature
{
    public class Awesome
}
```
<br/>

### <u> ***Commenting Conventions*** </u>
The common commenting conventions are :
- Place the comment on a separate line, not at the end of a line of code.
- Begin comment text with an uppercase letter.
- End comment text with a period.
- Insert one space between the comment delimiter (//) and the comment text, as shown in the following example.
```csharp
// The following declaration creates a query. It does not run
// the query.
```
- Do not create formatted blocks of asterisks around comments.
- Ensure all public members have the necessary XML comments providing appropriate descriptions about their behavior.
<br/>
<br/>

### <u> ***Language Guidelines*** </u>
The following sections describe practices that the C# team follow to prepare code examples and samples.
<br/>

#### **String Data Type**
Use [string interpolation](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated) to concatenate short strings, as shown in the following code.
```csharp
string displayname = $"{nameList[n].LastName}, {nameList[n].FirstName}";
```
To append strings in loops, especially when you're working with large amounts of text, use a [StringBuilder](https://learn.microsoft.com/en-us/dotnet/api/system.text.stringbuilder?view=net-7.0) object.
```csharp
var phrase = "lalalalalalalalalalalalalalalalalalalalalalalalalalalalalala";
var manyPhrases = new StringBuilder();
for (var i = 0; i < 10000; i++)
{
    manyPhrases.Append(phrase);
}
//Console.WriteLine("tra" + manyPhrases);
```
<br/>

#### **Arrays**
Use the concise syntax when you initialize arrays on the declaration line. In the following example, note that you can't use **`var`** instead of  **`string[]`**.
```csharp
string[] vowels1 = {"a","e","i","o","u"};
```
If you use explicit instatiation, you can use **`var`**.
```csharp
var vowels2 = new string[] {"a","e","i","o","u"};
```
<br/>

#### **`try-catch` And `using` Statements In Exception Handling**
Use a **`try-catch`** statement for most exception handling.
```csharp
static string GetValueFromArray(string[] array, int index)
{
    try
    {
        return array[index];
    }
    catch (System.IndexOutOfRangeException ex)
    {
        Console.WriteLine("Index is out of range: {0}", index);
        throw;
    }
}
```
Simplify your code by using the C# [using statement](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/using). If you have a [try-finally](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/try-finally) statement in which the only code in the finally block is a call to the [Dispose](https://learn.microsoft.com/en-us/dotnet/api/system.idisposable.dispose?view=net-7.0) method, use a **`using`** statement instead.  
In the following example, the **`try-finally`** statement only calls **`Dispose`** in the **`finally`** block.
```csharp
Font font1 = new Font("Arial", 10.0f);
try
{
    byte charset = font1.GdiCharSet;
}
finally
{
    if (font1 != null)
    {
        ((IDisposable)font1).Dispose();
    }
}
```
You can do the same thing with a **`using`** statement.
```csharp
using (Font font2 = new Font("Arial",10.0f))
{
    byte charset2 = font2.GdiCharSet;
}
```
Use the new [using syntax](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/using) that doesn't require braces:
```csharp
using Font font3 = new Font("Arial",10.0f)
byte charset3 = font3.GdiCharSet;
```
<br/>

#### **`&&` And `||` Operators**
To avoid exceptions and increase performance by skipping unnecessary comparisons, use **`&&`** instead of **`&`** and **`||`** instead of **`|`** when you perform comparisons, as shown in the following example.
```csharp
Console.Write("Enter a dividend: ");
int dividend = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter a divisor: ");
int divisor = Convert.ToInt32(Console.ReadLine());

if ((divisor != 0) && (dividend / divisor > 0))
{
    Console.WriteLine("Quotient: {0}", dividend / divisor);
}
else
{
    Console.WriteLine("Attempted division by 0 ends up here.");
}
```
<br/>

#### **`new` Operator**
Use one of the concise forms of object instantiation, as shown in the following declarations. The second example shows syntax that is available starting in C# 9.
```csharp
var instance1 = new ExampleClass();
```
```csharp
ExampleClass instance2 = new();
```
The preceding declarations are equivalent to the following declaration.
```csharp
ExampleClass instance2 = new ExampleClass();
```

Use object initializers to simplify object creation, as shown in the following example.
```csharp
var instance3 = new ExampleClass { Name = "Desktop", ID = 37414,
    Location = "Redmond", Age = 2.3 };
```
The following example sets the same properties as the preceding example but doesn't use initializers.
```csharp
var instance4 = new ExampleClass();
instance4.Name = "Desktop";
instance4.ID = 37414;
instance4.Location = "Redmond";
instance4.Age = 2.3;
```
<br/>

#### **Event Handling**
If you're defining an event handler that you don't need to remove later, use a lambda expression.
```csharp
public Form2()
{
    this.Click += (s, e) =>
        {
            MessageBox.Show(
                ((MouseEventArgs)e).Location.ToString());
        };
}
```
The lambda expression shortens the following traditional definition.
```csharp
public Form1()
{
    this.Click += new EventHandler(Form1_Click);
}

void Form1_Click(object? sender, EventArgs e)
{
    MessageBox.Show(((MouseEventArgs)e).Location.ToString());
}
```
<br/>

____
<br/>

### **Section 1.7: Value Type And Reference Type**
In C#, data types are categorized based on how they store their value in the memory. C# includes the following categories of data types:
- Value type.
- Reference type.
<br/>
<br/>

### <u> ***Value Type*** </u>
A data type is a value type if it holds a data value within its own memory space. It means the variable of these data types directly cotain values. 
```csharp
int i = 100;
```
The following data types are all of value type:
- bool
- byte/sbyte
- decimal/double/float/int/long/short
- char
- enum
- struct
- uimt
- ulong
- ushort
<br/>

#### **Passing Value Type Variables**
When you pass a value type variable from one method to another, the system creates a separate copy of a variable in another method. 

**If value got changed in the method, it wouldn't affect the variable in another method**.
<br/>
<br/>

### <u> ***Reference Type*** </u>
Unlike value types, a reference type doesn't store its value directly. Instead, it stores the address where the value is being stored. In other words, a reference type contains a pointer to another memory location that holds the data. 
```csharp
string s = "Hello World!!";
```
The folloings are reference type data types:
- string
- Arrays (even if their elements are value types)
- Class
- Delegate
<br/>

#### **Passing Reference Type Variables**
When you pass a reference type variable from one method to another, it doesn't create a new copy; instead, it passes the variable's address.

**If we change the value of a variable in a method, it will also be reflected in the calling method**.

<br/>

____
<br/>

### **Section 1.8: Implicit And Explicit Conversion**
The process of converting the value of one type (int, float, double, etc.) to another type is known as type conversion. In C#, there are two basic types of type conversion: 
1. Implicit Type Conversions
2. Explicit Type Conversions

<br/>

### <u> ***Implicit Conversion*** </u>
```csharp
int num = 1223456;
long bigNum = num;

float myFloat = 13.37;
double myNewDouble = myFloat;
```
<br/>

### <u> ***Explicit Conversion*** </u>
```csharp
double myDouble = 13.37;
int myInt;

myInt = (int)myDouble;
```
<br/>

### <u> ***Type Conversion*** </u>
```csharp
string myString = myDouble.ToString();
```

