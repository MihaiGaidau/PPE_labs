#if defined(UNICODE) && !defined(_UNICODE)
    #define _UNICODE
#elif defined(_UNICODE) && !defined(UNICODE)
    #define UNICODE
#endif

#include <tchar.h>
#include <windows.h>
#include "tools.h"
#include "resources.h"
#include <cstdio>
#include "DBox.h"
#include <cstdlib>
using namespace std;
int red = 21;
int green = 45;
int blue = 201;
int initScrollPos, scrollPos, numSelected = 0;
int curSelected = 0;
HBRUSH bgBrush;
HWND hwndScroll, HScroll, WScroll, ListBoxx, OutRedW, OutGreenW, OutBlueW,hOutButton, RedScroll, GreenScroll, BlueScroll;
COLORREF bgColor = RGB(21, 45, 201);
RECT rect;
const COLORREF ListColors[] = {RGB(0,255,255),RGB(255, 228, 196), RGB(138, 43, 226),RGB(165, 42, 42), RGB(95, 158, 160)};
HINSTANCE hInst;
LRESULT CALLBACK WindowProcedure (HWND, UINT, WPARAM, LPARAM);

/*  Make the class name into a global variable  */
TCHAR szClassName[ ] = _T("Lab2");

int WINAPI WinMain (HINSTANCE hThisInstance,
                     HINSTANCE hPrevInstance,
                     LPSTR lpszArgument,
                     int nCmdShow)
{
    HWND hwnd;               /* This is the handle for our window */
    MSG messages;            /* Here messages to the application are saved */
    WNDCLASSEX wincl;        /* Data structure for the windowclass */
    hInst = hThisInstance;
    /* The Window structure */
    wincl.hInstance = hThisInstance;
    wincl.lpszClassName = szClassName;
    wincl.lpfnWndProc = WindowProcedure;      /* This function is called by windows */
    wincl.style = CS_DBLCLKS;                 /* Catch double-clicks */
    wincl.cbSize = sizeof (WNDCLASSEX);

    /* Use default icon and mouse-pointer */
    wincl.hIcon = LoadIcon (NULL, IDI_APPLICATION);
    wincl.hIconSm = LoadIcon (NULL, IDI_APPLICATION);
    wincl.hCursor = LoadCursor (NULL, IDC_ARROW);
    wincl.lpszMenuName = NULL;                 /* No menu */
    wincl.cbClsExtra = 0;                      /* No extra bytes after the window class */
    wincl.cbWndExtra = 0;                      /* structure or the window instance */
    /* Use Windows's default colour as the background of the window */
    wincl.hbrBackground = (HBRUSH) COLOR_BACKGROUND;

    /* Register the window class, and if it fails quit the program */
    if (!RegisterClassEx (&wincl))
        return 0;

    /* The class is registered, let's create the program*/
    hwnd = CreateWindowEx (
           0,                   /* Extended possibilites for variation */
           szClassName,         /* Classname */
           _T("Lab2"),       /* Title Text */
           WS_OVERLAPPEDWINDOW, /* default window */
           CW_USEDEFAULT,       /* Windows decides the position */
           CW_USEDEFAULT,       /* where the window ends up on the screen */
           1000,                 /* The programs width */
           700,                 /* and height in pixels */
           HWND_DESKTOP,        /* The window is a child-window to desktop */
           NULL,                /* No menu */
           hThisInstance,       /* Program Instance handler */
           NULL                 /* No Window Creation data */
           );

    /* Make the window visible on the screen */
    ShowWindow (hwnd, nCmdShow);

    /* Run the message loop. It will run until GetMessage() returns 0 */
    while (GetMessage (&messages, NULL, 0, 0))
    {
        /* Translate virtual-key messages into character messages */
        TranslateMessage(&messages);
        /* Send message to WindowProcedure */
        DispatchMessage(&messages);
    }

    /* The program return-value is 0 - The value that PostQuitMessage() gave */
    return messages.wParam;
}


/*  This function is called by the Windows function DispatchMessage()  */

