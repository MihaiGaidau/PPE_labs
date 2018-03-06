#include <windows.h>
#include <iostream>
#include "Queue.hpp"

enum { ID_LABEL = 1,ID_IMAGE,ID_EDIT,ID_LIST,ID_BUTTON_ADD,ID_BUTTON_CLEAR,ID_COMBO, ID_BUTTON2 };



LRESULT CALLBACK WndProc(HWND, UINT, WPARAM, LPARAM);
Queue myLibrary;

void addMenu(HWND hwnd);
void addCategories(HWND hwnd);
void ShowQueue(HWND hwnd,Queue MyQueue, bool horizontal, int dimension);
HWND        hText,hOut, hOutButton, hClearButton, OutTitle, OutAuthor, OutType;

int WINAPI WinMain(HINSTANCE hInstance, HINSTANCE hPrevInstance, PSTR szCmdLine, int iCmdShow) {

 static TCHAR szAppName[] = TEXT ("HelloWin");
 HWND       hwnd;
 MSG        msg;
 WNDCLASS   wndclass;

 wndclass.style         = CS_HREDRAW | CS_VREDRAW ;
 wndclass.lpfnWndProc   = WndProc;
 wndclass.cbClsExtra    = 0;
 wndclass.cbWndExtra    = 0;
 wndclass.hInstance     = hInstance;
 wndclass.hIcon         = LoadIcon(NULL, IDI_APPLICATION);
 wndclass.hCursor       = LoadCursor(NULL, IDC_ARROW);
 wndclass.hbrBackground = (HBRUSH) COLOR_WINDOW;
 wndclass.lpszMenuName  = NULL;
 wndclass.lpszClassName = szAppName;

 if( !RegisterClass (&wndclass))
 {

     MessageBox (NULL, TEXT("This program requires Windows NT!"), szAppName, MB_ICONERROR) ;

       return 0;
 }
   hwnd = CreateWindow (szAppName,                  //window class name
                        TEXT("My library"),  //window caption
                        WS_OVERLAPPEDWINDOW,        //window style
                        CW_USEDEFAULT,              //initial x position
                        CW_USEDEFAULT,              //initial y position
                        CW_USEDEFAULT,              //initial x size
                        CW_USEDEFAULT,              //initial y size
                        NULL,                       //parent window handle
                        NULL,                       //window menu handle
                        hInstance,                  //program instance handle
                        NULL );                     //creation parameters

       ShowWindow(hwnd, iCmdShow);
       UpdateWindow(hwnd);

       while(GetMessage(&msg, NULL, 0, 0))
       {

           TranslateMessage(&msg);
           DispatchMessage (&msg);
       }
       return msg.wParam;
}

