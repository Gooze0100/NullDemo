using NullDemo;

// default integer value is zero
// it is by default not nullable and default value 0 but it still wants that we assig new value
// int? i = 0;
// from .net 2 you can add ? mark at the end of type
// so ? mark makes the type nullable
// so if type is with mark ? it makes it nullable and then behind the scene it changes the type of that variable
// Int32 default, but when nullable it is a reference type

int? i = null;

// string is reference type
// by default string value is null
// this is because reference types are already nullable
string s = null;

// this is the same as with null because it is reference type
// this is not points to any address in memory
PersonModel p = null;


// when we pass value type it passes copy of value in this example
int j = 5;
int k = j;
j = 10;

// both values are Sue because we copied the reference type 
PersonModel test1 = new();
test1.Name = "Time";
// so this test1 points certain address in memory
PersonModel test2 = test1;
test1.Name = "Sue";

Console.WriteLine(test1.Name);
Console.WriteLine(test2.Name);


// nullable anotation context
// .net 6 and beyond we have this by default
// that is when you go to a project and can find <Nullable>disable</Nullable> property group, this is just for the warnings
// this is shows errors that could be null, so potential errors
// you can change it to like <Nullable>annotations</Nullable>, so this is what would you do if you would be in process to convert your application
// <Nullable>warnings</Nullable> warnings are for just types that cannot be nullable for string and class it does not need to have ? mark

// so from now on when you want to have a reference as null you need to add ? mark after the type
string? s1 = null;
PersonModel? p1 = null;

s = Console.ReadLine();

// so this is giving a warning what we wrote in project properties. so this is saying that your value might be null
// so you should make null check first
// so those warning are giving us the warning on our code where complier thinks we might have a problem, so it helps to work with old projects
// null forgiving operator is ! point so you write it to trick system that it is not null but we sait that it is not
// just removing the warning and not doing anything else
// for certain times you know that it is not null value
// use it when you know for sure that it wont be null
// it lets just ignore invalid warning, but use just then
Console.WriteLine(s!.Length);

// now we do not get any warnings
// so it is smart that you did null check 
if (s is not null)
{
    Console.WriteLine(s.Length);
}

p = new();

// this is ability to write null conditional operator
// this is when after p you write ? mark
// if it is not null then get a name property, but if it is null just short circuit and stop it and declare this as false
// so after Name we can add ? mark too because if p is not null but Name is it will be false
// so with null conditional operator you can check the value before even going forward
// so it says that if it is not null step it if it is null step out
if (p?.Name?.Length > 0)
{
    Console.WriteLine(p.Name.Length);
}
else
{
    Console.WriteLine("This was false");
}

// so this is the same as above but this works as short circuts, so last one is when other is checked
if (p is not null && p.Name is not null && p.Name.Length > 0)
{

}

// this is coalescing operator, so if s is null then it prints hello world, so it puts s value in t unless it is null
// so that means that t never be null
string t = s ?? "Hello world";

Console.WriteLine($"The value of t is {t}");

// list is reference type
List<int>? numbers = null;

numbers = new();
numbers.Add(1);

// if you know that this is not null you can use ! point
// this does that check if value is not null if it is declares new value, if it is not null then dont do anything
// so this is the null coalescing assigning operator
// this is not used very often
(numbers ??= new()).Add(8);


// int? - nullable value type
// string? - nullable reference type
// Id?.ToString(); - null conditional operator
// var v = i ?? 0; - null coalescing operator, check and puts 0 value not it I but in v
// (number ??= new()).Add(8); - null coalescing assignment operator
// <Nullable>enable</Nullable> - nullable annotation context, in .net 5 or below disable or not present, in .net 6 enable 
// 4 values for this - enable, disable, warnings, annotations
// #nullable enable - nullable directive
// 9 options - enable, disable, restore, enable warnings, enable annotations, disable warnings, disable annotations
// s!.ToString(); - null forgiving operator, it can bite, use with caution
// Nullable with generics - https://learn.microsoft.com/en-us/dotnet/csharp/nullable-references#generics


// this ? is conditional operator nothing to do with null
// and this == is inline if statement
int x = 1 == 0 ? 1 : 0;

// this will bite ass
// ust his very carefully use ! points with caution
string test = null;
Console.WriteLine(test!.Length);

// we need to deal with null always, fix errors always