#include <stdio.h>
#include <iostream>
#include <stdlib.h>
#include <ctype.h>
#include <locale.h>
#include <string.h>
#include <cstring>
using namespace std;
struct Node
{
char str[50];
Node *Next,*Pred;
};
Node *Head=NULL, *Tail=NULL;
void push(Node **pos, char *str)
{   Node *new_elem = new Node;
    strcpy(new_elem->str,str);
    if (Head==NULL)
    {   new_elem->Pred=NULL;
        Head = Tail = new_elem;
    }
    else
    {
        new_elem->Pred = Tail;
        Tail->Next = new_elem;
        Tail = new_elem;
    }

}
char* pop(Node **poss)
{
    Node *new_elem = new Node;
    new_elem = *poss;
    char *name;
    strcpy(name,(*poss)->str);
    *poss = (*poss)->Pred;
    delete(new_elem);
    return name;
}
bool IsEmpty(Node **poss)
{
    if ((*poss)==NULL)
        return true;
    else return false;
}
int main()
{   int k;
    char *name;
    Node *pos = NULL;
    char str[50];
    FILE *f = fopen("s.txt","r");
    while(!feof(f))
    {
        fscanf(f,"%s", &str);
        push(&pos,str);
    }
    int c=0,m=0;
    char* x= pop(&Tail);
    while (!IsEmpty(&Tail))
    {
        name = pop(&Tail);
        if (strcmp(name,x)==0)
        {
          c++;
        }
    }
    printf("%d",c);
fclose(f);
return 0;
}