LRESULT CALLBACK WndProc(HWND hwnd, UINT message, WPARAM wParam, LPARAM lParam)
{

    HDC          hdc;
    PAINTSTRUCT  ps;
    RECT         rect, myRect;
    COLORREF    cr;


    switch(message) {
    case WM_CREATE:
        hText = CreateWindowW(L"Static", L"Insert a book:", WS_VISIBLE | WS_CHILD, 30, 50, 400, 30, hwnd, (HMENU)STATIC_TEXT, NULL, NULL);
        static HFONT hFont = CreateFont(30, 0, 0, 0, FW_BOLD, TRUE, 0, 0, 0, 0, 0, 0, 0, "Italic");
        SendMessage(GetDlgItem(hwnd, STATIC_TEXT), WM_SETFONT, (WPARAM)hFont, TRUE);

        hText = CreateWindowW(L"Static", L"Title", WS_VISIBLE | WS_CHILD, 50, 100, 400, 30, hwnd, (HMENU)STATIC_TEXT, NULL, NULL);
        static HFONT hFont1 = CreateFont(30, 0, 0, 0, FW_BOLD, 0, 0, 0, 0, 0, 0, 0, 0, "");
        SendMessage(GetDlgItem(hwnd, STATIC_TEXT), WM_SETFONT, (WPARAM)hFont, TRUE);

        OutTitle = CreateWindowW(L"Edit", L"", WS_VISIBLE | WS_CHILD | WS_BORDER | ES_MULTILINE, 30, 120, 150, 20, hwnd, NULL, NULL, NULL);

        hText = CreateWindowW(L"Static", L"Author", WS_VISIBLE | WS_CHILD, 50, 140, 400, 30, hwnd, (HMENU)STATIC_TEXT, NULL, NULL);
        hFont1 = CreateFont(30, 0, 0, 0, FW_BOLD, 0, 0, 0, 0, 0, 0, 0, 0, "");
        SendMessage(GetDlgItem(hwnd, STATIC_TEXT), WM_SETFONT, (WPARAM)hFont, TRUE);

        OutAuthor = CreateWindowW(L"Edit", L"", WS_VISIBLE | WS_CHILD | WS_BORDER | ES_MULTILINE, 30, 160, 150, 20, hwnd, NULL, NULL, NULL);

        hText = CreateWindowW(L"Static", L"Type", WS_VISIBLE | WS_CHILD, 50, 180, 400, 30, hwnd, (HMENU)STATIC_TEXT, NULL, NULL);
        hFont1 = CreateFont(30, 0, 0, 0, FW_BOLD, 0, 0, 0, 0, 0, 0, 0, 0, "");
        SendMessage(GetDlgItem(hwnd, STATIC_TEXT), WM_SETFONT, (WPARAM)hFont, TRUE);

        OutType = CreateWindowW(L"Edit", L"", WS_VISIBLE | WS_CHILD | WS_BORDER | ES_MULTILINE, 30, 200, 150, 20, hwnd, NULL, NULL, NULL);

        hOutButton = CreateWindowW(L"Button", L"Add to library", WS_VISIBLE | WS_CHILD | WS_BORDER, 50, 600, 100, 25, hwnd, (HMENU)ID_BUTTON_ADD, NULL, NULL);
        GetWindowRect(hwnd, &myRect);
        std::cout<<myRect.right;
        hClearButton = CreateWindowW(L"Button", L"Clear", WS_VISIBLE | WS_CHILD | WS_BORDER, myRect.right - 400, 600, 100, 25, hwnd, (HMENU)ID_BUTTON_CLEAR, NULL, NULL);
        break;
    case WM_SETFONT:

    case WM_COMMAND: //Command from Child windows and menus are under this message
            switch(wParam) //the ID is is wParam
            {
                case ID_BUTTON_ADD: //check for our button ID
                {
                    LPWSTR qwe;
                    char* nname;
                    nname =  new char[30];
                   // std::cout<<"acum";
                    carte myBook;
                    myBook.title = new char[19];
                    myBook.author = new char[19];
                    myBook.type = new char[19];
                  //  char text[100];
                    GetWindowText(OutTitle, myBook.title, 30);
                    GetWindowText(OutAuthor,myBook.author,30);
                    GetWindowText(OutType,myBook.type,30);
                    myLibrary>>myBook;
                  //  myLibrary.Show();
                   // SetWindowText(OutType, "ChangedText");
                   //strcpy(nname,qwe);
                   // std::cout<<myBook.title;
                    // Static labels dont do messages
                    //we can set the text directly though
                    //SetWindowText(static_label,"You clicked the button");
                   // std::cout<<"misa\n";
                   myLibrary.ShowInWindows(hwnd, 400,100,1,40);
                    break;
                }
                case ID_BUTTON_CLEAR:
                    {
                       // myLibrary.Clear();
                       // myLibrary.ShowInWindows(hwnd,400,100,1,40);
                       // ShowWindow(hwnd1, iCmdShow);
                       // UpdateWindow(hwnd1);
                       int ret = MessageBox(hwnd, "Opps, I forget to do this....", "Close", MB_OKCANCEL);
                        if(ret == IDOK)
                        MessageBox(hwnd,"I'm joking, still in working process..","Close",MB_OKCANCEL);
                        break;
                    }
            }
        break;

    case WM_PAINT:

        hdc =  BeginPaint(hwnd, &ps);

        GetClientRect(hwnd, &rect);

       DrawText (hdc, TEXT("This should be here!!!"), -1, &rect, DT_SINGLELINE | DT_CENTER | DT_VCENTER);
       SetTextColor(hdc, RGB(66, 134, 244));
        //DrawText(hdc,TEXT("Eu beu"),-1, &rect, DT_SINGLELINE | DT_CENTER);
        EndPaint(hwnd, &ps);
        return 0;

    case WM_DESTROY:
            PostQuitMessage(0);
             return 0;
        }
        return DefWindowProc (hwnd, message, wParam, lParam);
}

void addMenu(HWND hwnd){

    addCategories(hwnd);
}
void addCategories(HWND hwnd){
}
