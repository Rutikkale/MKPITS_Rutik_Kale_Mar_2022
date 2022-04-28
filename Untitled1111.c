#include<stdio.h>
int main()
{
	int n,bak,add=0;
	printf("enter any number\n");
	scanf("%d",&n);
	bak=n;
	while(n>0)
	{
	n=n%10;
	add=add+n;
	n=n/10;
	}
	printf("addition of %d = %d",bak,add);
}
