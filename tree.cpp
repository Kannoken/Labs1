#include <iostream>
#include <stdio.h>
#include <locale.h>
#include <Windows.h>
#include <conio.h>
using namespace std;
struct btree
{
    int key;
    btree *left, *right;
};
int maxl=0;
btree * tree=NULL;

void push(int a,btree  **t)
{
    if ((*t)==NULL)
    {
        (*t)=new btree;
        (*t)->key=a;
        (*t)->left=(*t)->right=NULL;
        return;
    }
        if (a>(*t)->key) push(a,&(*t)->right);
       else push(a,&(*t)->left);
}

void print (btree *t, int h)
{
if(t)
{
    if (maxl<h)
        maxl=h;

print(t -> right, h + 1);
for(int j = 0; j < h; j++)
printf(" ");
printf("%d", t -> key);
printf("\n");
print(t -> left, h + 1);
}
}

void Free(btree *t)
{
 if (t->left)
 {
  Free(t->left);
 }
 if (t->right)
 {
  Free(t->right);
 }
 delete t;
 t=NULL;
}

int main ()
{
    setlocale(0,"");
    SetConsoleCP (1251);
    SetConsoleOutputCP (1251);
    int n;
    int s;
    cout<<"Enter count of Leaf  ";
    cin>>n;
    for (int i=0;i<n;i++)
    {
    cout<<"Enter count  ";
    scanf ("%d", &s);
    push(s,&tree);
    }
    cout<<"Your tree\n";
     print(tree,0);
     printf("glubina %d",maxl);
     Free(tree);
     getch();
     return 0;
}

