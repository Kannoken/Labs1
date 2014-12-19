#include <stdio.h>

using namespace std;
#include <iostream>
int main()
{
	bool s = TRUE; 
	int n,k,i,j;
	cout << "Enter count of machine" ; 
	scanf("%d", &n); 
	cout << "Enter count of detail";
	scanf("%d", &k); 
	int arr[n][k], ans[k]; 
	cout << "Enter num of t"; 
	for (i=0;i<k;i++)
	{
		for (j=0;j<2;j++)
		{
			scanf("%d", &arr[i][j]); 
		}
		cout << "\n";
	}
	for (i=0;i<k;i++)
	{
		for (j=0;j<k;j++)
	}

return 0;
}