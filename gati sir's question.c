#include<stdio.h>
int main()
{
	int y,m,m1,y1,d1,d2,res;
	printf("enter the first date in y-m-d format\n");
	scanf("%d%d%d",&y,&m,&d1);
	printf("enter the second date in y-m-d format\n");
	scanf("%d%d%d",&y1,&m1,&d2);
	res=d2-d1;
	printf("number of business days: %d",res);
	
}
