# HackerRank
Only C# Programing

#include<stdio.h>
#include<stdlib.h>

struct node
{
 int a;
 struct node *link;
};

struct node *start=NULL;

void addnode()
{
 struct node *temp,*ch;
 temp=(struct node*)malloc(sizeof(struct node));

 printf("\nEnter the new node data : ");
 scanf("%d",&temp->a);
 temp->link=NULL;

 if(start==NULL) //list is empty
 {
  start =temp;
 }
 else
 {

  ch=start;

 while(ch->link!=NULL)
  {
   ch=ch->link;
  }

  ch->link=temp;
 }


}

void deletenode()
{

}

void InsertNode()
{

  struct node *t,*temp,*ch,*ad,*cnt;
  int loc,len=0,count=0;

  printf("Enter The Location : ");
  scanf("%d",&loc);
 t=(struct node*)malloc(sizeof(struct node));
 printf("\n enter the data:");
scanf("%d",&t->a);
t->link=NULL;

cnt=start;
temp=start;
 while(cnt->link!=NULL)
  {
  len++;
  cnt=cnt->link;
  }

  if(len<loc)
  { printf("Invalid location");
    printf("current list have %d Length",len);
  }
  else
  {
    while(count<loc)
{
  ad=temp;
  temp=temp->link;
   count ++;
  }
ad->link=t;
t->link=temp;
}
}


void DisplayNode()
{
 struct node *temp;
 temp=start;

if(temp==NULL)
 {
  printf("List is Empty");
 }

while(temp!=NULL)
 {
  printf(" %d->",temp->a);
  temp=temp->link;
 }
}

void SearchData()
{
 struct node *temp,*ch,*ad;
 int data,status=0;

 ad->link=NULL;

 printf("Enter the data to be search");
 scanf("%d",&data);
 ch=start;
 while(ch!=NULL)
 {
 if((ch->a)==data)
 {
  status=1;
  ad=ch;

  break;
 }
  ch=ch->link;
 }
if(status==1)
{
printf("Found at location %d",ad);
}
else
{
 printf("Not found");
}
}

int nodelen()
{
 int count=0;
 struct node *temp;
 temp=start;

 while(temp!=NULL)
  {
   count++;
   temp=temp->link;
  }
 printf("Length is %d: ",count);
 return count;
}

int main()
{
  struct node temp;
  int option;

while(1)
{
  printf("\nMENU -  Linked List");
  printf("\n1. Add Node");
  printf("\n2. Delete Node");
  printf("\n3. Insert Node");
  printf("\n4. Display Node");
  printf("\n5. Search Data");
  printf("\n6. Length");
  printf("\n7. Exit");

  printf("\nEnter the option : ");
  scanf("%d",&option);

switch(option)
{
case 1: addnode();
        break;
case 2: deletenode();
        break;
case 3: InsertNode();
        break;
case 4: DisplayNode();
        break;
case 5: SearchData();
        break;
case 6: nodelen();
        break;
case 7: exit(0);
        break;
default: printf("\nInvalid Entry");
        break;
}
}
return 0;
}
~
~
~
~
~

