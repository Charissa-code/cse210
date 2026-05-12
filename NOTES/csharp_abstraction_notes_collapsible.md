# W02 Learning Activity Notes — Abstraction in C#

These notes use collapsible sections so you can hide/show code examples when studying.

---

# 1. What is Abstraction?

## Definition
**Abstraction** is the process of simplifying complex ideas by keeping only the essential details.

In programming:
- We hide complicated implementation details
- We expose only what programmers need to use

---

## Example of Abstraction

<details>
<summary>Click to view code example</summary>

```python
print("hello world")
```

</details>

This looks simple, but internally:
- Thousands of lines of code make this work
- We do not need to know HOW it works
- We only need:
  - function name → `print`
  - required argument → text/value

---

# 2. Objects and Classes

## Object Definition
An **object** is a conceptual model of something that has:
- state (data)
- behavior (actions)

Example:
A `Person` object.

---

## State vs Behavior

| State (Attributes) | Behavior (Methods) |
|---|---|
| given name | show western name |
| family name | show eastern name |

---

# 3. UML / Class Diagram

## Person Class Diagram

<details>
<summary>Click to view diagram text</summary>

```text
Class: Person

Attributes:
- _givenName : string
- _familyName : string

Behaviors:
- ShowEasternName() : void
- ShowWesternName() : void
```

</details>

---

# 4. Naming Conventions in C#

| Item | Convention | Example |
|---|---|---|
| Class names | TitleCase | `Person` |
| Method names | TitleCase | `ShowWesternName()` |
| Member variables | _underscoreCamelCase | `_givenName` |

---

# 5. Person Class Example

<details>
<summary>Click to view full Person class</summary>

```csharp
public class Person
{
    public string _givenName = "";
    public string _familyName = "";

    public Person()
    {
    }

    public void ShowEasternName()
    {
        Console.WriteLine($"{_familyName}, {_givenName}");
    }

    public void ShowWesternName()
    {
        Console.WriteLine($"{_givenName} {_familyName}");
    }
}
```

</details>

---

# 6. Constructor

## Definition
A **constructor** is a special method used when creating an object.

<details>
<summary>Click to view constructor example</summary>

```csharp
public Person()
{
}
```

Used with:

```csharp
Person person = new Person();
```

</details>

---

# 7. Classes and Files

## Rule
Each public class should:
- be in its own file
- file name must match class name

| Class | File |
|---|---|
| Person | Person.cs |
| Book | Book.cs |
| Resume | Resume.cs |

---

# 8. Classes vs Instances

## Class
Blueprint/template.

## Instance (Object)
Actual object created from the class.

<details>
<summary>Click to view example</summary>

```csharp
Person person = new Person();
```

| Part | Meaning |
|---|---|
| Person | class/type |
| person | variable |
| new Person() | creates instance |

</details>

---

# 9. Using Objects

<details>
<summary>Click to view object example</summary>

```csharp
Person person = new Person();

person._givenName = "Joseph";
person._familyName = "Smith";

person.ShowWesternName();
person.ShowEasternName();
```

Output:

```text
Joseph Smith
Smith, Joseph
```

</details>

---

# 10. Multiple Instances

Each object has its own data.

<details>
<summary>Click to view example</summary>

```csharp
Person person1 = new Person();
person1._givenName = "Emma";

Person person2 = new Person();
person2._givenName = "Joseph";
```

</details>

---

# 11. Custom Data Types

## Built-in Types

<details>
<summary>Click to view example</summary>

```csharp
int height;
string color;
```

</details>

## Creating Custom Types

<details>
<summary>Click to view Blind class</summary>

```csharp
public class Blind
{
    public double _width;
    public double _height;
    public string _color;
}
```

</details>

---

# 12. Creating Blind Objects

<details>
<summary>Click to view example</summary>

```csharp
Blind kitchen = new Blind();

kitchen._width = 60;
kitchen._height = 48;
kitchen._color = "white";
```

</details>

---

# 13. Methods Inside Classes

<details>
<summary>Click to view GetArea() example</summary>

```csharp
public double GetArea()
{
    return _width * _height;
}
```

Calling the method:

