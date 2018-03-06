#ifndef CPP_QUEUE_HPP
#define CPP_QUEUE_HPP
#include <cstring>
#include <iostream>
#include <windows.h>
#include <cstdlib>
#define STATIC_TEXT 4
typedef struct carte{
char*   title;
char*   author;
char*   type;
friend int operator!=(carte carte1, carte carte2){
return(!(carte1 == carte2));
}
friend int operator==(carte carte1, carte carte2){
if (strcmp(carte1.title, carte2.title) == 0 && strcmp(carte1.author,carte2.author) == 0 && strcmp(carte1.type,carte2.type)==0)
    return (1);
}
void Show()
{
    std::cout<<title<<std::endl;
    std::cout<<author<<std::endl;
    std::cout<<type<<std::endl;
}
}carte;

struct Node
{
    carte info;
    Node *next;
};

class Queue
{
private:
    Node *data;
public:
    Queue();
    ~Queue();
    Queue operator+(const Queue& Queue2);
    Queue operator=(const Queue& Queue2) const;
    friend int operator!=(Queue Queue1, Queue Queue2);
    friend int operator<(Queue Queue1, Queue Queue2);
    friend int operator>(Queue Queue1, Queue Queue2);
    friend int operator==(Queue Queue1, Queue Queue2);
    Queue* operator>>(Node *Node1);
    Queue* operator>>(carte info1);
    Queue* operator<<(Node *Node1);
    Queue* operator<<(carte info1);
    Node *last() const;
    Node *first() const;
    void Show() const;
    int Len() const;
    void ShowInWindows(HWND hwnd, int positionX, int positionY, int horizontal, int dimension);
    void Clear();
};

/**/
#endif // !CPP_QUEUE_HPP
