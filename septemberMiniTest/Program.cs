// Mini practice problem:

// Have the method CheckNums take both parameters being passed.
// Otherwise return the string true if num2 is greater than num1.
// If the parameter values are equal to each other than return the string -1. 

static int CheckNums(int num1, int num2)
{
	if(num2 > num1)
	{
		return 1;
	}
	if (num2 == num1)
	{
		return -1;
	}
	else
	{
		return 0;
	}
}

// Have the method FirstReverse(str) take the str parameter being passed and return the string in reversed order. 
// For example, if the input string is "Hello World and Coders" then your program should return the string. 

static string FirstReverse(string str)
{
	char[] strArray = str.ToCharArray();
	Array.Reverse(strArray);
	return new string(strArray);
}