```csharp
double materialAmount = kitchen.GetArea();
```

</details>

---

# 14. Dot Notation

## Definition
Using a dot (`.`) to access:
- variables
- methods

<details>
<summary>Click to view examples</summary>

```csharp
kitchen._width
kitchen.GetArea()
```

</details>

---

# 15. Objects Inside Objects

<details>
<summary>Click to view House class example</summary>

```csharp
public class House
{
    public string _owner;
    public Blind _kitchen;
    public Blind _livingRoom;
}
```

Initialization:

```csharp
House johnsonHome = new House();

johnsonHome._kitchen = new Blind();
johnsonHome._livingRoom = new Blind();
```

Chained dot notation:

```csharp
johnsonHome._kitchen._width = 60;
```

</details>

---

# 16. Lists of Custom Types

<details>
<summary>Click to view list examples</summary>

```csharp
public List<Blind> _blinds = new List<Blind>();
```

Adding to list:

```csharp
johnsonHome._blinds.Add(kitchen);
```

Accessing list item:

```csharp
double amount = johnsonHome._blinds[0].GetArea();
```

foreach loop:

```csharp
foreach (Blind b in johnsonHome._blinds)
{
    double amount = b.GetArea();
}
```

</details>

---

# 17. Important Terms & Definitions

## Class
A custom data type that defines:
- attributes
- methods

Example:
`Person`

---

## Instance / Object
An actual object created from a class.

Example:

<details>
<summary>Click to view example</summary>

```csharp
Person person1 = new Person();
```

</details>

---

## Instantiate
To create an instance/object.

<details>
<summary>Click to view example</summary>

```csharp
new Person();
```

</details>

---

## Method
A member function inside a class.

<details>
<summary>Click to view example</summary>

```csharp
person.ShowWesternName();
```

</details>

---

# 18. Resume Activity Notes

## Required Classes

### Job Class Responsibilities
- company
- job title
- start year
- end year

Display Format:

```text
Software Engineer (Microsoft) 2019-2022
```

<details>
<summary>Click to view Job class</summary>

```csharp
public class Job
{
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}
```

</details>

---

# 19. Resume Class

<details>
<summary>Click to view Resume class</summary>

```csharp
public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}
```

</details>

---

# 20. Program.cs Example

<details>
<summary>Click to view full Program.cs example</summary>

```csharp
Job job1 = new Job();
job1._jobTitle = "Software Engineer";
job1._company = "Microsoft";
job1._startYear = 2019;
job1._endYear = 2022;

Job job2 = new Job();
job2._jobTitle = "Manager";
job2._company = "Apple";
job2._startYear = 2022;
job2._endYear = 2023;

Resume myResume = new Resume();

myResume._name = "Allison Rose";

myResume._jobs.Add(job1);
myResume._jobs.Add(job2);

myResume.Display();
```

Expected Output:

```text
Name: Allison Rose
Jobs:
Software Engineer (Microsoft) 2019-2022
Manager (Apple) 2022-2023
```

</details>

---

# 21. Key Concepts to Remember

- Abstraction hides complexity
- Classes are blueprints/templates
- Objects are created from classes
- Methods are functions inside classes
- Member variables store data
- Dot notation accesses fields and methods
- Lists can store custom objects
- Each class should have its own `.cs` file

---

# 22. Visual Memory Cheat Sheet

## Class → Blueprint

```text
Class = Recipe
```

## Object → Actual Thing

```text
Object = Cake from recipe
```

## Instance Creation

<details>
<summary>Click to view example</summary>

```csharp
Person p = new Person();
```

</details>

## Accessing Data

<details>
<summary>Click to view example</summary>

```csharp
p._givenName
```

</details>

## Calling Methods

<details>
<summary>Click to view example</summary>

```csharp
p.ShowWesternName();
```

</details>

---

# 23. Most Important Exam/Quiz Ideas

✅ Difference between class and object  
✅ What abstraction means  
✅ Dot notation  
✅ Methods vs attributes  
✅ Constructor purpose  
✅ Lists of objects  
✅ Custom data types  
✅ Each class in separate `.cs` file  
✅ Naming conventions  
✅ Objects can contain other objects

