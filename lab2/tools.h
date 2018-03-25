#include <windows.h>
#include <cstring>
#include <cstdio>
#include <cstdlib>
#include "resources.h"
HMENU   MakeMenu(HWND hwnd);
void HelpMessage(HWND hwnd);
void SetBackgroundColor(HWND hwnd, HDC hdc, COLORREF color);
HWND CreateListBox(HWND hwnd);
int RandomNr(int minim, int maxim);
HWND InitBlueSB(HWND hwnd);
HWND InitRedSB(HWND hwnd);
HWND InitGreenSB(HWND hwnd);
HWND InitHeighScrollBar(HWND hwnd);
HWND InitWidthScrollBar(HWND hwnd);
HWND HorizontallScroll(HWND hwnd);
HWND VerticallScroll(HWND hwnd);
int CalculateScrollPos(int initial_pos, WPARAM wParam);
HWND AddListBox(HWND hwnd);
