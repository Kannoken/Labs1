#include <stdio.h>
#include <iostream>
//#include <conio.h>
using namespace std;
struct arr{

	int a,b;
} ;
int main()
{
	int i,k,min1,min2,j,m;
	bool s = true;
	printf("Enter count of detail\n");
	cin >> k;

	struct arr mass[k];
	struct arr ans[k];

    int l=k;
	printf("enter t\n");
	for (i=0;i<k;i++)
	{
		printf("for a:\t");
		cin >> mass[i].a;
		cout << "for b:\t" ;
		cin >> mass[i].b;
	}
	min1 = mass[0].a;
	min2 = mass[0].b;
	m=0;
	int anss[k];
	int p = k/2;
	l=k;
	for (i=0;i<p;i++)
    { m = 0;
        for (j=0;j<k;j++)
        {
            if (min1>=mass[j].a)
            {
                min1=mass[j].a;
                m=j;
            }
        }
        ans[i]=mass[m];
        anss[i]=m+1;
        k=k-1;
        for (j=m;j<k;j++)
        {
            mass[j]=mass[j+1];
        }
        min1=mass[0].a;
        min2=mass[0].b;
        m=0;
        for (j=0;j<k;j++)
        {
            if (min2>=mass[j].b)
            {
                min2=mass[j].b;
                m = j;
            }
        }
        ans[l-i-1]=mass[m];
        anss[l-i-1]=m+1;
        k=k-1;
        for (j=m;j<k;j++)
        {
            mass[j]=mass[j+1];
        }
    }
    if ((l%2)!=0)
    {
        anss[p]=p;
        ans[p]=mass[0];
    }
    for (i=0;i<l;i++)
    {
        printf("%d\n", anss[i]);
      /*  cout<< ans[i].a;
        printf("\t");
        cout<< ans[i].b;
        printf("\n"); */


    }
    return 0;
}
