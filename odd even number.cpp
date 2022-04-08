#include<stdio.h>
#include<conio.h>
main()
{
	int num,r;
	printf("enter number");
	scanf("%d",&num);
	r=num%2;
	if(r==0)
	{
		printf("number is even %d",num);
	}
	else
	{
		printf("number is odd %d",num);
	}
}
