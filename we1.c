#include<stdio.h>
int main()
{
	int a,b,c,r;
	printf("enter r\n");
	scanf("%d",&r);
	printf("%d\n%d",a,b);
	c=0;
	while(c<=r)
	{
		c=a+b;
		if(c<=r)
		{
			printf("%d",c);
			
		}
		a=b;
		b=c;
	}
}
