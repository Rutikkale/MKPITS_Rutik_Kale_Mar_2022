#include<stdio.h>
int main()
{
	int n;
	printf("enter any number\n");
	scanf("%d",&n);
	if(n%n==0&&n%1==0)
	{
		printf("prime number");
	}
	else
	{
		printf("not a prime number");
	}
}