LRESULT CALLBACK WindowProcedure (HWND hwnd, UINT message, WPARAM wParam, LPARAM lParam)
{
    //int red,green,blue;
    RECT curRect, HnowRect,WnowRect;
    GetWindowRect(hwnd,&curRect);
    static HWND hWndEdit;
    switch (message)                  /* handle the messages */
    {
        case WM_CREATE:
            MakeMenu(hwnd);
            RedScroll = InitRedSB(hwnd);
            GreenScroll = InitGreenSB(hwnd);
            BlueScroll = InitBlueSB(hwnd);
            HScroll = InitHeighScrollBar(hwnd);
            WScroll = InitWidthScrollBar(hwnd);
            ListBoxx = AddListBox(hwnd);
            OutRedW = CreateWindowW(L"Edit", L"21", WS_VISIBLE | WS_CHILD | WS_BORDER | ES_MULTILINE, 280, 10, 50, 20, hwnd, NULL, NULL, NULL);
            OutGreenW = CreateWindowW(L"Edit", L"45", WS_VISIBLE | WS_CHILD | WS_BORDER | ES_MULTILINE, 280, 40, 50, 20, hwnd, NULL, NULL, NULL);
            OutBlueW = CreateWindowW(L"Edit", L"201", WS_VISIBLE | WS_CHILD | WS_BORDER | ES_MULTILINE, 280, 70, 50, 20, hwnd, NULL, NULL, NULL);
            hOutButton = CreateWindowW(L"Button", L"Set Color", WS_VISIBLE | WS_CHILD | WS_BORDER, 350, 40, 70, 20, hwnd, (HMENU)ID_BUTTON_ADD, NULL, NULL);
            hOutButton = CreateWindowW(L"Button", L"Set Color", WS_VISIBLE | WS_CHILD | WS_BORDER, 180, 110, 70, 20, hwnd, (HMENU)ID_BUTTON_ADD2, NULL, NULL);

            /*
             hWndEdit = CreateWindow("EDIT", // We are creating an Edit control
                                NULL,   // Leave the control empty
                                WS_CHILD | WS_VISIBLE | WS_HSCROLL |
                                    WS_VSCROLL | ES_LEFT | ES_MULTILINE |
                                    ES_AUTOHSCROLL | ES_AUTOVSCROLL,
                                0, 0, 0, 0, // Let the WM_SIZE messge below take care of the size
                                hwnd,
                                0,
                                hInst,
                                NULL);
            */
            //VerticallScroll(hwnd);
            //VerticallScroll(hwnd);

            //VerticallScroll(hwnd);
        break;
        case WM_SETFOCUS:
           // SetFocus(hWndEdit);
        return 0;
        case WM_COMMAND:
            switch (LOWORD(wParam)){
                case EXIT_FROM_FILE:
                    PostQuitMessage(0);
                break;
                case INFO_FROM_HELP:
                    HelpMessage(hwnd);

                break;
                case MAX_FROM_VIEW:
                    ShowWindow(hwnd,SW_MAXIMIZE);
                    //bgColor = RGB(21, 45, 201);
                    //InvalidateRect(hwnd, NULL, TRUE);
                break;
                case ID_BUTTON_ADD:
                   puts("culev");
                    char *redT,*greenT,*blueT;
                    redT=  new char[30];
                    greenT = new char[30];
                    blueT = new char[30];

                    GetWindowText(OutRedW, redT, 30);
                    GetWindowText(OutGreenW,greenT, 30);
                    GetWindowText(OutBlueW, blueT,30);
                    red = atoi(redT);
                    green = atoi(greenT);
                    blue = atoi(blueT);

                    SetScrollPos(RedScroll, SB_CTL, red, TRUE);
                    SetScrollPos(GreenScroll, SB_CTL, green, TRUE);
                    SetScrollPos(BlueScroll, SB_CTL, blue, TRUE);

                    puts(redT);
                    puts(greenT);
                    puts(blueT);

                    bgColor = RGB(red,green,blue);
                    InvalidateRect(hwnd, NULL, TRUE);
                break;
                case ID_BUTTON_ADD2:
                    printf("%d %d",curSelected, numSelected);
                    bgColor = ListColors[curSelected];

                    SetScrollPos(RedScroll, SB_CTL,GetRValue(bgColor), TRUE);
                    SetScrollPos(GreenScroll, SB_CTL, GetGValue(bgColor), TRUE);
                    SetScrollPos(BlueScroll, SB_CTL, GetBValue(bgColor), TRUE);

                    char ssss[10];
                    sprintf(ssss,"%d",GetRValue(bgColor));
                    SetWindowText(OutRedW,ssss);
                    sprintf(ssss,"%d",GetGValue(bgColor));
                    SetWindowText(OutGreenW,ssss);
                    sprintf(ssss,"%d",GetBValue(bgColor));
                    SetWindowText(OutBlueW,ssss);

                    InvalidateRect(hwnd, NULL, TRUE);
                break;
                case IDLISTBOX:
                    if (HIWORD(wParam) != LBN_SELCHANGE)
                        return 0;
                    curSelected = (int)SendMessage(ListBoxx, LB_GETCURSEL, NULL, NULL);
                    numSelected = (int)SendMessage(ListBoxx, LB_GETITEMDATA, curSelected + 1, NULL);
                    InvalidateRect(hwnd, NULL, TRUE);
                break;
            }
        break;
        case WM_KEYDOWN:
            switch(wParam){
                case 0x48: //h
                    if (GetKeyState(VK_CONTROL) & PRESSED)
                   // HelpMessage(hwnd);
                    ShowDBox(hwnd);
                break;
                case VK_UP:
                    if (GetKeyState(VK_CONTROL) & PRESSED)
                        ShowWindow(hwnd,SW_MAXIMIZE);
                break;
                case VK_DOWN:
                    if (GetKeyState(VK_CONTROL) & PRESSED)
                        ShowWindow(hwnd,SW_NORMAL);
                    break;
            }
            break;
        case WM_ERASEBKGND:
                SetBackgroundColor(hwnd,(HDC)wParam,bgColor);
            return 1;
        case WM_HSCROLL:
            hwndScroll = (HWND)lParam;
            initScrollPos = GetScrollPos(hwndScroll, SB_CTL);
            scrollPos = CalculateScrollPos(initScrollPos, wParam);

            if (!scrollPos)
                return DefWindowProc(hwnd, message, wParam, lParam);

            switch (GetWindowLong(hwndScroll, GWL_ID))
            {
            case WIDTH_SCROLL:
                GetWindowRect(hwnd, &rect);
                SetWindowPos(hwnd,HWND_TOP, rect.left - (scrollPos - initScrollPos), rect.top, rect.right - rect.left + 2*(scrollPos - initScrollPos),rect.bottom - rect.top,SWP_NOZORDER);
                break;
            case RED_SCROLL:
                red = red + (scrollPos - initScrollPos);
                break;
            case GREEN_SCROLL:
                green = green + (scrollPos - initScrollPos);
                break;
            case BLUE_SCROLL:
                blue = blue + (scrollPos - initScrollPos);
                break;
            }
            SetScrollPos(hwndScroll, SB_CTL, scrollPos, TRUE);

            char ssss[10];
            sprintf(ssss,"%d",red);
            SetWindowText(OutRedW,ssss);
            sprintf(ssss,"%d",green);
            SetWindowText(OutGreenW,ssss);
            sprintf(ssss,"%d",blue);
            SetWindowText(OutBlueW,ssss);
            bgColor = RGB(red,green,blue);

            InvalidateRect(hwnd, NULL, TRUE);
            break;
            case WM_VSCROLL:
                 hwndScroll = (HWND)lParam;
                initScrollPos = GetScrollPos(hwndScroll, SB_CTL);
                scrollPos = CalculateScrollPos(initScrollPos, wParam);
                if (!scrollPos)
                    return DefWindowProc(hwnd, message, wParam, lParam);

                switch (GetWindowLong(hwndScroll, GWL_ID))
                {
                case HEIGH_SCROLL:
                    GetWindowRect(hwnd, &rect);
                    SetWindowPos(hwnd,HWND_TOP, rect.left, rect.top - (scrollPos - initScrollPos), rect.right - rect.left,rect.bottom - rect.top + 2*(scrollPos - initScrollPos),SWP_NOZORDER);
                break;
            }
             SetScrollPos(hwndScroll, SB_CTL, scrollPos, TRUE);
             InvalidateRect(hwnd, NULL, TRUE);
            break;
        case WM_SIZE:
            MoveWindow(hWndEdit, 0, 0, LOWORD(lParam), HIWORD(lParam), TRUE);
                // GetWindowRect(hwnd, &curRect);
                //MoveWindow(WScroll,curRect.left + ((curRect.right - curRect.left) / 2) - 75, 600,150,20, TRUE);
                //InvalidateRect(hwnd,NULL,TRUE);
        break;

        case WM_DESTROY:
            PostQuitMessage (0);       /* send a WM_QUIT to the message queue */
            break;
        default:                      /* for messages that we don't deal with */
            return DefWindowProc (hwnd, message, wParam, lParam);
    }

    return 0;
}




