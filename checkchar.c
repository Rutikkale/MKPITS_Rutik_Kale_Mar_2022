#include<stdio.h>
#include<conio.h>
int main()
{
	char x;
	printf("enter any charecter\n");
	scanf("%c",&x);
	if(x>='A'&&x<='Z')
	{
		printf("enter charecter is capital alphabet");
	}
	else if(x>='a'&&x<='z')
	{
		printf("enter charecter is small alphabet");
	}
	else if(x>='0'&&x<='9')
	{
		printf("enter charecter is digit");
	}
	else
	{
		printf("enter charecter is special symbol");
	}
	}
