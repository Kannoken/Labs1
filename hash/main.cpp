#include <stdio.h>
#include <iostream>
#include <stdlib.h>
#include <windows.h>
using namespace std;
struct list{
    list *next;
    int value;
};
const int key = 15;
list *mass[15];
list* addtohashtable(list* head,int value,int t)
{   list *p0,*p=NULL;
     if ((p =(list*) malloc(sizeof(list))) == 0) {
        fprintf (stderr, "out of memory (insertNode)\n");
        exit(1);
    }
    p0 = head;
    p =new list;
    head = p;
    p->value = value;
    p->next=p0;
    printf("%d %d\n",t, p->value);
    return p;
}

int hash_f(int num)
{
    return(num % key);
}
int found(int fn)
{
    int k=1;
    list* p = mass[hash_f(fn)];
    while (fn!=p->value)
       {
        k++;
        p = p -> next;
       }
        printf("Количество проб: %d\n",k );
        return hash_f(fn);
}
int main()
{
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);
    int num,value;
    int k,fn;
    FILE * f= fopen("lab5.txt", "r");
    while(!feof(f))
    {
        fscanf(f,"%d", &num);
        k = hash_f(num);
        mass[k] = addtohashtable(mass[k],num,k);
    }

    printf("Введите искомое число:\n");
    scanf("%d", &fn);
    printf("Номер ячейки искомого числа: %d\n", found(fn));
    return 0;
}
