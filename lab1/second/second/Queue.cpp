
#include "Queue.hpp"
#include <stdlib.h>
#include <iostream>
Queue::Queue()
{
    data = NULL;

}
Queue::~Queue()
{
    // delete data;
}
Node* Queue::last() const
{
    Node *q;

    q = this->data;
    if (q)
        while (q->next)
            q = q->next;
    else return(NULL);
    return(q);
}

Node* Queue::first() const
{
    if (this->data)
        return(this->data);
    else return(NULL);
}

Queue Queue::operator+(const Queue& Queue2)
{
    Queue newq;
    Node *aux;
    aux = this->first();
    while (aux->next)
    {
        newq >> aux->info;
        aux = aux->next;
    }
    newq >> aux->info;
    aux = Queue2.first();
    while (aux)
    {
        newq >> aux->info;
        aux = aux->next;
    }
    // newq.Show();
    // this->last()->next = Queue2.first();
    return(newq);
}

Queue Queue::operator=(const Queue& Queue2) const
{
    Queue newq;
    Node *aux;

    aux = Queue2.first();
    while (aux)
    {
        newq>>aux->info;
        aux = aux->next;

    }
    return(newq);
}

int operator!=(Queue Queue1, Queue Queue2)
{
    Node *n1;
    Node *n2;
    if (Queue1.Len() != Queue2.Len())
        return(1);
    n1 = Queue1.first();
    n2 = Queue2.first();
    while (n1)
    {
        if (n1->info != n2->info)
            return(1);
        n1 = n1->next;
        n2 = n2->next;
    }
    return(0);
}
int operator<(Queue Queue1, Queue Queue2)
{
    return(Queue1.Len()<Queue2.Len());
}
int operator>(Queue Queue1, Queue Queue2)
{
    return(Queue1.Len()>Queue2.Len());
}
int operator==(Queue Queue1, Queue Queue2)
{
    return(Queue1.Len() == Queue2.Len());
}

Queue* Queue::operator>>(Node *Node1)
{
    if (this->first())
        this->last()->next = Node1;
    else
        this->data = Node1;
    return(this);
}

Queue* Queue::operator>>(carte info1)
{
    Node *aux;

    aux = new Node;
    aux->info = info1;
    aux->next = NULL;
    // aux->next = this->first();
    if (this->first())
        this->last()->next = aux;
    else
        this->data = aux;
    return(this);
}

Queue* Queue::operator<<(Node *Node1)
{
    Node *aux;

    if (this->first() == Node1)
    {
        this->data = this->data->next;
        return(this);
    }
    aux = this->first();
    while (aux)
    {
        if (aux->next == Node1)
            aux->next = Node1->next;
        else
            aux = aux->next;
    }
    return (this);
}

Queue* Queue::operator<<(carte info1)
{
    Node *aux;
    Node *q;

    aux = this->first();
    if (this->first()->info == info1)
    {
        q = this->data;
        this->data = this->data->next;
        delete q;
        return(this);
    }
    while (aux->next)
    {
        if (aux->next->info == info1)
        {
            q = aux->next;
            aux->next = aux->next->next;
            delete q;
        }
        else
            aux = aux->next;
    }
    return (this);
}

void Queue::Show() const
{
    Node *aux;
    aux = this->data;
    while (aux)
    {
        aux->info.Show();
        std::cout<<std::endl;
        aux = aux->next;
    }
}
int Queue::Len() const
{
    int q;

    q = 0;
    Node *aux;
    aux = this->data;
    while (aux)
    {
        aux = aux->next;
        q++;
    }
    return(q);
}
void Queue::ShowInWindows(HWND hwnd, int positionX, int positionY, int horizontal, int dimension)
{
    Node *aux;
    aux = this->data;
    int dif1,dif2;
    wchar_t* text;
    text = new wchar_t[3];
    dif1 = horizontal == 1 ? 0 : dimension;
    dif2 = horizontal == 1 ? dimension : 0;
    if (horizontal)
        while (aux)
        {
            std::cout<<"galea"<<std::endl;
            mbstowcs(text, aux->info.title, strlen(aux->info.title)+1);
            CreateWindowW(L"Static", text, WS_VISIBLE | WS_CHILD, positionX, positionY, 100, 30, hwnd, (HMENU)STATIC_TEXT, NULL, NULL);
            mbstowcs(text, aux->info.author, strlen(aux->info.author)+1);
            CreateWindowW(L"Static", text, WS_VISIBLE | WS_CHILD, positionX + 100, positionY, 100, 30, hwnd, (HMENU)STATIC_TEXT, NULL, NULL);
            mbstowcs(text, aux->info.type, strlen(aux->info.type)+1);
            CreateWindowW(L"Static", text, WS_VISIBLE | WS_CHILD, positionX + 200, positionY, 100, 30, hwnd, (HMENU)STATIC_TEXT, NULL, NULL);
            positionY = positionY + dif2;
            aux = aux->next;
        }
    else
        while (aux)
        {
            mbstowcs(text, aux->info.title, strlen(aux->info.title)+1);
            CreateWindowW(L"Static", text, WS_VISIBLE | WS_CHILD, positionX, positionY, 100, 30, hwnd, (HMENU)STATIC_TEXT, NULL, NULL);
            mbstowcs(text, aux->info.author, strlen(aux->info.author)+1);
            CreateWindowW(L"Static", text, WS_VISIBLE | WS_CHILD, positionX + 100, positionY, 100, 30, hwnd, (HMENU)STATIC_TEXT, NULL, NULL);
            mbstowcs(text, aux->info.type, strlen(aux->info.type)+1);
            CreateWindowW(L"Static", text, WS_VISIBLE | WS_CHILD, positionX + 200, positionY, 100, 30, hwnd, (HMENU)STATIC_TEXT, NULL, NULL);
            positionY = positionY + dif2;
            aux = aux->next;
    }

}
void Queue::Clear()
{
    Node *aux;
    Node *ss;
    aux = this->data;
    while (aux)
    {
        ss = aux;
        aux = aux->next;
        delete ss->info.author;
        delete ss->info.title;

    }
}
